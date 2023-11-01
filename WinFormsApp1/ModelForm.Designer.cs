namespace MyInstallments_App
{
    partial class ModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            modelEffect_timer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            CustomerName_lb = new Label();
            NumberOfInstallment_Txt = new Label();
            label6 = new Label();
            ExpiaryDate_Txt = new Label();
            CNameTxt = new Label();
            InstallmentValue_Txt = new Label();
            SuspendLayout();
            // 
            // modelEffect_timer
            // 
            modelEffect_timer.Enabled = true;
            modelEffect_timer.Interval = 1;
            modelEffect_timer.Tick += modelEffect_timer_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 184, 92);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(109, 338);
            button1.Name = "button1";
            button1.Size = new Size(174, 48);
            button1.TabIndex = 1;
            button1.Text = "حفظ ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(289, 338);
            button2.Name = "button2";
            button2.Size = new Size(174, 48);
            button2.TabIndex = 2;
            button2.Text = "الغاء";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(455, 78);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 3;
            label2.Text = "إسم العميل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(448, 141);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 4;
            label3.Text = "عدد ألأقساط";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(442, 206);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 5;
            label4.Text = "قيمة القسط";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(400, 257);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 6;
            label5.Text = "تاريخ إنتهاء ألأقساط";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arabic Typesetting", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(169, 9);
            label10.Name = "label10";
            label10.Size = new Size(219, 51);
            label10.TabIndex = 11;
            label10.Text = "\" تفاصيل القسط \"";
            // 
            // CustomerName_lb
            // 
            CustomerName_lb.AutoSize = true;
            CustomerName_lb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerName_lb.Location = new Point(259, 78);
            CustomerName_lb.Name = "CustomerName_lb";
            CustomerName_lb.Size = new Size(0, 25);
            CustomerName_lb.TabIndex = 12;
            // 
            // NumberOfInstallment_Txt
            // 
            NumberOfInstallment_Txt.AutoSize = true;
            NumberOfInstallment_Txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            NumberOfInstallment_Txt.ForeColor = Color.Black;
            NumberOfInstallment_Txt.Location = new Point(269, 141);
            NumberOfInstallment_Txt.Name = "NumberOfInstallment_Txt";
            NumberOfInstallment_Txt.Size = new Size(0, 25);
            NumberOfInstallment_Txt.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(302, 204);
            label6.Name = "label6";
            label6.Size = new Size(0, 22);
            label6.TabIndex = 15;
            // 
            // ExpiaryDate_Txt
            // 
            ExpiaryDate_Txt.AutoSize = true;
            ExpiaryDate_Txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ExpiaryDate_Txt.ForeColor = Color.Black;
            ExpiaryDate_Txt.Location = new Point(238, 268);
            ExpiaryDate_Txt.Name = "ExpiaryDate_Txt";
            ExpiaryDate_Txt.Size = new Size(0, 25);
            ExpiaryDate_Txt.TabIndex = 16;
            // 
            // CNameTxt
            // 
            CNameTxt.AutoSize = true;
            CNameTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CNameTxt.Location = new Point(266, 80);
            CNameTxt.Name = "CNameTxt";
            CNameTxt.Size = new Size(0, 25);
            CNameTxt.TabIndex = 17;
            // 
            // InstallmentValue_Txt
            // 
            InstallmentValue_Txt.AutoSize = true;
            InstallmentValue_Txt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            InstallmentValue_Txt.ForeColor = Color.Black;
            InstallmentValue_Txt.Location = new Point(302, 209);
            InstallmentValue_Txt.Name = "InstallmentValue_Txt";
            InstallmentValue_Txt.Size = new Size(0, 22);
            InstallmentValue_Txt.TabIndex = 18;
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(571, 466);
            Controls.Add(InstallmentValue_Txt);
            Controls.Add(CNameTxt);
            Controls.Add(ExpiaryDate_Txt);
            Controls.Add(label6);
            Controls.Add(NumberOfInstallment_Txt);
            Controls.Add(CustomerName_lb);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModelForm";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModelForm";
            Load += ModelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer modelEffect_timer;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label CustomerName_lb;
        private Label NumberOfInstallment_Txt;
        private Label label6;
        private Label ExpiaryDate_Txt;
        private Label CNameTxt;
        private Label InstallmentValue_Txt;
    }
}