namespace UserForm1.Forms
{
    partial class FormHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMANV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMAKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGIAHD2 = new System.Windows.Forms.TextBox();
            this.textBoxGIAHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonLam_moi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.datagridviewHD = new System.Windows.Forms.DataGridView();
            this.C0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.label_SLHD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày in";
            // 
            // comboBoxMANV
            // 
            this.comboBoxMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMANV.FormattingEnabled = true;
            this.comboBoxMANV.Location = new System.Drawing.Point(132, 79);
            this.comboBoxMANV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMANV.Name = "comboBoxMANV";
            this.comboBoxMANV.Size = new System.Drawing.Size(108, 28);
            this.comboBoxMANV.TabIndex = 7;
            this.comboBoxMANV.SelectedIndexChanged += new System.EventHandler(this.comboBoxMANV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã KH";
            // 
            // textBoxMAKH
            // 
            this.textBoxMAKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMAKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxMAKH.Location = new System.Drawing.Point(132, 28);
            this.textBoxMAKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMAKH.MaxLength = 5;
            this.textBoxMAKH.Multiline = true;
            this.textBoxMAKH.Name = "textBoxMAKH";
            this.textBoxMAKH.Size = new System.Drawing.Size(164, 27);
            this.textBoxMAKH.TabIndex = 10;
            this.textBoxMAKH.Tag = "";
            this.textBoxMAKH.TextChanged += new System.EventHandler(this.textBoxMAKH_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxGIAHD2);
            this.groupBox1.Controls.Add(this.textBoxGIAHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.textBoxMAKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxMANV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(629, 181);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(452, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Từ";
            // 
            // textBoxGIAHD2
            // 
            this.textBoxGIAHD2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGIAHD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxGIAHD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxGIAHD2.Location = new System.Drawing.Point(404, 135);
            this.textBoxGIAHD2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGIAHD2.MaxLength = 12;
            this.textBoxGIAHD2.Multiline = true;
            this.textBoxGIAHD2.Name = "textBoxGIAHD2";
            this.textBoxGIAHD2.Size = new System.Drawing.Size(164, 28);
            this.textBoxGIAHD2.TabIndex = 16;
            this.textBoxGIAHD2.Tag = "";
            this.textBoxGIAHD2.Text = "MAX(vnd)";
            this.textBoxGIAHD2.Click += new System.EventHandler(this.textBoxGIAHD2_Click);
            this.textBoxGIAHD2.TextChanged += new System.EventHandler(this.textBoxGIAHD2_TextChanged);
            this.textBoxGIAHD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGIAHD2_KeyPress);
            this.textBoxGIAHD2.Leave += new System.EventHandler(this.textBoxGIAHD2_Leave);
            // 
            // textBoxGIAHD
            // 
            this.textBoxGIAHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGIAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxGIAHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxGIAHD.Location = new System.Drawing.Point(404, 48);
            this.textBoxGIAHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGIAHD.MaxLength = 12;
            this.textBoxGIAHD.Multiline = true;
            this.textBoxGIAHD.Name = "textBoxGIAHD";
            this.textBoxGIAHD.Size = new System.Drawing.Size(164, 28);
            this.textBoxGIAHD.TabIndex = 14;
            this.textBoxGIAHD.Tag = "";
            this.textBoxGIAHD.Text = "MIN(vnd)";
            this.textBoxGIAHD.Click += new System.EventHandler(this.textBoxGIAHD_Click);
            this.textBoxGIAHD.TextChanged += new System.EventHandler(this.textBoxGIAHD_TextChanged);
            this.textBoxGIAHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGIAHD2_KeyPress);
            this.textBoxGIAHD.Leave += new System.EventHandler(this.textBoxGIAHD_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(318, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trị giá";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(132, 135);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(165, 26);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 21, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // buttonLam_moi
            // 
            this.buttonLam_moi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLam_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.buttonLam_moi.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonLam_moi.Location = new System.Drawing.Point(872, 155);
            this.buttonLam_moi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLam_moi.Name = "buttonLam_moi";
            this.buttonLam_moi.Size = new System.Drawing.Size(137, 44);
            this.buttonLam_moi.TabIndex = 13;
            this.buttonLam_moi.Text = "Làm mới";
            this.buttonLam_moi.UseVisualStyleBackColor = true;
            this.buttonLam_moi.Click += new System.EventHandler(this.buttonLam_moi_Click);
            this.buttonLam_moi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLam_moi_MouseDown);
            this.buttonLam_moi.MouseLeave += new System.EventHandler(this.buttonLam_moi_MouseLeave);
            this.buttonLam_moi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonLam_moi_MouseMove);
            this.buttonLam_moi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLam_moi_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(706, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 46);
            this.label6.TabIndex = 15;
            this.label6.Text = "HÓA ĐƠN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // datagridviewHD
            // 
            this.datagridviewHD.AllowUserToAddRows = false;
            this.datagridviewHD.AllowUserToDeleteRows = false;
            this.datagridviewHD.AllowUserToResizeColumns = false;
            this.datagridviewHD.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridviewHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewHD.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridviewHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewHD.ColumnHeadersHeight = 30;
            this.datagridviewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridviewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C0,
            this.a,
            this.c,
            this.b,
            this.d});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewHD.EnableHeadersVisualStyles = false;
            this.datagridviewHD.GridColor = System.Drawing.SystemColors.Control;
            this.datagridviewHD.Location = new System.Drawing.Point(12, 211);
            this.datagridviewHD.Name = "datagridviewHD";
            this.datagridviewHD.ReadOnly = true;
            this.datagridviewHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.datagridviewHD.RowHeadersVisible = false;
            this.datagridviewHD.RowHeadersWidth = 50;
            this.datagridviewHD.RowTemplate.Height = 50;
            this.datagridviewHD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridviewHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewHD.Size = new System.Drawing.Size(1020, 480);
            this.datagridviewHD.TabIndex = 14;
            this.datagridviewHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewHD_CellDoubleClick);
            // 
            // C0
            // 
            this.C0.DataPropertyName = "SOHD";
            this.C0.HeaderText = "SOHD";
            this.C0.MinimumWidth = 6;
            this.C0.Name = "C0";
            this.C0.ReadOnly = true;
            // 
            // a
            // 
            this.a.DataPropertyName = "MANV";
            this.a.HeaderText = "Mã NV";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // c
            // 
            this.c.DataPropertyName = "MAKH";
            this.c.HeaderText = "Mã KH";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // b
            // 
            this.b.DataPropertyName = "NGHD";
            this.b.HeaderText = "Ngày in";
            this.b.MinimumWidth = 6;
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // d
            // 
            this.d.DataPropertyName = "TRIGIA";
            this.d.HeaderText = "Trị giá";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.ReadOnly = true;
            // 
            // buttonDetail
            // 
            this.buttonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.buttonDetail.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonDetail.Location = new System.Drawing.Point(670, 155);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(137, 44);
            this.buttonDetail.TabIndex = 16;
            this.buttonDetail.Text = "Chi tiết";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            this.buttonDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDetail_MouseDown);
            this.buttonDetail.MouseLeave += new System.EventHandler(this.buttonDetail_MouseLeave);
            this.buttonDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDetail_MouseMove);
            this.buttonDetail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDetail_MouseUp);
            // 
            // label_SLHD
            // 
            this.label_SLHD.AutoSize = true;
            this.label_SLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_SLHD.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_SLHD.Location = new System.Drawing.Point(670, 111);
            this.label_SLHD.Name = "label_SLHD";
            this.label_SLHD.Size = new System.Drawing.Size(223, 25);
            this.label_SLHD.TabIndex = 17;
            this.label_SLHD.Text = "SL Hóa đơn: 1000000";
            // 
            // FormHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 711);
            this.Controls.Add(this.label_SLHD);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datagridviewHD);
            this.Controls.Add(this.buttonLam_moi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(927, 562);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMANV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMAKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonLam_moi;
        private System.Windows.Forms.TextBox textBoxGIAHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGIAHD2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn C0;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridView datagridviewHD;
        private System.Windows.Forms.Label label_SLHD;
    }
}