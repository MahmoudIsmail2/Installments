namespace MyInstallments_App.UserControls
{
    partial class Information_Tap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information_Tap));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Profts_table = new Guna.UI2.WinForms.Guna2DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            Profits = new Label();
            label5 = new Label();
            label6 = new Label();
            Customers = new Label();
            label2 = new Label();
            StartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            EndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)Profts_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.Gainsboro;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(778, 37);
            guna2TextBox1.Margin = new Padding(5, 4, 5, 4);
            guna2TextBox1.MaxLength = 50;
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "بحث بالاسم";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(686, 47);
            guna2TextBox1.TabIndex = 1;
            guna2TextBox1.TextAlign = HorizontalAlignment.Right;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // Profts_table
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Profts_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Profts_table.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Profts_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Profts_table.ColumnHeadersHeight = 52;
            Profts_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Profts_table.Columns.AddRange(new DataGridViewColumn[] { CustomerName, Phone, Item, Profit, Id });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Profts_table.DefaultCellStyle = dataGridViewCellStyle3;
            Profts_table.GridColor = Color.White;
            Profts_table.Location = new Point(16, 101);
            Profts_table.Name = "Profts_table";
            Profts_table.ReadOnly = true;
            Profts_table.RightToLeft = RightToLeft.Yes;
            Profts_table.RowHeadersVisible = false;
            Profts_table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Profts_table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            Profts_table.RowTemplate.Height = 29;
            Profts_table.Size = new Size(1448, 553);
            Profts_table.TabIndex = 5;
            Profts_table.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Profts_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            Profts_table.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Profts_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Profts_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Profts_table.ThemeStyle.BackColor = Color.White;
            Profts_table.ThemeStyle.GridColor = Color.White;
            Profts_table.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Profts_table.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Profts_table.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Profts_table.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Profts_table.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Profts_table.ThemeStyle.HeaderStyle.Height = 52;
            Profts_table.ThemeStyle.ReadOnly = true;
            Profts_table.ThemeStyle.RowsStyle.BackColor = Color.White;
            Profts_table.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Profts_table.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Profts_table.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Profts_table.ThemeStyle.RowsStyle.Height = 29;
            Profts_table.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Profts_table.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "اسم العميل";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "CustomerPhone";
            Phone.HeaderText = "رقم الهاتف";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Item
            // 
            Item.DataPropertyName = "Product";
            Item.HeaderText = "المنتج";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.ReadOnly = true;
            // 
            // Profit
            // 
            Profit.DataPropertyName = "Profit";
            Profit.HeaderText = "الربح";
            Profit.MinimumWidth = 6;
            Profit.Name = "Profit";
            Profit.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(805, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1307, 34);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "عدد العملاء";
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.AliceBlue;
            guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2CustomGradientPanel1.Controls.Add(Profits);
            guna2CustomGradientPanel1.Controls.Add(label5);
            guna2CustomGradientPanel1.Controls.Add(label6);
            guna2CustomGradientPanel1.Controls.Add(Customers);
            guna2CustomGradientPanel1.Controls.Add(label2);
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Location = new Point(16, 660);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(1448, 112);
            guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // Profits
            // 
            Profits.AutoSize = true;
            Profits.BackColor = Color.White;
            Profits.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Profits.Location = new Point(166, 34);
            Profits.Name = "Profits";
            Profits.Size = new Size(26, 31);
            Profits.TabIndex = 5;
            Profits.Text = "..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(318, 34);
            label5.Name = "label5";
            label5.Size = new Size(20, 31);
            label5.TabIndex = 4;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(358, 34);
            label6.Name = "label6";
            label6.Size = new Size(135, 31);
            label6.TabIndex = 3;
            label6.Text = "إجمالي الارباح";
            // 
            // Customers
            // 
            Customers.AutoSize = true;
            Customers.BackColor = Color.White;
            Customers.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Customers.Location = new Point(1115, 34);
            Customers.Name = "Customers";
            Customers.Size = new Size(26, 31);
            Customers.TabIndex = 2;
            Customers.Text = "..";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1267, 34);
            label2.Name = "label2";
            label2.Size = new Size(20, 31);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // StartDate
            // 
            StartDate.Checked = true;
            StartDate.CustomizableEdges = customizableEdges5;
            StartDate.FillColor = SystemColors.Highlight;
            StartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StartDate.Format = DateTimePickerFormat.Short;
            StartDate.Location = new Point(403, 39);
            StartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            StartDate.Name = "StartDate";
            StartDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            StartDate.Size = new Size(293, 45);
            StartDate.TabIndex = 8;
            StartDate.Value = new DateTime(2023, 11, 8, 12, 34, 20, 336);
            StartDate.ValueChanged += StartDate_ValueChanged;
            // 
            // EndDate
            // 
            EndDate.Checked = true;
            EndDate.CustomizableEdges = customizableEdges7;
            EndDate.FillColor = SystemColors.Highlight;
            EndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EndDate.Format = DateTimePickerFormat.Short;
            EndDate.Location = new Point(16, 37);
            EndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EndDate.Name = "EndDate";
            EndDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            EndDate.Size = new Size(288, 45);
            EndDate.TabIndex = 9;
            EndDate.Value = new DateTime(2023, 11, 8, 12, 34, 20, 336);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(718, 48);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 10;
            label3.Text = "من";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(321, 48);
            label4.Name = "label4";
            label4.Size = new Size(37, 28);
            label4.TabIndex = 11;
            label4.Text = "الي";
            // 
            // Information_Tap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(Profts_table);
            Controls.Add(guna2TextBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Information_Tap";
            Size = new Size(1499, 809);
            Load += Information_Tap_Load;
            ((System.ComponentModel.ISupportInitialize)Profts_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView Profts_table;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Profit;
        private DataGridViewTextBoxColumn Id;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label Profits;
        private Label label5;
        private Label label6;
        private Label Customers;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDate;
        private Label label3;
        private Label label4;
    }
}
