using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm1.Forms
{
    public partial class ShowPic : Form
    {
        Image pic;
        public ShowPic(Image image)
        {
            InitializeComponent();
            pic = (Image)image;
        }

        private void ShowPic_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pic;
        }
    }
}
