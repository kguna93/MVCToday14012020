using DevExpress.XtraEditors.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UpodS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var width1 = Screen.PrimaryScreen.Bounds.Width;
            var height1 = Screen.PrimaryScreen.Bounds.Height;
            Console.WriteLine("Width of the present screen is :" + width1.ToString());
            Console.WriteLine("Height of the present screen is :" + height1.ToString());
            
            if (width1 == 1920 && height1 == 1080)
            {
                this.BackgroundImagePictureBox.Size = new System.Drawing.Size(1400, 1000);
            }

            this.SizeChanged += new EventHandler(form1_sizeeventhandler);

            var pos = this.PointToScreen(SeekYourBestButton.Location);
            pos = BackgroundImagePictureBox.PointToClient(pos);
            SeekYourBestButton.Parent = BackgroundImagePictureBox;

            SeekYourBestButton.Location = pos;
            SeekYourBestButton.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(LogoPictureBox.Location);
            pos1 = BackgroundImagePictureBox.PointToClient(pos1);
            LogoPictureBox.Parent = BackgroundImagePictureBox;
            LogoPictureBox.Location = pos1;
            LogoPictureBox.BackColor = Color.Transparent;
        }

        private void SeekYourBestButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

      

        private void BackgroundImagePictureBox_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
            timer1.Stop();

        }

        private void form1_sizeeventhandler(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                MessageBox.Show("Form is mininized");
                // handle it
            }

            if (this.WindowState == FormWindowState.Normal)
            {
                MessageBox.Show("Form is restored");
                // handle it

            }



            if (this.WindowState == FormWindowState.Maximized)
            {

                MessageBox.Show("Form is maximized");
                // handle it
            }

        }
    }

}
