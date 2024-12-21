using MovieTicketManagementSystem.Controller;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Are you sure you want to exit this application?", "Confirm Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirm Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();

              
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Show();
            addStaffsForm2.Hide();
            addMovieForm2.Hide();
            receiptForm1.Hide();

            dashboardForm dForm = dashboardForm2 as dashboardForm;

            if(dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void addStaff_btn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Hide();
            addStaffsForm2.Show();
            addMovieForm2.Hide();
            receiptForm1.Hide();

            AddStaffsForm asForm = addStaffsForm2 as AddStaffsForm;

            if (asForm != null)
            {
                asForm.refreshData();
            }
        }

        private void addMovie_btn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Hide();
            addStaffsForm2.Hide();
            addMovieForm2.Show();
            receiptForm1.Hide();

            AddMovieForm amForm = addMovieForm2 as AddMovieForm;

            if (amForm != null)
            {
                amForm.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm2.Hide();
            addStaffsForm2.Hide();
            addMovieForm2.Hide();
            receiptForm1.Show();

            ReceiptForm rForm = receiptForm1 as ReceiptForm;

            if (rForm != null)
            {
                rForm.refreshData();
            }
        }
    }
}
