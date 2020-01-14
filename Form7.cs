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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.SelectionLength = this.richTextBox1.Text.Length;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            this.richTextBox1.SelectionLength = 0;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Form8 f9 = new Form8();
            f9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
