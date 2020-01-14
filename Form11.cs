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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.SelectionLength = this.richTextBox1.Text.Length;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            this.richTextBox1.SelectionLength = 0;
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
