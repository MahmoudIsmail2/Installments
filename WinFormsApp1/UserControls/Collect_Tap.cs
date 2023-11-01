using System.Data;
using System.Data.SqlClient;

namespace MyInstallments_App.UserControls
{
    public partial class Collect_Tap : UserControl
    {
        public Collect_Tap()
        {
            InitializeComponent();
        }
        Guid InstallmentId;
        public void DrawData(string? text = null)
        {
            string query;
          
            if (text == null)
            {
                query = "SELECT Id, CustomerName, CustomerPhone " +
                 "FROM Installments " +
                 "WHERE DAY(CreatedDate) = DAY(GETDATE()) " +
                 "AND CAST(CreatedDate AS DATE) != CAST(GETDATE() AS DATE) AND NumberOfInstallments > NumberOfPaiedInstallments ";


            }
            else
            {
                query = $"SELECT Id, CustomerName, CustomerPhone FROM Installments WHERE CustomerName LIKE N'%{text}%'";
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
                        dataTable.Columns.Add("Index", typeof(int));
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataTable.Rows[i]["Index"] = i + 1;
                        }
                        // Check if data is retrieved
                        if (dataTable.Rows.Count > 0)
                        {
                            Clients_table.DataSource = dataTable;
                            Clients_table.Columns["Id"].Visible = false;
                            Clients_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            Clients_table.ScrollBars = ScrollBars.Vertical;
                            Clients_table.Refresh();
                        }
                        else
                        {
                            //MessageBox.Show("لا توجد بيانات");
                        }
                    }
                }
            }
        }
        private void Collect_Tap_Load(object sender, EventArgs e)
        {
            DrawData();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DrawData(guna2TextBox1.Text);
        }
        private void Clients_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = Clients_table.Rows[e.RowIndex];

                var id = (Guid)selectedRow.Cells["Id"].Value;
                string query = $"SELECT * FROM Installments WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(Consts.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter to the query.
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow row = dataTable.Rows[0];
                                Details_Installments_Txt.Text = row["NumberOfInstallments"].ToString();
                                Details_PayedInstallments_Txt.Text = row["NumberOfPaiedInstallments"].ToString();
                                Details_Value_Txt.Text = row["InstallmentValue"].ToString();
                                Details_CreatedDate.Text = ((DateTime)row["CreatedDate"]).ToString("yyyy/MM/dd");
                                DateTime createdDate = (DateTime)row["CreatedDate"];
                                DateTime updatedDate = (DateTime)row["UpdatedDate"];
                                if (createdDate != updatedDate)
                                {
                                    Details_UpdatedDate.Text = ((DateTime)row["UpdatedDate"]).ToString("yyyy/MM/dd");
                                }
                                InstallmentId = id;
                            }

                        }
                    }
                }
            }


        }
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            if(InstallmentId==Guid.Empty)
            {
                MessageBox.Show("يجب عيك اختيار عميل!", "خطر", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(Consts.Connectionstring);
                    connection.Open();
                    string Id = InstallmentId.ToString();
                    string updateQuery = "UPDATE Installments SET NumberOfPaiedInstallments = NumberOfPaiedInstallments + 1, UpdatedDate = @UpdatedDate WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                 
                    MessageBox.Show("تم الدفع بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
         


        }
    }
}
