﻿


namespace MyInstallments_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = UserNameTxt.Text;

            string password = PasswordTxt.Text;
            if (userName == "Admin" || userName == "admin" && password == "123456")
            {
                this.Hide();
                Services servicesForm = new Services();
                servicesForm.ShowDialog();
            }
            else MessageBox.Show("خطر! هناك خطأ في ألاسم أو ألرقم السري.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eye_btn_Click(object sender, EventArgs e)
        {
            PasswordTxt.UseSystemPasswordChar = false;
            if (PasswordTxt.PasswordChar == '●')
            {
                PasswordTxt.PasswordChar = '\0'; // Show the text
            }
            else
            {
                PasswordTxt.PasswordChar = '●'; // Hide the text
            }
        }
    }
}