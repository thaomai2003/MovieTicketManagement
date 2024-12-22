using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementSystem.Controllers
{
    public partial class customerDashboardForm : UserControl
    {
        public customerDashboardForm()
        {
            InitializeComponent();
            displayAM();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAM();
        }

        public void displayAM()
        {
            movieData mData = new movieData();
            List<movieData> listAvailableData = mData.movieAvailableListData();
            dataGridView1.DataSource = listAvailableData;
        }
    }
}
