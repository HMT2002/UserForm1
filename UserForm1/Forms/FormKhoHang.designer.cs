namespace UserForm1.Forms
{
    partial class FormKhoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.comboColumn = new System.Windows.Forms.ComboBox();
            this.comboSP = new System.Windows.Forms.ComboBox();
            this.newinfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MASP = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SL = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.Button();
            this.Goodname = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Country = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filterinfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.SPTable = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ErrorTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(551, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHO HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.comboColumn);
            this.groupBox1.Controls.Add(this.comboSP);
            this.groupBox1.Controls.Add(this.newinfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MASP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(260, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa thông tin";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Update.ForeColor = System.Drawing.Color.SteelBlue;
            this.Update.Location = new System.Drawing.Point(182, 171);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(74, 33);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            this.Update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            this.Update.MouseLeave += new System.EventHandler(this.Update_Leave);
            this.Update.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_Move);
            this.Update.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Update_MouseUp);
            // 
            // comboColumn
            // 
            this.comboColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColumn.FormattingEnabled = true;
            this.comboColumn.Items.AddRange(new object[] {
            "Tên sản phẩm",
            "Giá",
            "Nước sản xuất",
            "Số lượng"});
            this.comboColumn.Location = new System.Drawing.Point(108, 83);
            this.comboColumn.Margin = new System.Windows.Forms.Padding(2);
            this.comboColumn.Name = "comboColumn";
            this.comboColumn.Size = new System.Drawing.Size(138, 24);
            this.comboColumn.TabIndex = 10;
            this.comboColumn.SelectedIndexChanged += new System.EventHandler(this.comboColumn_SelectedIndexChanged);
            this.comboColumn.TextChanged += new System.EventHandler(this.comboColumn_TextChanged);
            // 
            // comboSP
            // 
            this.comboSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSP.FormattingEnabled = true;
            this.comboSP.Location = new System.Drawing.Point(108, 31);
            this.comboSP.Margin = new System.Windows.Forms.Padding(2);
            this.comboSP.Name = "comboSP";
            this.comboSP.Size = new System.Drawing.Size(138, 24);
            this.comboSP.TabIndex = 9;
            this.comboSP.Click += new System.EventHandler(this.comboSP_Click);
            // 
            // newinfo
            // 
            this.newinfo.BackColor = System.Drawing.Color.White;
            this.newinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.newinfo.Location = new System.Drawing.Point(108, 134);
            this.newinfo.Margin = new System.Windows.Forms.Padding(2);
            this.newinfo.Name = "newinfo";
            this.newinfo.Size = new System.Drawing.Size(138, 26);
            this.newinfo.TabIndex = 8;
            this.newinfo.Text = "VD: Nguyễn A";
            this.newinfo.Click += new System.EventHandler(this.newinfo_Click);
            this.newinfo.Enter += new System.EventHandler(this.newinfo_Enter);
            this.newinfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.newinfo.Leave += new System.EventHandler(this.newinfo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dữ liệu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin";
            // 
            // MASP
            // 
            this.MASP.AutoSize = true;
            this.MASP.Location = new System.Drawing.Point(16, 33);
            this.MASP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MASP.Name = "MASP";
            this.MASP.Size = new System.Drawing.Size(49, 17);
            this.MASP.TabIndex = 3;
            this.MASP.Text = "Mã SP";
            // 
            // Fullname
            // 
            this.Fullname.BackColor = System.Drawing.Color.White;
            this.Fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Fullname.Location = new System.Drawing.Point(11, 24);
            this.Fullname.Margin = new System.Windows.Forms.Padding(2);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(121, 26);
            this.Fullname.TabIndex = 6;
            this.Fullname.Text = "Tên sản phẩm";
            this.Fullname.Click += new System.EventHandler(this.Fullname_Click);
            this.Fullname.Enter += new System.EventHandler(this.Fullname_Enter);
            this.Fullname.Leave += new System.EventHandler(this.Fullname_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.SL);
            this.groupBox2.Controls.Add(this.List);
            this.groupBox2.Controls.Add(this.Goodname);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.Country);
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.Fullname);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(274, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(272, 205);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(136, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(131, 161);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserForm1.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(4, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SL
            // 
            this.SL.BackColor = System.Drawing.Color.White;
            this.SL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SL.Location = new System.Drawing.Point(94, 98);
            this.SL.Margin = new System.Windows.Forms.Padding(2);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(39, 26);
            this.SL.TabIndex = 36;
            this.SL.Text = "SL";
            this.SL.Click += new System.EventHandler(this.SL_Click);
            this.SL.Enter += new System.EventHandler(this.SL_Enter);
            this.SL.Leave += new System.EventHandler(this.SL_Leave);
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.White;
            this.List.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.List.ForeColor = System.Drawing.Color.SteelBlue;
            this.List.Location = new System.Drawing.Point(116, 171);
            this.List.Margin = new System.Windows.Forms.Padding(2);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(74, 33);
            this.List.TabIndex = 32;
            this.List.Text = "Tải mới";
            this.List.UseVisualStyleBackColor = false;
            this.List.Click += new System.EventHandler(this.List_Click);
            this.List.Enter += new System.EventHandler(this.Username_Enter);
            this.List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_MouseDown);
            this.List.MouseLeave += new System.EventHandler(this.List_Leave);
            this.List.MouseMove += new System.Windows.Forms.MouseEventHandler(this.List_Move);
            this.List.MouseUp += new System.Windows.Forms.MouseEventHandler(this.List_MouseUp);
            // 
            // Goodname
            // 
            this.Goodname.BackColor = System.Drawing.Color.White;
            this.Goodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Goodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Goodname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Goodname.Location = new System.Drawing.Point(12, 61);
            this.Goodname.Margin = new System.Windows.Forms.Padding(2);
            this.Goodname.Name = "Goodname";
            this.Goodname.Size = new System.Drawing.Size(121, 26);
            this.Goodname.TabIndex = 30;
            this.Goodname.Text = "Mã sản phẩm";
            this.Goodname.Click += new System.EventHandler(this.Goodname_Click);
            this.Goodname.Enter += new System.EventHandler(this.Goodname_Enter);
            this.Goodname.Leave += new System.EventHandler(this.Goodname_Leave);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Add.ForeColor = System.Drawing.Color.SteelBlue;
            this.Add.Location = new System.Drawing.Point(194, 171);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(74, 33);
            this.Add.TabIndex = 29;
            this.Add.Text = "OK";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_MouseDown);
            this.Add.MouseLeave += new System.EventHandler(this.Add_Leave);
            this.Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Add_Move);
            this.Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Add_MouseUp);
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.White;
            this.Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Country.Location = new System.Drawing.Point(11, 134);
            this.Country.Margin = new System.Windows.Forms.Padding(2);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(121, 26);
            this.Country.TabIndex = 11;
            this.Country.Text = "Nước sản xuất";
            this.Country.Click += new System.EventHandler(this.Country_Click);
            this.Country.Enter += new System.EventHandler(this.Country_Enter);
            this.Country.Leave += new System.EventHandler(this.Country_Leave);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.White;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Price.Location = new System.Drawing.Point(11, 98);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(78, 26);
            this.Price.TabIndex = 10;
            this.Price.Text = "Giá";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            this.Price.Enter += new System.EventHandler(this.Price_Enter);
            this.Price.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterinfo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboFilter);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(550, 79);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(223, 144);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // filterinfo
            // 
            this.filterinfo.BackColor = System.Drawing.Color.White;
            this.filterinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.filterinfo.Location = new System.Drawing.Point(96, 76);
            this.filterinfo.Margin = new System.Windows.Forms.Padding(2);
            this.filterinfo.Name = "filterinfo";
            this.filterinfo.Size = new System.Drawing.Size(113, 26);
            this.filterinfo.TabIndex = 15;
            this.filterinfo.Click += new System.EventHandler(this.filterinfo_Click);
            this.filterinfo.TextChanged += new System.EventHandler(this.filterinfo_TextChanged);
            this.filterinfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dữ liệu lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thông tin";
            // 
            // comboFilter
            // 
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Items.AddRange(new object[] {
            "Mã SP",
            "Tên sản phẩm",
            "Giá",
            "Nước sản xuất",
            "Số lượng"});
            this.comboFilter.Location = new System.Drawing.Point(96, 34);
            this.comboFilter.Margin = new System.Windows.Forms.Padding(2);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(113, 24);
            this.comboFilter.TabIndex = 10;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged_1);
            this.comboFilter.TextChanged += new System.EventHandler(this.comboFilter_TextChanged);
            // 
            // SPTable
            // 
            this.SPTable.AllowUserToAddRows = false;
            this.SPTable.AllowUserToDeleteRows = false;
            this.SPTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SPTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SPTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SPTable.BackgroundColor = System.Drawing.Color.White;
            this.SPTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SPTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SPTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SPTable.ColumnHeadersHeight = 30;
            this.SPTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SPTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.c,
            this.gg,
            this.Column1,
            this.Column2,
            this.h});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.SPTable.EnableHeadersVisualStyles = false;
            this.SPTable.GridColor = System.Drawing.SystemColors.Control;
            this.SPTable.Location = new System.Drawing.Point(9, 228);
            this.SPTable.Margin = new System.Windows.Forms.Padding(2);
            this.SPTable.MultiSelect = false;
            this.SPTable.Name = "SPTable";
            this.SPTable.ReadOnly = true;
            this.SPTable.RowHeadersVisible = false;
            this.SPTable.RowHeadersWidth = 50;
            this.SPTable.RowTemplate.Height = 50;
            this.SPTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SPTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPTable.Size = new System.Drawing.Size(764, 333);
            this.SPTable.TabIndex = 29;
            this.SPTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SPTable_CellClick);
            this.SPTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SPTable_RowEnter);
            // 
            // a
            // 
            this.a.DataPropertyName = "MASP";
            this.a.FillWeight = 75F;
            this.a.HeaderText = "Mã SP";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // c
            // 
            this.c.DataPropertyName = "TENSP";
            this.c.FillWeight = 120F;
            this.c.HeaderText = "Tên SP";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // gg
            // 
            this.gg.DataPropertyName = "GIA";
            this.gg.HeaderText = "Giá";
            this.gg.MinimumWidth = 6;
            this.gg.Name = "gg";
            this.gg.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NUOCSX";
            this.Column1.HeaderText = "Nước SX";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SOLUONG";
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // h
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.h.DefaultCellStyle = dataGridViewCellStyle3;
            this.h.FillWeight = 75F;
            this.h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h.HeaderText = "";
            this.h.MinimumWidth = 6;
            this.h.Name = "h";
            this.h.ReadOnly = true;
            this.h.Text = "Xóa";
            this.h.UseColumnTextForButtonValue = true;
            // 
            // ErrorTable
            // 
            this.ErrorTable.AllowUserToAddRows = false;
            this.ErrorTable.AllowUserToDeleteRows = false;
            this.ErrorTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ErrorTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ErrorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ErrorTable.BackgroundColor = System.Drawing.Color.White;
            this.ErrorTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ErrorTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ErrorTable.ColumnHeadersHeight = 30;
            this.ErrorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ErrorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ErrorTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.ErrorTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorTable.Enabled = false;
            this.ErrorTable.EnableHeadersVisualStyles = false;
            this.ErrorTable.GridColor = System.Drawing.SystemColors.Control;
            this.ErrorTable.Location = new System.Drawing.Point(0, 445);
            this.ErrorTable.Margin = new System.Windows.Forms.Padding(2);
            this.ErrorTable.MultiSelect = false;
            this.ErrorTable.Name = "ErrorTable";
            this.ErrorTable.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ErrorTable.RowHeadersVisible = false;
            this.ErrorTable.RowHeadersWidth = 50;
            this.ErrorTable.RowTemplate.Height = 30;
            this.ErrorTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorTable.Size = new System.Drawing.Size(782, 126);
            this.ErrorTable.TabIndex = 34;
            this.ErrorTable.Visible = false;
            this.ErrorTable.Click += new System.EventHandler(this.ErrorTable_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Bảng lỗi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 571);
            this.Controls.Add(this.ErrorTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SPTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhoHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MASP;
        private System.Windows.Forms.TextBox newinfo;
        private System.Windows.Forms.TextBox Fullname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboColumn;
        private System.Windows.Forms.ComboBox comboSP;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox filterinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Goodname;
        private System.Windows.Forms.DataGridView SPTable;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SL;
        private System.Windows.Forms.DataGridView ErrorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn gg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn h;
    }
}