using MyInstallments_App.Classes;
using System.Text.RegularExpressions;
namespace MyInstallments_App.UserControls
{
    public partial class Selling_Tap : UserControl
    {
        public Selling_Tap()
        {
            InitializeComponent();
        }

        public static int parentX, parentY;
        private decimal CalculateInstallmentValue(int numberOfInstallments, decimal itemPurchasePrice, decimal providerValue, int percentage)
        {
            decimal valueAfterDiscountProvider = itemPurchasePrice - providerValue;
            decimal installmentValue = valueAfterDiscountProvider + (valueAfterDiscountProvider * (decimal)percentage / 100);
            decimal roundedValue = Math.Round(installmentValue, 3);
            decimal result = Math.Round(roundedValue / numberOfInstallments, 3);
            return result;
        }

        private bool Checkalphanumeric(string value)
        {
            bool containsLetter = value.Any(c => Char.IsLetter(c));
            bool isAlphanumeric = containsLetter && value.All(c => Char.IsLetterOrDigit(c));
            return isAlphanumeric;
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {

            int period;
            if (InstallmentType_txt.Text == "١٠ شهور")
                period = 10;
            else if (InstallmentType_txt.Text == "١٢ شهر ")
                period = 12;
            else if (InstallmentType_txt.Text == "١٨ شهر")
                period = 18;
            else if (InstallmentType_txt.Text == "٦ شهور")
                period = 6;
            else
                period = 24;

            if (PPrice_txt.Text == "" || CustomerName_txt.Text == "" || Provider_txt.Text == "" || InstallmentType_txt.Text == "" || ProductTxt.Text == "" || PercentageTxt.Text == "")
            {
                MessageBox.Show("يجب عليك اكمال البيانات!", "خطر", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string phoneTxt = CustomerPhone_txt.Text;
                string providerTxt = Provider_txt.Text;
                string purchasePrice = PPrice_txt.Text;
                string percentage = PercentageTxt.Text;
                if (Checkalphanumeric(phoneTxt) || Checkalphanumeric(providerTxt) || Checkalphanumeric(purchasePrice) || Checkalphanumeric(percentage))
                {
                    MessageBox.Show("يجب عليك ادخال بيانات صحيحه!", "خطر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InstallmentDetails installmentDetails = new InstallmentDetails
                    {
                        CustomerName = CustomerName_txt.Text,
                        CustomerPhone = CustomerPhone_txt.Text,
                        Product = ProductTxt.Text,
                        ItemPurchasePrice = decimal.Parse(PPrice_txt.Text),
                        ProviderValue = decimal.Parse(Provider_txt.Text),
                        InstallmentPeriodType = period,
                        InstallmentExpirayDate = DateTime.Now.AddMonths(period),
                        NumberOfInstallments = period,
                        InstallmentValue = CalculateInstallmentValue(period, decimal.Parse(PPrice_txt.Text), decimal.Parse(Provider_txt.Text), int.Parse(percentage))
                    };
                    if (installmentDetails.ProviderValue >= installmentDetails.ItemPurchasePrice)
                    {
                        MessageBox.Show("يجب ان تقل قيمة المقدم عن قيمة شراء الصفقه!", "خطر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        Services modelBackground = new Services();
                        using (ModelForm modelForm = new ModelForm(installmentDetails))
                        {
                            modelBackground.StartPosition = FormStartPosition.Manual;
                            modelBackground.FormBorderStyle = FormBorderStyle.None;
                            modelBackground.Opacity = -50;
                            modelBackground.BackColor = Color.Black;
                            modelBackground.Size = this.Size;
                            modelBackground.Location = this.Location;
                            modelBackground.ShowInTaskbar = false;
                            modelForm.Owner = modelBackground;

                            parentX = this.Location.X;
                            parentY = this.Location.Y;

                            modelForm.ShowDialog();
                            modelBackground.Dispose();
                        }

                    }
                }

            }



        }

        private void Eye_btn_Click(object sender, EventArgs e)
        {
            PPrice_txt.UseSystemPasswordChar = false;
            if (PPrice_txt.PasswordChar == '●')
            {
                PPrice_txt.PasswordChar = '\0'; // Show the text
            }
            else
            {
                PPrice_txt.PasswordChar = '●'; // Hide the text
            }
        }

        private void Selling_Tap_Load(object sender, EventArgs e)
        {

        }

        private void Provider_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
