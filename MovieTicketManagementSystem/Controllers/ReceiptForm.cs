using MovieTicketManagementSystem.DB_Connection;
using MovieTicketManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementSystem.Controller
{
    public partial class ReceiptForm : UserControl
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public ReceiptForm()
        {
            InitializeComponent();
            displayData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }

        public void displayData()
        {
            receiptData rData = new receiptData();
            List<receiptData> listData = rData.receiptListData();
            dataGridView1.DataSource = listData;
        }

        public void clearFields()
        {
            receipt_movieID.Text = "";
            receipt_seatNum.Text = "";
            receipt_price.Text = "";
            receipt_amount.Text = "";
            receipt_change.Text = "";
            receipt_status.SelectedIndex = -1;
        }

        private void receipt_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int id = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán trực tiếp giá trị từ các cột
                receipt_receiptID.Text = row.Cells[0].Value?.ToString() ?? "";
                receipt_movieID.Text = row.Cells[1].Value?.ToString() ?? "";
                receipt_seatNum.Text = row.Cells[2].Value?.ToString() ?? "";
                receipt_price.Text = row.Cells[3].Value?.ToString() ?? "";
                receipt_amount.Text = row.Cells[4].Value?.ToString() ?? "";
                receipt_change.Text = row.Cells[5].Value?.ToString() ?? "";
                receipt_status.Text = row.Cells[6].Value?.ToString() ?? "";

                // Nếu cần lưu ID vào biến
                int.TryParse(row.Cells[0].Value?.ToString(), out id);
            }
        }

        private void receipt_deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Delete " + receipt_receiptID.Text
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = _dbHelper.GetConnection())
                    {
                        string updateData = "UPDATE buy_tickets SET delete_date = @deleteDate, status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@status", "Deleted");
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();
                            displayData();
                            clearFields();
                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void receipt_updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update " + receipt_receiptID.Text
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = _dbHelper.GetConnection())
                    {
                        string checkID = "SELECT COUNT(id) FROM buy_tickets WHERE receipt_id = @receiptID";

                        using (SqlCommand cID = new SqlCommand(checkID, connect))
                        {
                            cID.Parameters.AddWithValue("@receiptID", receipt_receiptID.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show($"Receipt ID: " + receipt_receiptID.Text.Trim() + "is taken already."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string updateData = "UPDATE buy_tickets SET receipt_id = @receiptID, movie_id = @movieID, seat_number = @seatNum," +
                                    " price = @price, amount = @amount, change = @change, status = @status, update_date = @updateDate WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@receiptID", receipt_receiptID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@movieID", receipt_movieID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@seatNum", receipt_seatNum.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", receipt_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@amount", receipt_amount.Text.Trim());
                                    cmd.Parameters.AddWithValue("@change", receipt_change.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", receipt_status.SelectedItem.ToString());


                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@updateDate", today);
                                    cmd.Parameters.AddWithValue("@id", id);

                                    cmd.ExecuteNonQuery();
                                    displayData();
                                    clearFields();
                                    MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void receipt_searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = receipt_search.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox

                using (SqlConnection connect = _dbHelper.GetConnection())
                {
                    string query = string.Empty;

                    // Nếu TextBox rỗng, truy vấn tất cả dữ liệu
                    if (string.IsNullOrEmpty(searchQuery))
                    {
                        displayData();
                    }
                    else
                    {
                        // Nếu có từ khóa tìm kiếm, truy vấn dữ liệu theo từ khóa
                        query = @"
                    SELECT receipt_id, movie_id, status 
                    FROM buy_tickets 
                    WHERE receipt_id LIKE @search 
                       OR movie_id LIKE @search 
                       OR status LIKE @search";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Nếu có tìm kiếm, gán tham số cho câu truy vấn
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@search", $"%{searchQuery}%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = table; // Hiển thị dữ liệu phù hợp trong DataGridView
                        }
                        else
                        {
                            dataGridView1.DataSource = null; // Xóa dữ liệu nếu không có kết quả
                            MessageBox.Show("No matching records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

