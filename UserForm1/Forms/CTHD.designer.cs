namespace UserForm1.Forms
{
    partial class CTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTHD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNgayHD = new System.Windows.Forms.Label();
            this.labelKHang = new System.Windows.Forms.Label();
            this.labelNVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_TongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_CTHD = new System.Windows.Forms.DataGridView();
            this.label_SoHD = new System.Windows.Forms.Label();
            this.San_Pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_SoHD);
            this.panel1.Controls.Add(this.labelKHang);
            this.panel1.Controls.Add(this.labelNVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 90);
            this.panel1.TabIndex = 1;
            // 
            // labelNgayHD
            // 
            this.labelNgayHD.AutoSize = true;
            this.labelNgayHD.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayHD.Location = new System.Drawing.Point(3, 48);
            this.labelNgayHD.Name = "labelNgayHD";
            this.labelNgayHD.Size = new System.Drawing.Size(94, 22);
            this.labelNgayHD.TabIndex = 4;
            this.labelNgayHD.Text = "Date/Time";
            this.labelNgayHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKHang
            // 
            this.labelKHang.AutoSize = true;
            this.labelKHang.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKHang.Location = new System.Drawing.Point(116, 48);
            this.labelKHang.Name = "labelKHang";
            this.labelKHang.Size = new System.Drawing.Size(59, 22);
            this.labelKHang.TabIndex = 3;
            this.labelKHang.Text = "label4";
            this.labelKHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNVien
            // 
            this.labelNVien.AutoSize = true;
            this.labelNVien.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNVien.Location = new System.Drawing.Point(116, 9);
            this.labelNVien.Name = "labelNVien";
            this.labelNVien.Size = new System.Drawing.Size(57, 22);
            this.labelNVien.TabIndex = 2;
            this.labelNVien.Text = "label3";
            this.labelNVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label_TongTien);
            this.panel2.Controls.Add(this.labelNgayHD);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 90);
            this.panel2.TabIndex = 2;
            // 
            // label_TongTien
            // 
            this.label_TongTien.AutoSize = true;
            this.label_TongTien.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongTien.Location = new System.Drawing.Point(116, 9);
            this.label_TongTien.Name = "label_TongTien";
            this.label_TongTien.Size = new System.Drawing.Size(57, 22);
            this.label_TongTien.TabIndex = 7;
            this.label_TongTien.Text = "label7";
            this.label_TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tổng tiền:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_CTHD
            // 
            this.dataGridView_CTHD.AllowUserToAddRows = false;
            this.dataGridView_CTHD.AllowUserToDeleteRows = false;
            this.dataGridView_CTHD.AllowUserToResizeColumns = false;
            this.dataGridView_CTHD.AllowUserToResizeRows = false;
            this.dataGridView_CTHD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.San_Pham,
            this.SL,
            this.Don_gia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_CTHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_CTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_CTHD.Location = new System.Drawing.Point(0, 90);
            this.dataGridView_CTHD.Name = "dataGridView_CTHD";
            this.dataGridView_CTHD.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_CTHD.RowHeadersVisible = false;
            this.dataGridView_CTHD.RowHeadersWidth = 62;
            this.dataGridView_CTHD.RowTemplate.Height = 28;
            this.dataGridView_CTHD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_CTHD.Size = new System.Drawing.Size(400, 484);
            this.dataGridView_CTHD.TabIndex = 3;
            // 
            // label_SoHD
            // 
            this.label_SoHD.AutoSize = true;
            this.label_SoHD.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoHD.Location = new System.Drawing.Point(280, 48);
            this.label_SoHD.Name = "label_SoHD";
            this.label_SoHD.Size = new System.Drawing.Size(56, 22);
            this.label_SoHD.TabIndex = 5;
            this.label_SoHD.Text = "SoHD";
            this.label_SoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // San_Pham
            // 
            this.San_Pham.DataPropertyName = "TENSP";
            this.San_Pham.HeaderText = "Sản phẩm";
            this.San_Pham.MinimumWidth = 8;
            this.San_Pham.Name = "San_Pham";
            this.San_Pham.ReadOnly = true;
            this.San_Pham.Width = 200;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 50;
            // 
            // Don_gia
            // 
            this.Don_gia.DataPropertyName = "TRIGIA";
            this.Don_gia.HeaderText = "Giá";
            this.Don_gia.MinimumWidth = 8;
            this.Don_gia.Name = "Don_gia";
            this.Don_gia.ReadOnly = true;
            this.Don_gia.Width = 150;
            // 
            // CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 664);
            this.Controls.Add(this.dataGridView_CTHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HKT-C SHARK";
            this.Load += new System.EventHandler(this.CTHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNgayHD;
        private System.Windows.Forms.Label labelKHang;
        private System.Windows.Forms.Label labelNVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_TongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_CTHD;
        private System.Windows.Forms.Label label_SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn San_Pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_gia;
    }
}