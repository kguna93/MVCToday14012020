using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UpodS
{
  
    public partial class Form3 : Form
    {
        public System.Timers.Timer timeCheck = new System.Timers.Timer();
        public int checkMode = 0;
        public string proxy = @"C:\UPOD 3D Full Foot Scan\Bin\UPOD_Proxy.exe";    //.exe file required to start the UPOD-S Scanner
        public string client = @"C:\UPOD 3D Full Foot Scan\Bin\UPOD_Client.exe";  //.exe file required to start the UPOD-S Scanner
        public bool proxyOK = false;
        public Form3()
        {
            InitializeComponent();
            this.MeasuringRichTextBox.SelectionStart = 0;
            this.MeasuringRichTextBox.SelectionLength = this.MeasuringRichTextBox.Text.Length;
            MeasuringRichTextBox.SelectionFont = new Font(MeasuringRichTextBox.SelectionFont, FontStyle.Underline);
            this.MeasuringRichTextBox.SelectionLength = 0;

            Process[] processName = Process.GetProcessesByName("UPOD_Proxy");
            if (processName.Length == 0)
            {
                //Form3 f3 = new Form3();
                //f3.Hide();

                //Form5 f5 = new Form5();
                //f5.Hide();
                string paramCheck = "";
                int left = (int)(new Form5().view3DLeft).Handle;
                int right = (int)(view3DRight).Handle;
                //int left2 = (int)(new Form5().view3DLeft2).Handle;
                int right2 = (int)(new Form8().view3DRight2).Handle;
                //paramCheck += " -Lwd " + left.ToString() + " -Rwd " + right.ToString() + " -Lwd2 " + left2.ToString() + " -Rwd2 " + right2.ToString();
                Process proxyProcess = Process.Start(proxy, paramCheck);
                Thread.Sleep(8000);
                try
                {
                    if (proxyProcess.ExitCode >= 500 || proxyProcess.ExitCode == 110)
                    {
                        Console.WriteLine(proxyProcess.ExitCode);
                        if (proxyProcess.ExitCode == 110)
                        {
                            MessageBox.Show("Please connect the dongle properly and restart the application");
                            proxyOK = false;
                            this.Close();
                        }
                        else if (proxyProcess.ExitCode == 505)
                        {
                            MessageBox.Show("Please check if the power socket and USB cable are properly connected and restart the application");
                            proxyOK = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please restart the application");
                            Console.WriteLine(proxyProcess.ExitCode.ToString());
                            proxyOK = false;
                            this.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Launching the Scan View App");
                        proxyOK = true;
                        // To enable the UPOD-S Scanner
                        if (!proxyOK)
                        {

                            return;
                        }
                        string param1 = " -enable";
                        Process.Start(client, param1);
                        checkMode = 1;
                        timeCheck.Start();
                    }
                }
                catch (System.Exception ex)
                {

                    Console.WriteLine("Launching the Scan View App");
                    proxyOK = true;
                    // To enable the UPOD-S Scanner
                    if (!proxyOK)
                    {
                        return;
                    }
                    string param2 = " -enable";
                    Process.Start(client, param2);
                    checkMode = 1;
                    timeCheck.Start();

                }
                timeCheck.Enabled = true;
                timeCheck.AutoReset = true;
                timeCheck.Interval = 500;
                timeCheck.Stop();
                timeCheck.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);

                int n;
                string valuef = "";
                if (Tmp.InputBox("Details", "Your First Name:", ref valuef) == DialogResult.OK)
                {
                    Console.WriteLine(valuef);
                    //myDocument.Name = value;
                }
                string valuel = "";
                if (Tmp.InputBox("Details", "Your Last Name:", ref valuel) == DialogResult.OK)
                {
                    Console.WriteLine(valuel);
                    //myDocument.Name = value;
                }

                string valueg = "";
                if (Tmp.InputBox1("Details", "Gender:", ref valueg) == DialogResult.OK)
                {
                    Console.WriteLine(valueg);

                }
                if (valueg == "F")
                {
                    n = 1;
                }
                else
                {
                    n = 0;
                }
                if (!proxyOK)
                {
                    return;
                }
                string param = " -scan -r " + valuef + " " + valuel + " " + n + " " + "000000000000" + " " + "-name" + " " + @"E:\Test\" + valuef + valuel;
                //string param = " -scan -r Jonh Doe 0 000000000000";
                Process.Start(client, param);
                checkMode = 2;


            }
        }
        public class Tmp
        {
            public static DialogResult InputBox(string title, string promptText, ref string value)
            {
                Form form = new Form();
                Label label = new Label();
                TextBox textBox = new TextBox();
                Button buttonOk = new Button();
                Button buttonCancel = new Button();

                form.Text = title;
                label.Text = promptText;
                textBox.Text = value;

                buttonOk.Text = "OK";
                buttonCancel.Text = "Cancel";
                buttonOk.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;

                label.SetBounds(9, 20, 372, 13);
                textBox.SetBounds(12, 36, 372, 20);
                buttonOk.SetBounds(228, 72, 75, 23);
                buttonCancel.SetBounds(309, 72, 75, 23);

                label.AutoSize = true;
                textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new Size(396, 107);
                form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
                form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                DialogResult dialogResult = form.ShowDialog();
                value = textBox.Text;
                return dialogResult;
            }
            public static DialogResult InputBox1(string title, string promptText, ref string value)
            {
                Form form = new Form();
                Label label = new Label();
                RadioButton m = new RadioButton();
                RadioButton f = new RadioButton();
                Button buttonOk = new Button();
                Button buttonCancel = new Button();

                form.Text = title;
                label.Text = promptText;
                m.Text = "M";

                buttonOk.Text = "OK";
                buttonCancel.Text = "Cancel";
                buttonOk.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;

                label.SetBounds(9, 20, 372, 13);
                m.SetBounds(12, 36, 372, 20);
                //f.SetBounds(12, 36, 372, 20);
                buttonOk.SetBounds(228, 72, 75, 23);
                buttonCancel.SetBounds(309, 72, 75, 23);

                label.AutoSize = true;
                m.Anchor = m.Anchor | AnchorStyles.Right;
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new Size(396, 107);
                form.Controls.AddRange(new Control[] { label, m, buttonOk, buttonCancel });
                form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                DialogResult dialogResult = form.ShowDialog();
                if (m.Checked)
                {
                    value = m.Text;
                }
                else
                {
                    value = f.Text;
                }
                return dialogResult;
            }
        }
        public void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string paramCheck = " -check";
            Process pCheckProcessProcess = Process.Start(client, paramCheck);
            pCheckProcessProcess.WaitForExit();

            if (pCheckProcessProcess.ExitCode == 608)//608 Mutex Process
            {
                return;
            }

            if (checkMode == 1)// check enalbe
            {
                if (pCheckProcessProcess.ExitCode != 101)
                {
                    timeCheck.Stop();

                    if (pCheckProcessProcess.ExitCode == 201)
                    {
                        MessageBox.Show("Enable scanner successful.");
                    }
                    else
                    {
                        MessageBox.Show("Enable scanner failed.");                       
                    }
                }
            }
            if (checkMode == 2)// check scan
            {
                if (pCheckProcessProcess.ExitCode != 102)
                {
                    timeCheck.Stop();

                    if (pCheckProcessProcess.ExitCode == 202)
                    {
                        MessageBox.Show("Scan scanner successful.");
                    }
                    else
                    {
                        MessageBox.Show("Scan scanner failed." + pCheckProcessProcess.ExitCode.ToString());

                        MessageBox.Show(pCheckProcessProcess.ExitCode.ToString());
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
            timer1.Stop();
        }

        
    }
}
