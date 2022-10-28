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
    public partial class FormMainUser : Form
    {
        private Button currentButton;
        private Random random;
        private Form activeForm;
        string user = "";

        public FormMainUser(string temp)
        {
            InitializeComponent();
            user = temp;
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ActivateButton(this.buttonHome);
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(230, 5);

            pictureBox2.Controls.Add(labelName);
            labelName.Location = new Point(420, 35);

            pictureBox2.Controls.Add(labelTime);
            //labelTime.Location = new Point(415, 555);

            //pictureBox2.Controls.Add(labelSecond);
            //labelSecond.Location = new Point(labelTime.Location.X + labelTime.Width - 8, 589);

            pictureBox2.Controls.Add(labelDate);
            labelDate.Location = new Point(530, 640);

            pictureBox2.Controls.Add(labelDay);
            labelDay.Location = new Point(385, 640);

            //pictureBox2.Controls.Add(panelTransparent);
            //panelTransparent.Location = new Point(0, 0);
            //panelTransparent.BackColor = Color.FromArgb(100, 255, 255, 230);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private Color SelectThemeColor()
        //{
        //    int index = 0;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                //if(currentButton != (Button)btnSender)
                //{
                    DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.SteelBlue;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Montserrat", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //}
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
            //childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonBanHang_Click(object sender, EventArgs e)
        {
            //if (currentButton != (Button)sender)
            //{
            //    OpenChildForm(new Forms.FormBanHang(user), sender);
            //}
            FormBanHang f=new FormBanHang(user);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            //if (currentButton != (Button)sender)
            //{
            //    OpenChildForm(new Forms.FormKhachHang(), sender);
            //}
            FormKhachHang f = new FormKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonHoaDon_Click(object sender, EventArgs e)
        {
            //if (currentButton != (Button)sender)
            //{
            //    OpenChildForm(new Forms.FormHoaDon(), sender);
            //}
            FormHoaDon f = new FormHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonLichLV_Click(object sender, EventArgs e)
        {
            //if (currentButton != (Button)sender)
            //{
            //    OpenChildForm(new Forms.FormLichLV(), sender);
            //}
            FormLichLV f = new FormLichLV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonKho_Click(object sender, EventArgs e)
        {
            //if (currentButton != (Button)sender)
            //{
            //    OpenChildForm(new Forms.FormKhoHang(), sender);
            //}
            FormKhoHang f = new FormKhoHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonCaiDat_Click(object sender, EventArgs e)
        {
            //if (currentButton != (Button)sender)
            //{
            //    OpenChildForm(new Forms.FormThongKe(), sender);
            //}
            FormThongKe f = new FormThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (currentButton != (Button)sender)
            {
                if (activeForm != null)
                    activeForm.Close();
                Reset();
                ActivateButton(sender);
            }
        }

        private void Reset()
        {
            DisableButton();
            panelTitle.BackColor = Color.SteelBlue;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd" + ",");
            //labelSecond.Text = DateTime.Now.ToString("tt");
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            //labelSecond.Location = new Point(labelTime.Location.X + labelTime.Width, labelSecond.Location.Y);
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
