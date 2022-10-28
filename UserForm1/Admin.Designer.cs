namespace UserForm1
{
    partial class FormMainAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.Childform = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonCaiDat = new System.Windows.Forms.Button();
            this.buttonKho = new System.Windows.Forms.Button();
            this.buttonLichLV = new System.Windows.Forms.Button();
            this.buttonHoaDon = new System.Windows.Forms.Button();
            this.buttonNV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.Childform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.buttonHome);
            this.PanelMenu.Controls.Add(this.buttonCaiDat);
            this.PanelMenu.Controls.Add(this.buttonKho);
            this.PanelMenu.Controls.Add(this.buttonLichLV);
            this.PanelMenu.Controls.Add(this.buttonHoaDon);
            this.PanelMenu.Controls.Add(this.buttonNV);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(237, 720);
            this.PanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 60);
            this.panel1.TabIndex = 7;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.Controls.Add(this.buttonMinimize);
            this.panelTitle.Controls.Add(this.buttonMaximize);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(237, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1043, 17);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(923, 3);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(36, 32);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.Text = "O";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.ForeColor = System.Drawing.Color.White;
            this.buttonMaximize.Location = new System.Drawing.Point(964, 3);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(36, 32);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.Text = "O";
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1003, 3);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 32);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "O";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelName.Location = new System.Drawing.Point(957, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(343, 61);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "HKT-C SHARK";
            // 
            // Childform
            // 
            this.Childform.Controls.Add(this.labelDate);
            this.Childform.Controls.Add(this.labelDay);
            this.Childform.Controls.Add(this.labelTime);
            this.Childform.Controls.Add(this.pictureBox2);
            this.Childform.Location = new System.Drawing.Point(237, 13);
            this.Childform.Name = "Childform";
            this.Childform.Size = new System.Drawing.Size(1043, 707);
            this.Childform.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelDate.Location = new System.Drawing.Point(551, 639);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 36);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "aaa";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelDay.Location = new System.Drawing.Point(392, 639);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(63, 36);
            this.labelDay.TabIndex = 8;
            this.labelDay.Text = "day";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTime.Location = new System.Drawing.Point(457, 556);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(179, 69);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "22:22";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1043, 707);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::UserForm1.Properties.Resources.logout;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(237, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "  Đăng xuất";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(-1, 76);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(238, 80);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "  Trang chủ";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonCaiDat
            // 
            this.buttonCaiDat.FlatAppearance.BorderSize = 0;
            this.buttonCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaiDat.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCaiDat.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("buttonCaiDat.Image")));
            this.buttonCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaiDat.Location = new System.Drawing.Point(-1, 496);
            this.buttonCaiDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCaiDat.Name = "buttonCaiDat";
            this.buttonCaiDat.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonCaiDat.Size = new System.Drawing.Size(248, 80);
            this.buttonCaiDat.TabIndex = 6;
            this.buttonCaiDat.Text = "  Thống kê";
            this.buttonCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCaiDat.UseVisualStyleBackColor = true;
            this.buttonCaiDat.Click += new System.EventHandler(this.buttonCaiDat_Click);
            // 
            // buttonKho
            // 
            this.buttonKho.FlatAppearance.BorderSize = 0;
            this.buttonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKho.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonKho.Image = global::UserForm1.Properties.Resources.warehouse1;
            this.buttonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKho.Location = new System.Drawing.Point(-1, 328);
            this.buttonKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKho.Name = "buttonKho";
            this.buttonKho.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonKho.Size = new System.Drawing.Size(238, 80);
            this.buttonKho.TabIndex = 5;
            this.buttonKho.Text = "  Kho";
            this.buttonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKho.UseVisualStyleBackColor = true;
            this.buttonKho.Click += new System.EventHandler(this.buttonKho_Click);
            // 
            // buttonLichLV
            // 
            this.buttonLichLV.FlatAppearance.BorderSize = 0;
            this.buttonLichLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLichLV.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLichLV.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLichLV.Image = global::UserForm1.Properties.Resources.customer1;
            this.buttonLichLV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLichLV.Location = new System.Drawing.Point(-1, 244);
            this.buttonLichLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLichLV.Name = "buttonLichLV";
            this.buttonLichLV.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonLichLV.Size = new System.Drawing.Size(248, 80);
            this.buttonLichLV.TabIndex = 4;
            this.buttonLichLV.Text = "  Khách hàng";
            this.buttonLichLV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLichLV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLichLV.UseVisualStyleBackColor = true;
            this.buttonLichLV.Click += new System.EventHandler(this.buttonLichLV_Click);
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.FlatAppearance.BorderSize = 0;
            this.buttonHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoaDon.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHoaDon.Image = global::UserForm1.Properties.Resources.clipboard;
            this.buttonHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoaDon.Location = new System.Drawing.Point(-1, 412);
            this.buttonHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonHoaDon.Size = new System.Drawing.Size(238, 80);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "  Hóa Đơn";
            this.buttonHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            this.buttonHoaDon.Click += new System.EventHandler(this.buttonHoaDon_Click);
            // 
            // buttonNV
            // 
            this.buttonNV.FlatAppearance.BorderSize = 0;
            this.buttonNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNV.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNV.Image = global::UserForm1.Properties.Resources.seller2;
            this.buttonNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNV.Location = new System.Drawing.Point(-1, 160);
            this.buttonNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNV.Name = "buttonNV";
            this.buttonNV.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonNV.Size = new System.Drawing.Size(237, 80);
            this.buttonNV.TabIndex = 2;
            this.buttonNV.Text = "  Nhân viên";
            this.buttonNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNV.UseVisualStyleBackColor = true;
            this.buttonNV.Click += new System.EventHandler(this.buttonNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::UserForm1.Properties.Resources._11e441bfd8c444959a231427470bc202;
            this.pictureBox1.Location = new System.Drawing.Point(748, -58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Childform);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.FormMainAdmin_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.Childform.ResumeLayout(false);
            this.Childform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button buttonCaiDat;
        private System.Windows.Forms.Button buttonKho;
        private System.Windows.Forms.Button buttonLichLV;
        private System.Windows.Forms.Button buttonHoaDon;
        private System.Windows.Forms.Button buttonNV;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Childform;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelDate;
    }
}

