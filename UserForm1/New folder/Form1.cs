using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string myvalue
        {
            get { return textBoxUsername.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1_Click(sender,e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox2_Click(sender, e);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text=="Password" )
            { }
            else if (checkBoxShowPass.Checked == true)
                textBoxPassword.UseSystemPasswordChar = false;
            else 
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.ForeColor = Color.FromArgb(180, 180, 180);
                textBoxUsername.Text = "Username"; 
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;

            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.FromArgb(180, 180, 180);
                textBoxPassword.Text = "Password";
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                var form2 = new FormMainUser();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
              
        }
    }
}
