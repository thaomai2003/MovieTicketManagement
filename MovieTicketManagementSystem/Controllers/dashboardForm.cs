﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MovieTicketManagementSystem.Helpers;

namespace MovieTicketManagementSystem
{
    public partial class dashboardForm : UserControl
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public dashboardForm()
        {
            InitializeComponent();

            displayAvailableMovies();
            displayTotalCustomer();
            displayTotalBuys();
            displayTotalIncome();
            displayAM();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAvailableMovies();
            displayTotalCustomer();
            displayTotalBuys();
            displayTotalIncome();
            displayAM();
        }

            public void displayAM()
        {
            movieData mData = new movieData();
            List<movieData> listAvailableData = mData.movieAvailableListData();
            dataGridView1.DataSource = listAvailableData;
        }
        public void displayAvailableMovies()
        {
            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "SELECT COUNT(id) AS avMovie FROM movies WHERE status = 'Available'";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["avMovie"] != DBNull.Value)
                        {
                            decimal totalAVMovie = Convert.ToDecimal(reader["avMovie"]);

                            dashboard_availableMovies.Text = totalAVMovie.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalCustomer()
        {
            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "select count(id) as totalCustomer from users where role = 'Customer' and status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalCustomer"] != DBNull.Value)
                        {
                            decimal totalCustomer = Convert.ToDecimal(reader["totalCustomer"]);

                            dashboard_totalStaff.Text = totalCustomer.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalBuys()
        {
            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "select count(id) as totalBuys from buy_tickets where status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalBuys"] != DBNull.Value)
                        {
                            decimal totalBuys = Convert.ToDecimal(reader["totalBuys"]);

                            dashboard_totalBuy.Text = totalBuys.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalIncome()
        {
            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "select sum(price) as totalIncome from buy_tickets where status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalIncome"] != DBNull.Value)
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["totalIncome"]);

                            dashboard_totalIncome.Text = "$" + totalIncome.ToString("0.00");
                        }
                    }
                }
            }
        }

    }
}
