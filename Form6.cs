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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.SelectionLength = this.richTextBox1.Text.Length;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            this.richTextBox1.SelectionLength = 0;
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form7 f8 = new Form7();
            f8.Show();
            this.Hide();
            timer1.Stop();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
