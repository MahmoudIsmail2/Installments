using Guna.UI2.WinForms;
using MyInstallments_App.UserControls;
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

namespace MyInstallments_App
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            Selling_Tap selling_Tap = new Selling_Tap();
            AddUserContrl(selling_Tap);
        }

        private void AddUserContrl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Selling_Tap selling_Tap = new Selling_Tap();
            AddUserContrl(selling_Tap);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Collect_Tap collect_Tap = new Collect_Tap();
            AddUserContrl(collect_Tap);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Information_Tap information_Tap = new Information_Tap();
            AddUserContrl(information_Tap);
        }

        private void Services_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
