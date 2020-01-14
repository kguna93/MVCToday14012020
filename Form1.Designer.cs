using System.Windows.Forms;

namespace UpodS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BackgroundImagePictureBox = new System.Windows.Forms.PictureBox();
            this.SeekYourBestButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundImagePictureBox
            // 
            this.BackgroundImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundImagePictureBox.Image")));
            this.BackgroundImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.BackgroundImagePictureBox.Name = "BackgroundImagePictureBox";
            this.BackgroundImagePictureBox.Size = new System.Drawing.Size(783, 562);
            this.BackgroundImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImagePictureBox.TabIndex = 0;
            this.BackgroundImagePictureBox.TabStop = false;
            this.BackgroundImagePictureBox.Click += new System.EventHandler(this.BackgroundImagePictureBox_Click);
            // 
            // SeekYourBestButton
            // 
            this.SeekYourBestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeekYourBestButton.BackColor = System.Drawing.Color.Transparent;
            this.SeekYourBestButton.FlatAppearance.BorderSize = 0;
            this.SeekYourBestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SeekYourBestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SeekYourBestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeekYourBestButton.ForeColor = System.Drawing.Color.Black;
            this.SeekYourBestButton.Image = ((System.Drawing.Image)(resources.GetObject("SeekYourBestButton.Image")));
            this.SeekYourBestButton.Location = new System.Drawing.Point(261, 406);
            this.SeekYourBestButton.Name = "SeekYourBestButton";
            this.SeekYourBestButton.Size = new System.Drawing.Size(262, 69);
            this.SeekYourBestButton.TabIndex = 1;
            this.SeekYourBestButton.UseVisualStyleBackColor = false;
            this.SeekYourBestButton.Click += new System.EventHandler(this.SeekYourBestButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(207, 115);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(390, 203);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 2;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.SeekYourBestButton);
            this.Controls.Add(this.BackgroundImagePictureBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SureFit v0.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private ToolTip toolTip;
        private PictureBox BackgroundImagePictureBox;
        private Button SeekYourBestButton;
        private PictureBox LogoPictureBox;
        private Timer timer1;
    }
}

