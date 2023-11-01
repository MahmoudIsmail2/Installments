using MyInstallments_App.Classes;
using System.Data.SqlClient;

namespace MyInstallments_App
{
    public partial class ModelForm : Form
    {
        private InstallmentDetails receivedInstallmentDetails;
        public ModelForm(InstallmentDetails installmentDetails)
        {
            receivedInstallmentDetails = installmentDetails;
            InitializeComponent();
        }

        private void modelEffect_timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modelEffect_timer.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }
        int i;
        private void ModelForm_Load(object sender, EventArgs e)
        {
            CNameTxt.Text = receivedInstallmentDetails.CustomerName;
            NumberOfInstallment_Txt.Text = receivedInstallmentDetails.NumberOfInstallments.ToString();
            ExpiaryDate_Txt.Text = receivedInstallmentDetails.InstallmentExpirayDate.ToString("yyyy/MM/dd");
            InstallmentValue_Txt.Text = receivedInstallmentDetails.InstallmentValue.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var data = receivedInstallmentDetails;
            //  string connectionString = "Data Source=DESKTOP-97DF3IJ\\NEWSQLEXPRESS;Initial Catalog=DbInstallments;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(Consts.Connectionstring))
            {
                con.Open();
                
                string insertCommand = @"
             INSERT INTO Installments (  
                Id,
                CustomerName, 
                CustomerPhone, 
                ProviderValue, 
                NumberOfInstallments, 
                InstallmentValue, 
                NumberOfPaiedInstallments, 
                InstallmentsExpiaryDate, 
                CreatedDate, 
                ItemPurchasePrice, 
                NumberOfLatedInstallments,
                UpdatedDate,
                Product
            ) VALUES (
                @Id,
                @CustomerName, 
                @CustomerPhone, 
                @ProviderValue, 
                @NumberOfInstallments, 
                @InstallmentValue, 
                @NumberOfPaiedInstallments, 
                @InstallmentsExpiaryDate, 
                @CreatedDate, 
                @ItemPurchasePrice, 
                @NumberOfLatedInstallments,
                @UpdateDate,
                @Product
            )";

                using (SqlCommand cmd = new SqlCommand(insertCommand, con))
                {
                    // Set the parameter values
                    cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
                    cmd.Parameters.AddWithValue("@CustomerName", data.CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerPhone", data.CustomerPhone);
                    cmd.Parameters.AddWithValue("@ProviderValue", data.ProviderValue);
                    cmd.Parameters.AddWithValue("@NumberOfInstallments", data.NumberOfInstallments);
                    cmd.Parameters.AddWithValue("@InstallmentValue", data.InstallmentValue);
                    cmd.Parameters.AddWithValue("@NumberOfPaiedInstallments", 0);
                    cmd.Parameters.AddWithValue("@InstallmentsExpiaryDate", DateTime.Now.AddMonths(data.NumberOfInstallments));
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ItemPurchasePrice", data.ItemPurchasePrice);
                    cmd.Parameters.AddWithValue("@NumberOfLatedInstallments", 0);
                    cmd.Parameters.AddWithValue("@UpdateDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Product", data.Product);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حفظ البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        if (this.Owner is Services)
                        {
                            ((Services)this.Owner).Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "خطر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.Close();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
