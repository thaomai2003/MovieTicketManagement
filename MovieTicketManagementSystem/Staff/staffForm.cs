using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementSystem
{
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exitt?", "Confirmation Message", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Show();
            buyTicketForm1.Hide();

            dashboardForm dForm = dashboardForm1 as dashboardForm;

            if (dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void buyTicket_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Hide();
            buyTicketForm1.Show();

            buyTicketForm btForm = buyTicketForm1 as buyTicketForm;

            if (btForm != null)
            {
                btForm.refreshData();
            }
        }
    }
}
