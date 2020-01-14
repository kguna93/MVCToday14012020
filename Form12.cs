using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpodS
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = BackgroundImagePictureBox.PointToClient(pos);
            label1.Parent = BackgroundImagePictureBox;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(label2.Location);
            pos1 = BackgroundImagePictureBox.PointToClient(pos1);
            label2.Parent = BackgroundImagePictureBox;
            label2.Location = pos1;
            label2.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label3.Location);
            pos2 = BackgroundImagePictureBox.PointToClient(pos2);
            label3.Parent = BackgroundImagePictureBox;
            label3.Location = pos2;
            label3.BackColor = Color.Transparent;



            var pos3 = this.PointToScreen(RingPictureBox.Location);
            pos3 = BackgroundImagePictureBox.PointToClient(pos3);
            RingPictureBox.Parent = BackgroundImagePictureBox;
            RingPictureBox.Location = pos3;
            RingPictureBox.BackColor = Color.Transparent;


            var pos4 = this.PointToScreen(CheckYourSizeButton.Location);
            pos4 = BackgroundImagePictureBox.PointToClient(pos4);
            CheckYourSizeButton.Parent = BackgroundImagePictureBox;
            CheckYourSizeButton.Location = pos4;
            CheckYourSizeButton.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(label4.Location);
            pos5 = RingPictureBox.PointToClient(pos5);
            label4.Parent = RingPictureBox;
            label4.Location = pos5;
            label4.BackColor = Color.Transparent;



        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Yu Gothic", 9);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("1分未満で計測できます", myFont, myBrush, 0, 0);
        }

        private void CheckYourSizeButton_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }
    }
}
