using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MovieTicketManagementSystem.Helpers;

namespace MovieTicketManagementSystem
{
    public partial class buyTicketForm : UserControl
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        private string movie_id;

        public buyTicketForm()
        {
            InitializeComponent();
            displayAvailableMovies();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAvailableMovies();
        }

            public void displayAvailableMovies()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieAvailableListData();
            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                movie_id = row.Cells[1].Value.ToString();
                buyTicket_movieID.Text = movie_id;
                buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                buyTicket_genre.Text = row.Cells[3].Value.ToString();
                buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();
                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();

                displayAvailableSeats();
            }
        }

        public void displayAvailableSeats()
        {
            if (string.IsNullOrEmpty(movie_id))
            {
                buyTicket_availableChairs.DataSource = null;
                return;
            }

            using (SqlConnection connection = _dbHelper.GetConnection())
            {
                try
                {
                    string selectAvailableSeat = "SELECT capacity FROM movies WHERE delete_date IS NULL AND status != 'Deleted' AND movie_id = @movie_id";
                    int setAvailable = 0;

                    using (SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat, connection))
                    {
                        cmdSelectSeat.Parameters.AddWithValue("@movie_id", movie_id);
                        SqlDataReader reader = cmdSelectSeat.ExecuteReader();

                        if (reader.Read())
                        {
                            setAvailable = (int)reader["capacity"];
                        }
                        reader.Close();
                    }

                    if (setAvailable > 0)
                    {
                        string selectBookSeats = "SELECT seat_number FROM buy_tickets WHERE movie_id = @movie_id";
                        List<int> bookSeat = new List<int>();

                        using (SqlCommand cmd = new SqlCommand(selectBookSeats, connection))
                        {
                            cmd.Parameters.AddWithValue("@movie_id", movie_id);
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                bookSeat.Add((int)reader["seat_number"]);
                            }
                            reader.Close();
                        }

                        List<int> allSeats = Enumerable.Range(1, setAvailable).ToList();
                        List<int> availableSeats = allSeats.Except(bookSeat).ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("seat_number", typeof(int));
                        foreach (int seat in availableSeats)
                        {
                            table.Rows.Add(seat);
                        }

                        buyTicket_availableChairs.DataSource = table;
                        buyTicket_availableChairs.DisplayMember = "seat_number";
                        buyTicket_availableChairs.ValueMember = "seat_number";
                    }
                    else
                    {
                        buyTicket_availableChairs.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        double getTotal = 0;
        private void buyTicket_caculateBtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectPrice = "SELECT movie_id, price FROM movies WHERE movie_id = '" + movie_id +"'";

                double getPrice = 0;
                using(SqlCommand cmd = new SqlCommand(selectPrice, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        getPrice = Convert.ToDouble((reader["price"].Equals(null)) ? 0 : reader["price"]);

                    }
                    reader.Close();
                }

                double getFoodPrice = (buyTicket_foods.SelectedIndex == -1) ? 0 : 100;
                double getDrinkPrice = (buyTicket_drinks.SelectedIndex == -1) ? 0 : 50;

                getTotal = getPrice + getFoodPrice + getDrinkPrice;
                buyTicket_totalPrice.Text = "$" + getTotal.ToString("0.00");
            }
        }

        public void clearSelected()
        {
            id = 0;
            buyTicket_movieID.Text = "";
            buyTicket_movieName.Text = "";
            buyTicket_genre.Text = "";
            buyTicket_regularPrice.Text = "";
            pictureBox1.Image = null;
        }
        private void buyTicket_clear_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        private int id;
        double getChange = 0;
        double getAmount = 0;

        private void buyTicket_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (id == 0 && getTotal == 0)
                {
                    MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (Convert.ToDouble(buyTicket_amount.Text) >= getTotal)
                        {
                            getChange = Convert.ToDouble(buyTicket_amount.Text) - getTotal;
                            getAmount = Convert.ToDouble(buyTicket_amount.Text);
                        }
                        else
                        {
                            MessageBox.Show("Error: Amount should be greater than or equal to Total", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            getChange = 0;
                        }
                        buyTicket_change.Text = "$" + getChange.ToString("0.00");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter numbers only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buyTicket_amount.Text = "";
                        getAmount = 0;

                    }
                }
            }
        }

        private void buyTicket_buyBtn_Click(object sender, EventArgs e)
        {
            if(movie_id == null || getTotal == 0)
            {
                MessageBox.Show("Please select movie first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = _dbHelper.GetConnection())
                {
                    string insertData = "INSERT INTO buy_tickets (movie_id, seat_number, price, amount, change, status, created_at) " +
                        "VALUES(@movieID, @seatNum, @price, @amount, @change, @status, @date)";

                    using(SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@movieID", movie_id);
                        cmd.Parameters.AddWithValue("@seatNum", buyTicket_availableChairs.Text);
                        cmd.Parameters.AddWithValue("@price", getTotal);
                        cmd.Parameters.AddWithValue("@amount", getAmount);
                        cmd.Parameters.AddWithValue("@change", getChange);
                        cmd.Parameters.AddWithValue("@status", "PAID");

                        DateTime today = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", today);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Successfully! occupied: {buyTicket_availableChairs.Text}", 
                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clearSelected();
                        //clearFields();
                    }
                }
            }
        }

        public void clearFields()
        {
            buyTicket_availableChairs.SelectedIndex = -1;
            buyTicket_foods.SelectedIndex = -1;
            buyTicket_drinks.SelectedIndex = -1;
            buyTicket_totalPrice.Text = "$0.00";
            buyTicket_amount.Text = "";
            buyTicket_change.Text = "$0.00";
        }
        private void buyTicket_clearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 100;
            int headerMargin = 10;
            int tableMargin = 10;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat aligncenter = new StringFormat();
            aligncenter.Alignment = StringAlignment.Center;
            aligncenter.LineAlignment = StringAlignment.Center;

            string headerText = "Mei Don't Sleep's Cinema";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left +
                (dataGridView1.Columns.Count / 3) * colWidth, y, aligncenter);
            count++;

            y += tableMargin;

            string[] header = {"ID", "MovieID", "MovieName", "Genre", "RegPrice", "Capacity", "Status" };

            for(int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, aligncenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;
            while(rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                
                for(int q = 0; q < dataGridView1.Columns.Count - 2; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, aligncenter);
                }
                count++;
                rowIndex++;

                if(y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                int labelMargin = (int)Math.Min(rSpace, 100);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-------------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price: \t$" + getTotal.ToString("0.00") + "\nAmount: \t$" + buyTicket_amount.Text
                    + "\n\t\t---------\nChange:\t" + buyTicket_change.Text, labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight (e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black,
                    e.MarginBounds.Right - e.Graphics.MeasureString("------------------------", labelFont).Width, y);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void buyTicket_receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
