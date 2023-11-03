using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using AForge.Video;
using AForge.Video.DirectShow;

namespace photobooth
{
    public partial class Form1 : Form
    {

        bool _streaming;
        Capture _capture;
        Bitmap frame;
        Bitmap pic1;
        Bitmap pic2;
        Bitmap pic3;
        Bitmap photo;
        Bitmap blank = new Bitmap(1, 1);


        public Form1()
        {
            InitializeComponent();
        }

        private void load1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1 = new Bitmap(streamCam.Image, 700, 525);
            pictureBox1.Image = pic1;
        }

        private void load2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2 = new Bitmap(streamCam.Image, 700, 525);
            pictureBox2.Image = pic2;
        }

        private void load3_Click(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3 = new Bitmap(streamCam.Image, 700, 525);
            pictureBox3.Image = pic3;
        }

        private void renderBtn_Click(object sender, EventArgs e)
        {
            // photo = new Bitmap(874, 2480);
            photo = new Bitmap(1748, 2480);

            Graphics g = Graphics.FromImage(photo);

            // g.FillRectangle(Brushes.Green, 0, 0, photo.Width, photo.Height);

            g.DrawImage(pic1, new Point(87, 150));
            g.DrawImage(pic2, new Point(87, 750));
            g.DrawImage(pic3, new Point(87, 1350));

            g.DrawImage(frame, new Point(0, 0));

            g.DrawImage(pic1, new Point(87 + 874, 150));
            g.DrawImage(pic2, new Point(87 + 874, 750));
            g.DrawImage(pic3, new Point(87 + 874, 1350));

            g.DrawImage(frame, new Point(874, 0));

            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = photo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _streaming = false;
            

            FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
			{
                activeCamList.Items.Add(filterInfo.Name);
        
			}

            activeCamList.SelectedIndex = 0;
            _capture = new Capture(activeCamList.SelectedIndex);

            using (Graphics g = Graphics.FromImage(blank)) { g.Clear(Color.White); }

            streamCam.Image = blank;
            pic1 = blank;
            pic2 = blank;
            pic3 = blank;
            frame = blank;
        }

        private void streaming(object sender, System.EventArgs e)
        {
            

            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            // streamCam.Image = new Bitmap(bmp, streamCam.Width, streamCam.Width);
            streamCam.SizeMode = PictureBoxSizeMode.Zoom;
            streamCam.Image = bmp;
        }

        private void streamBtn_Click(object sender, EventArgs e)
        {
            if (!_streaming)
            {
                Application.Idle += streaming;
                streamBtn.Text = @"Stop Streaming";
                streamBtn.ForeColor = Color.White;
                streamBtn.BackColor = Color.Red;

                
            } else
            {
                Application.Idle -= streaming;
                streamBtn.Text = @"Start Streaming";
                streamBtn.ForeColor = Color.White;
                streamBtn.BackColor = Color.Green;
                streamCam.Image = blank;
            }

            _streaming = !_streaming;
        }

        private void framBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                frame = new Bitmap(selectedImagePath);

                frameBox.SizeMode = PictureBoxSizeMode.Zoom;
                frameBox.Image = frame;
            }
        }

		private void saveBtn_Click(object sender, EventArgs e)
		{
            String projectName;
            DateTime dt = DateTime.Now; // Or whatever
            string runningNumber = dt.ToString("yyMMddHHmmss");

            if (projectBox.Text == "")
			{
                projectName = "untitledProject";
			} else
			{
                projectName = projectBox.Text;
			}

            saveFileDialog1.FileName = projectName + "-" + runningNumber + ".png";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photo.Save(saveFileDialog1.FileName);
            }
        }

        private void myPrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            photo.Dispose();
        }

        private void printBtn_Click(object sender, EventArgs e)
		{       

            
        }
	}
}