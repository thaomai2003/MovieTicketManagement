using MovieTicketManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketManagementSystem.DB_Connection
{

    internal class receiptData
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public int ID { get; set; }//0
        public string MovieID { get; set; }//1
        public string SeatNumber { get; set; }//2
        public string Price { get; set; }//3
        public string Amount { get; set; }//4
        public string Change { get; set; }//5
        public string Status { get; set; }//6

        public List<receiptData> receiptListData()
        {
            List<receiptData> listData = new List<receiptData>();

            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "select * from buy_tickets where status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        receiptData rData = new receiptData();

                        rData.ID = Convert.ToInt32(reader["ID"]);
                        rData.MovieID = reader["movie_id"].ToString();
                        rData.SeatNumber = reader["seat_number"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.Amount = reader["amount"].ToString();
                        rData.Change = reader["change"].ToString();
                        rData.Status = reader["status"].ToString();

                        listData.Add(rData);
                    }
                }
            }
            return listData;
        }

        public List<receiptData> availableReceiptListData()
        {
            List<receiptData> listData = new List<receiptData>();

            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "select * from buy_tickets where status = 'PAID' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        receiptData rData = new receiptData();

                        rData.ID = Convert.ToInt32(reader["ID"]);
                        rData.MovieID = reader["movie_id"].ToString();
                        rData.SeatNumber = reader["seat_number"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.Amount = reader["amount"].ToString();
                        rData.Change = reader["change"].ToString();
                        rData.Status = reader["status"].ToString();

                        listData.Add(rData);
                    }
                }
            }
            return listData;
        }

    }
}
