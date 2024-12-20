using System;
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

    public partial class LoginForm : Form
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = _dbHelper.GetConnection())
                {
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            string role = table.Rows[0]["role"].ToString(); 
                            MessageBox.Show("Login Successfully", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information );

                            if(role == "Admin")
                            {
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                            }else if(role == "Staff")
                            {
                                staffForm sForm = new staffForm();
                                sForm.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
