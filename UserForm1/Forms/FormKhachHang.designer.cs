namespace UserForm1.Forms
{
    partial class FormKhachHang
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
            this.MAKH_SUA = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.cbb_sua = new System.Windows.Forms.ComboBox();
            this.DuLieuMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.KHTable = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.CMND = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.DiaChi = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.ThongTin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKH = new System.Windows.Forms.ComboBox();
            this.ErrorTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KHTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(525, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MAKH_SUA);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.cbb_sua);
            this.groupBox1.Controls.Add(this.DuLieuMoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MAKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(260, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa thông tin";
            // 
            // MAKH_SUA
            // 
            this.MAKH_SUA.BackColor = System.Drawing.Color.White;
            this.MAKH_SUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAKH_SUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MAKH_SUA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MAKH_SUA.Location = new System.Drawing.Point(128, 32);
            this.MAKH_SUA.Margin = new System.Windows.Forms.Padding(2);
            this.MAKH_SUA.Name = "MAKH_SUA";
            this.MAKH_SUA.Size = new System.Drawing.Size(118, 26);
            this.MAKH_SUA.TabIndex = 29;
            this.MAKH_SUA.Text = "KHXX";
            this.MAKH_SUA.Click += new System.EventHandler(this.textBox1_Click);
            this.MAKH_SUA.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Location = new System.Drawing.Point(182, 154);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(74, 33);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "OK";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            this.buttonUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUpdate_MouseDown);
            this.buttonUpdate.MouseLeave += new System.EventHandler(this.buttonUpdate_MouseLeave);
            this.buttonUpdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonUpdate_MouseMove);
            this.buttonUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUpdate_MouseUp);
            // 
            // cbb_sua
            // 
            this.cbb_sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sua.FormattingEnabled = true;
            this.cbb_sua.Items.AddRange(new object[] {
            "Họ tên",
            "Số ĐT",
            "Địa chỉ",
            "CMND"});
            this.cbb_sua.Location = new System.Drawing.Point(128, 73);
            this.cbb_sua.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_sua.Name = "cbb_sua";
            this.cbb_sua.Size = new System.Drawing.Size(118, 24);
            this.cbb_sua.TabIndex = 10;
            this.cbb_sua.SelectedIndexChanged += new System.EventHandler(this.cbb_sua_SelectedIndexChanged);
            this.cbb_sua.TextChanged += new System.EventHandler(this.cbb_sua_TextChanged);
            // 
            // DuLieuMoi
            // 
            this.DuLieuMoi.BackColor = System.Drawing.Color.White;
            this.DuLieuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DuLieuMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DuLieuMoi.Location = new System.Drawing.Point(128, 114);
            this.DuLieuMoi.Margin = new System.Windows.Forms.Padding(2);
            this.DuLieuMoi.Name = "DuLieuMoi";
            this.DuLieuMoi.Size = new System.Drawing.Size(118, 26);
            this.DuLieuMoi.TabIndex = 8;
            this.DuLieuMoi.Text = "VD: 0355175321";
            this.DuLieuMoi.Click += new System.EventHandler(this.textBox2_Click);
            this.DuLieuMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DuLieuMoi_KeyPress);
            this.DuLieuMoi.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dữ liệu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin";
            // 
            // MAKH
            // 
            this.MAKH.AutoSize = true;
            this.MAKH.Location = new System.Drawing.Point(16, 32);
            this.MAKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(50, 17);
            this.MAKH.TabIndex = 3;
            this.MAKH.Text = "Mã KH";
            // 
            // HoTen
            // 
            this.HoTen.BackColor = System.Drawing.Color.White;
            this.HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.HoTen.Location = new System.Drawing.Point(11, 32);
            this.HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.HoTen.MaxLength = 40;
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(216, 26);
            this.HoTen.TabIndex = 6;
            this.HoTen.Text = "Họ, tên";
            this.HoTen.Click += new System.EventHandler(this.HoTen_Click);
            this.HoTen.Leave += new System.EventHandler(this.HoTen_Leave);
            // 
            // KHTable
            // 
            this.KHTable.AllowUserToAddRows = false;
            this.KHTable.AllowUserToDeleteRows = false;
            this.KHTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.KHTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KHTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KHTable.BackgroundColor = System.Drawing.Color.White;
            this.KHTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KHTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.KHTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KHTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KHTable.ColumnHeadersHeight = 30;
            this.KHTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KHTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c,
            this.Column1,
            this.Column2,
            this.e,
            this.f,
            this.h});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KHTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.KHTable.EnableHeadersVisualStyles = false;
            this.KHTable.GridColor = System.Drawing.SystemColors.Control;
            this.KHTable.Location = new System.Drawing.Point(9, 218);
            this.KHTable.Margin = new System.Windows.Forms.Padding(2);
            this.KHTable.MultiSelect = false;
            this.KHTable.Name = "KHTable";
            this.KHTable.ReadOnly = true;
            this.KHTable.RowHeadersVisible = false;
            this.KHTable.RowHeadersWidth = 50;
            this.KHTable.RowTemplate.Height = 50;
            this.KHTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KHTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KHTable.Size = new System.Drawing.Size(764, 306);
            this.KHTable.TabIndex = 29;
            this.KHTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KHTable_CellClick);
            this.KHTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.KHTable_RowEnter);
            // 
            // a
            // 
            this.a.DataPropertyName = "MAKH";
            this.a.HeaderText = "Mã KH";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // b
            // 
            this.b.DataPropertyName = "HOTEN";
            this.b.HeaderText = "Họ tên";
            this.b.MinimumWidth = 6;
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // c
            // 
            this.c.DataPropertyName = "DIACHI";
            this.c.HeaderText = "Địa chỉ";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SODT";
            this.Column1.HeaderText = "Số ĐT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CMND";
            this.Column2.HeaderText = "CMND";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // e
            // 
            this.e.DataPropertyName = "DOANHSO";
            this.e.HeaderText = "Doanh số";
            this.e.MinimumWidth = 6;
            this.e.Name = "e";
            this.e.ReadOnly = true;
            // 
            // f
            // 
            this.f.DataPropertyName = "NGDK";
            this.f.HeaderText = "Ngày ĐK";
            this.f.MinimumWidth = 6;
            this.f.Name = "f";
            this.f.ReadOnly = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Refresh);
            this.groupBox2.Controls.Add(this.ID);
            this.groupBox2.Controls.Add(this.CMND);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.DiaChi);
            this.groupBox2.Controls.Add(this.SDT);
            this.groupBox2.Controls.Add(this.HoTen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(274, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(240, 194);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.White;
            this.Refresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Refresh.ForeColor = System.Drawing.Color.SteelBlue;
            this.Refresh.Location = new System.Drawing.Point(78, 154);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(74, 33);
            this.Refresh.TabIndex = 32;
            this.Refresh.Text = "TẢI MỚI";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ID.Location = new System.Drawing.Point(11, 62);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.MaxLength = 5;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(81, 26);
            this.ID.TabIndex = 31;
            this.ID.Text = "Mã KH";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // CMND
            // 
            this.CMND.BackColor = System.Drawing.Color.White;
            this.CMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CMND.Location = new System.Drawing.Point(11, 120);
            this.CMND.Margin = new System.Windows.Forms.Padding(2);
            this.CMND.MaxLength = 12;
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(216, 26);
            this.CMND.TabIndex = 30;
            this.CMND.Text = "CMND";
            this.CMND.Click += new System.EventHandler(this.CMND_Click);
            this.CMND.Leave += new System.EventHandler(this.CMND_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.Location = new System.Drawing.Point(156, 154);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 33);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "THÊM";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseDown);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            this.buttonAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseMove);
            this.buttonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseUp);
            // 
            // DiaChi
            // 
            this.DiaChi.BackColor = System.Drawing.Color.White;
            this.DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DiaChi.Location = new System.Drawing.Point(11, 91);
            this.DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.DiaChi.MaxLength = 50;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(216, 26);
            this.DiaChi.TabIndex = 11;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Click += new System.EventHandler(this.DiaChi_Click);
            this.DiaChi.Leave += new System.EventHandler(this.DiaChi_Leave);
            // 
            // SDT
            // 
            this.SDT.BackColor = System.Drawing.Color.White;
            this.SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SDT.Location = new System.Drawing.Point(96, 62);
            this.SDT.Margin = new System.Windows.Forms.Padding(2);
            this.SDT.MaxLength = 10;
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(131, 26);
            this.SDT.TabIndex = 9;
            this.SDT.Text = "Số điện thoại";
            this.SDT.Click += new System.EventHandler(this.SDT_Click);
            this.SDT.Leave += new System.EventHandler(this.SDT_Leave);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.ThongTin);
            this.groupFilter.Controls.Add(this.label5);
            this.groupFilter.Controls.Add(this.label2);
            this.groupFilter.Controls.Add(this.comboBoxKH);
            this.groupFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupFilter.Location = new System.Drawing.Point(518, 80);
            this.groupFilter.Margin = new System.Windows.Forms.Padding(2);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Padding = new System.Windows.Forms.Padding(2);
            this.groupFilter.Size = new System.Drawing.Size(255, 132);
            this.groupFilter.TabIndex = 31;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Lọc";
            // 
            // ThongTin
            // 
            this.ThongTin.BackColor = System.Drawing.Color.White;
            this.ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ThongTin.Location = new System.Drawing.Point(94, 73);
            this.ThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(157, 26);
            this.ThongTin.TabIndex = 15;
            this.ThongTin.Click += new System.EventHandler(this.ThongTin_Click);
            this.ThongTin.TextChanged += new System.EventHandler(this.ThongTin_TextChanged);
            this.ThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThongTin_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khách hàng";
            // 
            // comboBoxKH
            // 
            this.comboBoxKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKH.FormattingEnabled = true;
            this.comboBoxKH.Items.AddRange(new object[] {
            "Mã KH",
            "Họ tên",
            "Số điện thoại",
            "Địa chỉ",
            "CMND",
            "--All"});
            this.comboBoxKH.Location = new System.Drawing.Point(94, 32);
            this.comboBoxKH.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKH.Name = "comboBoxKH";
            this.comboBoxKH.Size = new System.Drawing.Size(157, 24);
            this.comboBoxKH.TabIndex = 10;
            this.comboBoxKH.SelectedIndexChanged += new System.EventHandler(this.comboBoxKH_SelectedIndexChanged);
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
            this.ErrorTable.Location = new System.Drawing.Point(0, 407);
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
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.ErrorTable);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.KHTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Shown += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KHTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MAKH;
        private System.Windows.Forms.TextBox DuLieuMoi;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.DataGridView KHTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.ComboBox cbb_sua;
        private System.Windows.Forms.TextBox DiaChi;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.TextBox ThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKH;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox MAKH_SUA;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.DataGridView ErrorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewButtonColumn h;
        private System.Windows.Forms.Button Refresh;
    }
}