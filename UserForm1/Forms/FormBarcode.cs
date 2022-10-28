using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video;



namespace UserForm1.Forms
{
    public partial class FormBarcode : Form
    {
        FormBanHang formBanhHang;
        FilterInfoCollection filterInfo;
        VideoCaptureDevice videoCapture;

        public FormBarcode(FormBanHang f)
        {
            InitializeComponent();
            formBanhHang = f;
        }

        private void FormBarcode_Load(object sender, EventArgs e)
        {
            //Add input video devices to Combobox
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfo)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = 0;

            videoCapture = new VideoCaptureDevice(filterInfo[comboBox1.SelectedIndex].MonikerString);
            videoCapture.NewFrame += new NewFrameEventHandler(video_frame);
            videoCapture.Start();

            timer1.Start();
        }

        private void video_frame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCapture!=null)
            {
                if(videoCapture.IsRunning)
                {
                    videoCapture.Stop();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            if (pictureBox1.BackgroundImage != null)
            {
                var result = reader.Decode((Bitmap)pictureBox1.BackgroundImage);
                if (result != null && formBanhHang.cbbMaSP.Items.Contains(result.Text)) 
                { 
                    formBanhHang.cbbMaSP.SelectedItem = result.Text;
                    formBanhHang.btnAdd_Click(sender, e);
                }
            }
        }
    }
}
