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
using static System.Net.Mime.MediaTypeNames;

namespace MyInstallments_App.UserControls
{
    public partial class Information_Tap : UserControl
    {
        public Information_Tap()
        {
            InitializeComponent();
        }
        public void DrawData(string? text = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            string query;           
            if (startDate != null && endDate != null)
            {
                DateTime start = ((DateTime)startDate).Date;
                DateTime end = ((DateTime)endDate).Date.AddDays(1).AddSeconds(-1);
                query = $"SELECT Id, CustomerName, CustomerPhone, Product, InstallmentValue, NumberOfInstallments, ItemPurchasePrice FROM Installments WHERE CreatedDate >= '{start}' AND CreatedDate <= '{end}'";
            }
            else
            {
                if (text == null)
                {
                    query = "SELECT Id,CustomerName,CustomerPhone,Product,InstallmentValue,NumberOfInstallments,ItemPurchasePrice FROM Installments ";


                }
                else
                {
                    query = $"SELECT Id, CustomerName, CustomerPhone ,Product,InstallmentValue,NumberOfInstallments,ItemPurchasePrice FROM Installments WHERE CustomerName LIKE N'%{text}%'";
                }
            }
          
            using (SqlConnection connection = new SqlConnection(Consts.Connectionstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataTable.Columns.Add("Profit", typeof(int));
                        var nCustomers = dataTable.Rows.Count;

                        decimal profits = 0;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            decimal installmentValue = Convert.ToDecimal(row["InstallmentValue"]);
                            int numberOfInstallments = Convert.ToInt32(row["NumberOfInstallments"]);
                            decimal itemPurchasePrice = Convert.ToDecimal(row["ItemPurchasePrice"]);

                            decimal profit = installmentValue * numberOfInstallments - itemPurchasePrice;
                            row["Profit"] = profit;
                            profits += profit;
                        }
                        // Check if data is retrieved
                        if (dataTable.Rows.Count > 0)
                        {
                            Profts_table.DataSource = dataTable;
                            Profts_table.Columns["Id"].Visible = false;
                            Profts_table.Columns["InstallmentValue"].Visible = false;
                            Profts_table.Columns["ItemPurchasePrice"].Visible = false;
                            Profts_table.Columns["NumberOfInstallments"].Visible = false;
                            Profts_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            Profts_table.ScrollBars = ScrollBars.Vertical;
                            Profts_table.Refresh();
                        }
                        else
                        {
                            Profts_table.DataSource = null; // Clear the existing data
                            Profts_table.Rows.Clear(); // Remove any existing rows

                        }
                        Customers.Text = nCustomers.ToString();
                        Profits.Text = profits.ToString();
                    }
                }
            }
        }
        private void Information_Tap_Load(object sender, EventArgs e)
        {
            DrawData();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DrawData(guna2TextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var startDate = StartDate.Value;
            var endDate = EndDate.Value;
           
            DrawData(null, startDate, endDate);
        }
    }
}
