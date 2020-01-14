using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpodS
{

    public partial class Form2 : Form
    {
        public System.Timers.Timer timeCheck = new System.Timers.Timer();
        public int checkMode = 0;
        public string proxy = @"C:\UPOD 3D Full Foot Scan\Bin\UPOD_Proxy.exe";    //.exe file required to start the UPOD-S Scanner
        public string client = @"C:\UPOD 3D Full Foot Scan\Bin\UPOD_Client.exe";  //.exe file required to start the UPOD-S Scanner
        public bool proxyOK = false;
        public Form2()
        {

            InitializeComponent();
            this.InstructionRichTextBox.SelectionStart = 0;
            this.InstructionRichTextBox.SelectionLength = this.InstructionRichTextBox.Text.Length;
            InstructionRichTextBox.SelectionFont = new Font(InstructionRichTextBox.SelectionFont, FontStyle.Underline);
            this.InstructionRichTextBox.SelectionLength = 0;

            var pos = this.PointToScreen(OkButton.Location);
            pos = OkButton.PointToClient(pos);
            OkButton.Parent = tableLayoutPanel10;
            OkButton.Location = pos;
            OkButton.BackColor = Color.Transparent;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 svc3 = new Form3();
            svc3.Show();
            this.Hide();
        }
    }       
}
   

    
