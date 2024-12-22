using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MovieTicketManagementSystem.Helpers;

namespace MovieTicketManagementSystem
{
    internal class movieData
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        public int ID { get; set; }//0
        public string MovieID { get; set; }//1
        public string MovieName { get; set; }//2
        public string Genre { get; set; }//3
        public string Price { get; set; }//4
        public string Capacity { get; set; }//5
        public string Status { get; set; }//6
        public string Image {  get; set; } //7
        public string Date {  get; set; }//8

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using(SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "SELECT * FROM movies WHERE delete_date IS NULL";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["ID"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }
            return listData;
        }

        public List<movieData> movieAvailableListData()
        {
            List<movieData> listAvailableData = new List<movieData>();

            using (SqlConnection connect = _dbHelper.GetConnection())
            {
                string selectData = "SELECT * FROM movies WHERE status = 'Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData amData = new movieData();

                        amData.ID = Convert.ToInt32(reader["ID"]);
                        amData.MovieID = reader["movie_id"].ToString();
                        amData.MovieName = reader["movie_name"].ToString();
                        amData.Genre = reader["genre"].ToString();
                        amData.Price = reader["price"].ToString();
                        amData.Capacity = reader["capacity"].ToString();
                        amData.Status = reader["status"].ToString();
                        amData.Image = reader["movie_image"].ToString();
                        amData.Date = reader["created_at"].ToString();
                       

                        listAvailableData.Add(amData);
                    }
                }
            }
            return listAvailableData;
        }

    }
}
