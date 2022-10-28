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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(698, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 46);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa thông tin";
            // 
            // MAKH_SUA
            // 
            this.MAKH_SUA.BackColor = System.Drawing.Color.White;
            this.MAKH_SUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAKH_SUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAKH_SUA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MAKH_SUA.Location = new System.Drawing.Point(170, 40);
            this.MAKH_SUA.Name = "MAKH_SUA";
            this.MAKH_SUA.Size = new System.Drawing.Size(156, 30);
            this.MAKH_SUA.TabIndex = 29;
            this.MAKH_SUA.Text = "KH01";
            this.MAKH_SUA.Click += new System.EventHandler(this.textBox1_Click);
            this.MAKH_SUA.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Location = new System.Drawing.Point(186, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(155, 40);
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
            this.cbb_sua.FormattingEnabled = true;
            this.cbb_sua.Items.AddRange(new object[] {
            "Họ tên",
            "Số ĐT",
            "Địa chỉ",
            "Doanh số",
            "Ngày ĐK",
            "CMND"});
            this.cbb_sua.Location = new System.Drawing.Point(170, 90);
            this.cbb_sua.Name = "cbb_sua";
            this.cbb_sua.Size = new System.Drawing.Size(156, 28);
            this.cbb_sua.TabIndex = 10;
            // 
            // DuLieuMoi
            // 
            this.DuLieuMoi.BackColor = System.Drawing.Color.White;
            this.DuLieuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuLieuMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DuLieuMoi.Location = new System.Drawing.Point(170, 140);
            this.DuLieuMoi.Name = "DuLieuMoi";
            this.DuLieuMoi.Size = new System.Drawing.Size(156, 30);
            this.DuLieuMoi.TabIndex = 8;
            this.DuLieuMoi.Text = "VD: 0355175321";
            this.DuLieuMoi.Click += new System.EventHandler(this.textBox2_Click);
            this.DuLieuMoi.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dữ liệu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin cần sửa";
            // 
            // MAKH
            // 
            this.MAKH.AutoSize = true;
            this.MAKH.Location = new System.Drawing.Point(22, 40);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(122, 20);
            this.MAKH.TabIndex = 3;
            this.MAKH.Text = "Mã khách hàng";
            // 
            // HoTen
            // 
            this.HoTen.BackColor = System.Drawing.Color.White;
            this.HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.HoTen.Location = new System.Drawing.Point(15, 40);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(287, 30);
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.KHTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.KHTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KHTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.KHTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KHTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.KHTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KHTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = "0";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KHTable.DefaultCellStyle = dataGridViewCellStyle12;
            this.KHTable.EnableHeadersVisualStyles = false;
            this.KHTable.GridColor = System.Drawing.SystemColors.Control;
            this.KHTable.Location = new System.Drawing.Point(12, 315);
            this.KHTable.MultiSelect = false;
            this.KHTable.Name = "KHTable";
            this.KHTable.ReadOnly = true;
            this.KHTable.RowHeadersVisible = false;
            this.KHTable.RowHeadersWidth = 50;
            this.KHTable.RowTemplate.Height = 50;
            this.KHTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KHTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KHTable.Size = new System.Drawing.Size(1001, 329);
            this.KHTable.TabIndex = 29;
            this.KHTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KHTable_CellClick);
            this.KHTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.KHTable_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ID);
            this.groupBox2.Controls.Add(this.CMND);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.DiaChi);
            this.groupBox2.Controls.Add(this.SDT);
            this.groupBox2.Controls.Add(this.HoTen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(365, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 239);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ID.Location = new System.Drawing.Point(15, 76);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(107, 30);
            this.ID.TabIndex = 31;
            this.ID.Text = "Mã KH";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // CMND
            // 
            this.CMND.BackColor = System.Drawing.Color.White;
            this.CMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CMND.Location = new System.Drawing.Point(15, 148);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(287, 30);
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
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.Location = new System.Drawing.Point(159, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 40);
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
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DiaChi.Location = new System.Drawing.Point(15, 112);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(287, 30);
            this.DiaChi.TabIndex = 11;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Click += new System.EventHandler(this.DiaChi_Click);
            this.DiaChi.Leave += new System.EventHandler(this.DiaChi_Leave);
            // 
            // SDT
            // 
            this.SDT.BackColor = System.Drawing.Color.White;
            this.SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SDT.Location = new System.Drawing.Point(128, 76);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(174, 30);
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
            this.groupFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFilter.Location = new System.Drawing.Point(691, 70);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(322, 239);
            this.groupFilter.TabIndex = 31;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Lọc";
            // 
            // ThongTin
            // 
            this.ThongTin.BackColor = System.Drawing.Color.White;
            this.ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ThongTin.Location = new System.Drawing.Point(126, 90);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(190, 30);
            this.ThongTin.TabIndex = 15;
            this.ThongTin.Text = "VD: KH01";
            this.ThongTin.Click += new System.EventHandler(this.ThongTin_Click);
            this.ThongTin.TextChanged += new System.EventHandler(this.ThongTin_TextChanged);
            this.ThongTin.Leave += new System.EventHandler(this.ThongTin_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khách hàng";
            // 
            // comboBoxKH
            // 
            this.comboBoxKH.FormattingEnabled = true;
            this.comboBoxKH.Items.AddRange(new object[] {
            "Mã KH",
            "Họ tên",
            "Số điện thoại",
            "Địa chỉ",
            "CMND",
            "--All"});
            this.comboBoxKH.Location = new System.Drawing.Point(126, 40);
            this.comboBoxKH.Name = "comboBoxKH";
            this.comboBoxKH.Size = new System.Drawing.Size(190, 28);
            this.comboBoxKH.TabIndex = 10;
            // 
            // ErrorTable
            // 
            this.ErrorTable.AllowUserToAddRows = false;
            this.ErrorTable.AllowUserToDeleteRows = false;
            this.ErrorTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ErrorTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ErrorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ErrorTable.BackgroundColor = System.Drawing.Color.White;
            this.ErrorTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ErrorTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ErrorTable.ColumnHeadersHeight = 30;
            this.ErrorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ErrorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ErrorTable.DefaultCellStyle = dataGridViewCellStyle15;
            this.ErrorTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorTable.Enabled = false;
            this.ErrorTable.EnableHeadersVisualStyles = false;
            this.ErrorTable.GridColor = System.Drawing.SystemColors.Control;
            this.ErrorTable.Location = new System.Drawing.Point(0, 501);
            this.ErrorTable.MultiSelect = false;
            this.ErrorTable.Name = "ErrorTable";
            this.ErrorTable.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ErrorTable.RowHeadersVisible = false;
            this.ErrorTable.RowHeadersWidth = 50;
            this.ErrorTable.RowTemplate.Height = 30;
            this.ErrorTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorTable.Size = new System.Drawing.Size(1025, 155);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.h.DefaultCellStyle = dataGridViewCellStyle11;
            this.h.FillWeight = 75F;
            this.h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h.HeaderText = "";
            this.h.MinimumWidth = 6;
            this.h.Name = "h";
            this.h.ReadOnly = true;
            this.h.Text = "Xóa";
            this.h.UseColumnTextForButtonValue = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 656);
            this.Controls.Add(this.ErrorTable);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.KHTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}