
using System;

namespace UserForm1.Forms
{
    partial class FormBanHang
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
        /// 

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTienNhan = new System.Windows.Forms.Label();
            this.txtBSHD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbMAKH = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbSHD = new System.Windows.Forms.Label();
            this.lbMAKH = new System.Windows.Forms.Label();
            this.lbNGHD = new System.Windows.Forms.Label();
            this.datetimeNHD = new System.Windows.Forms.DateTimePicker();
            this.lbGIA = new System.Windows.Forms.Label();
            this.lbTENSP = new System.Windows.Forms.Label();
            this.lbMASP = new System.Windows.Forms.Label();
            this.txtBSL = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBTenSP = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SPTable = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.labelTriGia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTienTraLai = new System.Windows.Forms.TextBox();
            this.textBoxTriGia = new System.Windows.Forms.TextBox();
            this.textBoxTienNhan = new System.Windows.Forms.TextBox();
            this.lbMANV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTienNhan
            // 
            this.labelTienNhan.AutoSize = true;
            this.labelTienNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienNhan.ForeColor = System.Drawing.Color.Black;
            this.labelTienNhan.Location = new System.Drawing.Point(658, 611);
            this.labelTienNhan.Name = "labelTienNhan";
            this.labelTienNhan.Size = new System.Drawing.Size(104, 24);
            this.labelTienNhan.TabIndex = 4;
            this.labelTienNhan.Text = "Tiền Nhận:";
            // 
            // txtBSHD
            // 
            this.txtBSHD.BackColor = System.Drawing.Color.White;
            this.txtBSHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSHD.Location = new System.Drawing.Point(3, 6);
            this.txtBSHD.Name = "txtBSHD";
            this.txtBSHD.ReadOnly = true;
            this.txtBSHD.Size = new System.Drawing.Size(179, 16);
            this.txtBSHD.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBSHD);
            this.panel1.Location = new System.Drawing.Point(194, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 34);
            this.panel1.TabIndex = 0;
            // 
            // txtbMAKH
            // 
            this.txtbMAKH.BackColor = System.Drawing.Color.White;
            this.txtbMAKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbMAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMAKH.Location = new System.Drawing.Point(3, 7);
            this.txtbMAKH.Name = "txtbMAKH";
            this.txtbMAKH.Size = new System.Drawing.Size(179, 16);
            this.txtbMAKH.TabIndex = 1;
            this.txtbMAKH.Enter += new System.EventHandler(this.txtbMAKH_Enter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtbMAKH);
            this.panel4.Location = new System.Drawing.Point(194, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 34);
            this.panel4.TabIndex = 20;
            // 
            // lbSHD
            // 
            this.lbSHD.AutoSize = true;
            this.lbSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSHD.ForeColor = System.Drawing.Color.Black;
            this.lbSHD.Location = new System.Drawing.Point(14, 48);
            this.lbSHD.Name = "lbSHD";
            this.lbSHD.Size = new System.Drawing.Size(97, 20);
            this.lbSHD.TabIndex = 23;
            this.lbSHD.Text = "Số Hóa Đơn";
            // 
            // lbMAKH
            // 
            this.lbMAKH.AutoSize = true;
            this.lbMAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMAKH.ForeColor = System.Drawing.Color.Black;
            this.lbMAKH.Location = new System.Drawing.Point(14, 104);
            this.lbMAKH.Name = "lbMAKH";
            this.lbMAKH.Size = new System.Drawing.Size(123, 20);
            this.lbMAKH.TabIndex = 24;
            this.lbMAKH.Text = "Mã Khách Hàng";
            // 
            // lbNGHD
            // 
            this.lbNGHD.AutoSize = true;
            this.lbNGHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNGHD.ForeColor = System.Drawing.Color.Black;
            this.lbNGHD.Location = new System.Drawing.Point(14, 162);
            this.lbNGHD.Name = "lbNGHD";
            this.lbNGHD.Size = new System.Drawing.Size(123, 20);
            this.lbNGHD.TabIndex = 26;
            this.lbNGHD.Text = "Ngày Mua Hàng";
            // 
            // datetimeNHD
            // 
            this.datetimeNHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeNHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNHD.Location = new System.Drawing.Point(194, 165);
            this.datetimeNHD.Name = "datetimeNHD";
            this.datetimeNHD.Size = new System.Drawing.Size(185, 26);
            this.datetimeNHD.TabIndex = 6;
            this.datetimeNHD.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            // 
            // lbGIA
            // 
            this.lbGIA.AutoSize = true;
            this.lbGIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGIA.ForeColor = System.Drawing.Color.Black;
            this.lbGIA.Location = new System.Drawing.Point(393, 162);
            this.lbGIA.Name = "lbGIA";
            this.lbGIA.Size = new System.Drawing.Size(78, 20);
            this.lbGIA.TabIndex = 35;
            this.lbGIA.Text = "Số Lượng";
            // 
            // lbTENSP
            // 
            this.lbTENSP.AutoSize = true;
            this.lbTENSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTENSP.ForeColor = System.Drawing.Color.Black;
            this.lbTENSP.Location = new System.Drawing.Point(393, 103);
            this.lbTENSP.Name = "lbTENSP";
            this.lbTENSP.Size = new System.Drawing.Size(114, 20);
            this.lbTENSP.TabIndex = 34;
            this.lbTENSP.Text = "Tên Sản Phẩm";
            // 
            // lbMASP
            // 
            this.lbMASP.AutoSize = true;
            this.lbMASP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMASP.ForeColor = System.Drawing.Color.Black;
            this.lbMASP.Location = new System.Drawing.Point(393, 47);
            this.lbMASP.Name = "lbMASP";
            this.lbMASP.Size = new System.Drawing.Size(109, 20);
            this.lbMASP.TabIndex = 33;
            this.lbMASP.Text = "Mã Sản Phẩm";
            // 
            // txtBSL
            // 
            this.txtBSL.BackColor = System.Drawing.Color.White;
            this.txtBSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSL.Location = new System.Drawing.Point(3, 6);
            this.txtBSL.Name = "txtBSL";
            this.txtBSL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBSL.Size = new System.Drawing.Size(217, 16);
            this.txtBSL.TabIndex = 5;
            this.txtBSL.Text = "1";
            this.txtBSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBSL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtBSL.Enter += new System.EventHandler(this.txtBSL_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtBSL);
            this.panel3.Location = new System.Drawing.Point(551, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 34);
            this.panel3.TabIndex = 32;
            // 
            // txtBTenSP
            // 
            this.txtBTenSP.BackColor = System.Drawing.Color.White;
            this.txtBTenSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTenSP.Location = new System.Drawing.Point(3, 7);
            this.txtBTenSP.Name = "txtBTenSP";
            this.txtBTenSP.ReadOnly = true;
            this.txtBTenSP.Size = new System.Drawing.Size(221, 16);
            this.txtBTenSP.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtBTenSP);
            this.panel5.Location = new System.Drawing.Point(551, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 34);
            this.panel5.TabIndex = 30;
            // 
            // SPTable
            // 
            this.SPTable.AllowUserToAddRows = false;
            this.SPTable.AllowUserToResizeColumns = false;
            this.SPTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SPTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SPTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SPTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SPTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SPTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SPTable.ColumnHeadersHeight = 50;
            this.SPTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SPTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.SoLuong,
            this.ThanhTien,
            this.xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.SPTable.EnableHeadersVisualStyles = false;
            this.SPTable.GridColor = System.Drawing.SystemColors.Control;
            this.SPTable.Location = new System.Drawing.Point(12, 238);
            this.SPTable.Name = "SPTable";
            this.SPTable.ReadOnly = true;
            this.SPTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SPTable.RowHeadersVisible = false;
            this.SPTable.RowHeadersWidth = 50;
            this.SPTable.RowTemplate.Height = 50;
            this.SPTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPTable.Size = new System.Drawing.Size(1012, 319);
            this.SPTable.TabIndex = 37;
            this.SPTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SPTable_CellContentClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 43.54253F;
            this.STT.HeaderText = "#";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 80F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.FillWeight = 50F;
            this.xoa.HeaderText = "Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Location = new System.Drawing.Point(800, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 51);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseDown);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseMove);
            this.btnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseUp);
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Items.AddRange(new object[] {
            "GD001",
            "GD002",
            "GD003",
            "GD004",
            "GD005",
            "GD006",
            "GD007",
            "GD008",
            "GD009",
            "GD010",
            "MP001",
            "MP002",
            "MP003",
            "MP004",
            "MP005",
            "MP006",
            "MP007",
            "MP008",
            "TP001",
            "TP002",
            "TP003",
            "TP004",
            "TP005",
            "TP006",
            "TP007",
            "TP008",
            "TP009",
            "TP010"});
            this.cbbMaSP.Location = new System.Drawing.Point(551, 48);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(225, 25);
            this.cbbMaSP.TabIndex = 3;
            this.cbbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbbMaSP_SelectedIndexChanged);
            this.cbbMaSP.Enter += new System.EventHandler(this.cbbMaSP_Enter);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.White;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTinhTien.Location = new System.Drawing.Point(800, 123);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(224, 51);
            this.btnTinhTien.TabIndex = 8;
            this.btnTinhTien.Text = "TÍNH TIỀN";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnSave_Click);
            this.btnTinhTien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTinhTien_MouseDown);
            this.btnTinhTien.MouseLeave += new System.EventHandler(this.btnTinhTien_MouseLeave);
            this.btnTinhTien.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTinhTien_MouseMove);
            this.btnTinhTien.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTinhTien_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.cbbMaSP);
            this.groupBox1.Controls.Add(this.lbSHD);
            this.groupBox1.Controls.Add(this.datetimeNHD);
            this.groupBox1.Controls.Add(this.lbMAKH);
            this.groupBox1.Controls.Add(this.lbNGHD);
            this.groupBox1.Controls.Add(this.lbGIA);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.lbTENSP);
            this.groupBox1.Controls.Add(this.lbMASP);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 220);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bán Hàng";
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.White;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcode.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBarcode.Location = new System.Drawing.Point(800, 181);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(224, 51);
            this.btnBarcode.TabIndex = 36;
            this.btnBarcode.Text = "SCAN BARCODE";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            this.btnBarcode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBarcode_MouseDown);
            this.btnBarcode.MouseLeave += new System.EventHandler(this.btnBarcode_MouseLeave);
            this.btnBarcode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBarcode_MouseMove);
            this.btnBarcode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBarcode_MouseUp);
            // 
            // labelTriGia
            // 
            this.labelTriGia.AutoSize = true;
            this.labelTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTriGia.ForeColor = System.Drawing.Color.Black;
            this.labelTriGia.Location = new System.Drawing.Point(706, 563);
            this.labelTriGia.Name = "labelTriGia";
            this.labelTriGia.Size = new System.Drawing.Size(70, 24);
            this.labelTriGia.TabIndex = 40;
            this.labelTriGia.Text = "Trị Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(646, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tiền Trả Lại:";
            // 
            // textBoxTienTraLai
            // 
            this.textBoxTienTraLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTienTraLai.Location = new System.Drawing.Point(800, 658);
            this.textBoxTienTraLai.Name = "textBoxTienTraLai";
            this.textBoxTienTraLai.ReadOnly = true;
            this.textBoxTienTraLai.Size = new System.Drawing.Size(193, 28);
            this.textBoxTienTraLai.TabIndex = 43;
            this.textBoxTienTraLai.Text = "0đ";
            this.textBoxTienTraLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTriGia
            // 
            this.textBoxTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTriGia.Location = new System.Drawing.Point(800, 563);
            this.textBoxTriGia.Name = "textBoxTriGia";
            this.textBoxTriGia.ReadOnly = true;
            this.textBoxTriGia.Size = new System.Drawing.Size(193, 28);
            this.textBoxTriGia.TabIndex = 44;
            this.textBoxTriGia.Text = "0đ";
            this.textBoxTriGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTienNhan
            // 
            this.textBoxTienNhan.BackColor = System.Drawing.Color.White;
            this.textBoxTienNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTienNhan.Location = new System.Drawing.Point(800, 608);
            this.textBoxTienNhan.Name = "textBoxTienNhan";
            this.textBoxTienNhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTienNhan.Size = new System.Drawing.Size(193, 28);
            this.textBoxTienNhan.TabIndex = 45;
            this.textBoxTienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTienNhan.TextChanged += new System.EventHandler(this.textBoxTienNhan_TextChanged);
            this.textBoxTienNhan.Enter += new System.EventHandler(this.textBoxTienNhan_Enter);
            this.textBoxTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTienNhan_KeyPress);
            this.textBoxTienNhan.Leave += new System.EventHandler(this.textBoxTienNhan_Leave);
            // 
            // lbMANV
            // 
            this.lbMANV.AutoSize = true;
            this.lbMANV.Location = new System.Drawing.Point(864, 28);
            this.lbMANV.Name = "lbMANV";
            this.lbMANV.Size = new System.Drawing.Size(39, 13);
            this.lbMANV.TabIndex = 46;
            this.lbMANV.Text = "ST001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã NV:";
            // 
            // ErrorTable
            // 
            this.ErrorTable.AllowUserToAddRows = false;
            this.ErrorTable.AllowUserToDeleteRows = false;
            this.ErrorTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ErrorTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ErrorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ErrorTable.BackgroundColor = System.Drawing.Color.White;
            this.ErrorTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ErrorTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ErrorTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ErrorTable.ColumnHeadersHeight = 30;
            this.ErrorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ErrorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ErrorTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.ErrorTable.EnableHeadersVisualStyles = false;
            this.ErrorTable.GridColor = System.Drawing.SystemColors.Control;
            this.ErrorTable.Location = new System.Drawing.Point(12, 563);
            this.ErrorTable.MultiSelect = false;
            this.ErrorTable.Name = "ErrorTable";
            this.ErrorTable.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ErrorTable.RowHeadersVisible = false;
            this.ErrorTable.RowHeadersWidth = 50;
            this.ErrorTable.RowTemplate.Height = 30;
            this.ErrorTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorTable.Size = new System.Drawing.Size(628, 131);
            this.ErrorTable.TabIndex = 36;
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
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 703);
            this.Controls.Add(this.ErrorTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMANV);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.textBoxTienNhan);
            this.Controls.Add(this.textBoxTriGia);
            this.Controls.Add(this.textBoxTienTraLai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTriGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.SPTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelTienNhan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormBanHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTienNhan;
        private System.Windows.Forms.TextBox txtBSHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbMAKH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbSHD;
        private System.Windows.Forms.Label lbMAKH;
        private System.Windows.Forms.Label lbNGHD;
        private System.Windows.Forms.DateTimePicker datetimeNHD;
        private System.Windows.Forms.Label lbGIA;
        private System.Windows.Forms.Label lbTENSP;
        private System.Windows.Forms.Label lbMASP;
        private System.Windows.Forms.TextBox txtBSL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBTenSP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView SPTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        public System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Label labelTriGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTienTraLai;
        private System.Windows.Forms.TextBox textBoxTriGia;
        private System.Windows.Forms.TextBox textBoxTienNhan;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Label lbMANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ErrorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

