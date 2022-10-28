using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserForm1.Forms;

namespace UserForm1
{
    public partial class FormMainAdmin : Form
    {
        private Button currentButton;
        private Random random;

        private Form activeForm;

        public FormMainAdmin()
        {
            
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ActivateButton(this.buttonHome);
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(280, 5);

            pictureBox2.Controls.Add(labelName);
            labelName.Location = new Point(445, 25);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = 0;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
        
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(70, 130, 180);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Montserrat", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousButton in PanelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button)) 
                {
                    previousButton.BackColor = Color.FromArgb(40, 42, 48);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) 
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.Dock = DockStyle.Fill;
            this.Childform.Controls.Add(childForm);
            this.Childform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNV_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormNhanVien(), sender);

            FormNhanVien f = new FormNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonHoaDon_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormHoaDon(), sender);

            FormHoaDon f = new FormHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonLichLV_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormKhachHang(), sender);

            FormKhachHang f = new FormKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonKho_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormKhoHang(), sender);

            FormKhoHang f = new FormKhoHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonCaiDat_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormThongKe(), sender);

            FormThongKe f = new FormThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {          
            if (activeForm != null)
                activeForm.Close();
            Reset();
            ActivateButton(sender);
        }

        private void Reset()
        {
            DisableButton();
            panelTitle.BackColor = Color.FromArgb(70, 130, 180);
            currentButton = null;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd" + ",");
            //labelSecond.Text = DateTime.Now.ToString("tt");
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            //labelSecond.Location = new Point(labelTime.Location.X + labelTime.Width, labelSecond.Location.Y);
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
