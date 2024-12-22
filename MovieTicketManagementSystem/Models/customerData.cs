using MovieTicketManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketManagementSystem
{
    internal class customerData
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        public int ID { get; set; } //0

        public string Username { get; set; } //1

        public string Password { get; set; } //2

        public string Role { get; set; } //3

        public string Status { get; set; } //4

        public List<customerData> staffDataListData()
        {
            List<customerData> listData = new List<customerData>();

            using(SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "SELECT * FROM users WHERE role = 'Customer' AND status != 'Deleted'";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customerData sData = new customerData();
                        sData.ID = (int)reader[0];
                        sData.Username = reader[1].ToString();
                        sData.Password = reader[2].ToString();
                        sData.Role = reader[3].ToString();
                        sData.Status = reader[4].ToString();

                        listData.Add(sData);
                    }
                }
            }
            return listData;
        }

    }
}
