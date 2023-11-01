namespace MyInstallments_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            UserNameTxt = new TextBox();
            pictureBox2 = new PictureBox();
            Eye_btn = new Button();
            panel2 = new Panel();
            PasswordTxt = new TextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 174);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 1;
            label1.Text = "تسجيل الدخول";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(UserNameTxt);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(69, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 63);
            panel1.TabIndex = 2;
            // 
            // UserNameTxt
            // 
            UserNameTxt.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameTxt.Location = new Point(49, 9);
            UserNameTxt.MaxLength = 30;
            UserNameTxt.Multiline = true;
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.PlaceholderText = "اسم المستخدم";
            UserNameTxt.Size = new Size(298, 41);
            UserNameTxt.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Eye_btn
            // 
            Eye_btn.BackColor = Color.White;
            Eye_btn.BackgroundImage = (Image)resources.GetObject("Eye_btn.BackgroundImage");
            Eye_btn.FlatAppearance.BorderSize = 0;
            Eye_btn.FlatAppearance.MouseDownBackColor = Color.White;
            Eye_btn.FlatAppearance.MouseOverBackColor = Color.White;
            Eye_btn.FlatStyle = FlatStyle.Flat;
            Eye_btn.ForeColor = Color.White;
            Eye_btn.Location = new Point(306, 13);
            Eye_btn.Name = "Eye_btn";
            Eye_btn.Size = new Size(29, 34);
            Eye_btn.TabIndex = 17;
            Eye_btn.UseVisualStyleBackColor = true;
            Eye_btn.Click += Eye_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Eye_btn);
            panel2.Controls.Add(PasswordTxt);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(69, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 63);
            panel2.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(49, 9);
            PasswordTxt.MaxLength = 20;
            PasswordTxt.Multiline = true;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '●';
            PasswordTxt.PlaceholderText = "الرقم السري";
            PasswordTxt.Size = new Size(298, 41);
            PasswordTxt.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(151, 395);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(176, 68);
            button1.TabIndex = 4;
            button1.Text = "تسجيل الدخول";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(483, 516);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox PasswordTxt;
        private PictureBox pictureBox3;
        private Button button1;
        private TextBox textBox1;
        private TextBox UserNameTxt;
        private Button Eye_btn;
    }
}