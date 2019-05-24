namespace WindowCapture
{
    partial class MWC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MWC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetButt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.capture = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.p3Name = new System.Windows.Forms.TextBox();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.recordingTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIndicator = new System.Windows.Forms.Panel();
            this.startButtonBackground = new System.Windows.Forms.Panel();
            this.fps = new System.Windows.Forms.Label();
            this.p1LoadButt = new System.Windows.Forms.Button();
            this.p2LoadButt = new System.Windows.Forms.Button();
            this.p3LoadButt = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WpfControlLibrary1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1024, 576);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resetButt
            // 
            this.resetButt.AutoSize = true;
            this.resetButt.FlatAppearance.BorderSize = 0;
            this.resetButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resetButt.Location = new System.Drawing.Point(5, 24);
            this.resetButt.Margin = new System.Windows.Forms.Padding(2);
            this.resetButt.Name = "resetButt";
            this.resetButt.Size = new System.Drawing.Size(96, 62);
            this.resetButt.TabIndex = 3;
            this.resetButt.Text = "RESET";
            this.resetButt.UseVisualStyleBackColor = true;
            this.resetButt.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1149, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(732, 458);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // capture
            // 
            this.capture.AutoSize = true;
            this.capture.FlatAppearance.BorderSize = 0;
            this.capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.capture.Location = new System.Drawing.Point(5, 90);
            this.capture.Margin = new System.Windows.Forms.Padding(2);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(96, 62);
            this.capture.TabIndex = 5;
            this.capture.Text = "CAPTURE";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.capture_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1149, 482);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(732, 458);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitButton.Location = new System.Drawing.Point(9, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 62);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // setting
            // 
            this.setting.AutoSize = true;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.setting.Location = new System.Drawing.Point(5, 156);
            this.setting.Margin = new System.Windows.Forms.Padding(2);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(96, 62);
            this.setting.TabIndex = 8;
            this.setting.Text = "SETTING";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "P1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "P3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "P2:";
            // 
            // p1Name
            // 
            this.p1Name.Location = new System.Drawing.Point(155, 602);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(100, 20);
            this.p1Name.TabIndex = 12;
            this.p1Name.TextChanged += new System.EventHandler(this.p1Name_TextChanged);
            // 
            // p3Name
            // 
            this.p3Name.Location = new System.Drawing.Point(155, 660);
            this.p3Name.Name = "p3Name";
            this.p3Name.Size = new System.Drawing.Size(100, 20);
            this.p3Name.TabIndex = 13;
            this.p3Name.TextChanged += new System.EventHandler(this.p3Name_TextChanged);
            // 
            // p2Name
            // 
            this.p2Name.Location = new System.Drawing.Point(155, 631);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(100, 20);
            this.p2Name.TabIndex = 14;
            this.p2Name.TextChanged += new System.EventHandler(this.p2Name_TextChanged);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(121, 695);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 56);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START Recording";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(259, 695);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(109, 56);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "STOP Recording";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // recordingTime
            // 
            this.recordingTime.BackColor = System.Drawing.Color.DarkGray;
            this.recordingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordingTime.Location = new System.Drawing.Point(116, 760);
            this.recordingTime.Name = "recordingTime";
            this.recordingTime.Size = new System.Drawing.Size(117, 26);
            this.recordingTime.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetButt);
            this.panel1.Controls.Add(this.capture);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 1021);
            this.panel1.TabIndex = 27;
            // 
            // buttonIndicator
            // 
            this.buttonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonIndicator.Location = new System.Drawing.Point(106, 24);
            this.buttonIndicator.Name = "buttonIndicator";
            this.buttonIndicator.Size = new System.Drawing.Size(10, 62);
            this.buttonIndicator.TabIndex = 28;
            // 
            // startButtonBackground
            // 
            this.startButtonBackground.BackColor = System.Drawing.Color.Red;
            this.startButtonBackground.Location = new System.Drawing.Point(116, 691);
            this.startButtonBackground.Name = "startButtonBackground";
            this.startButtonBackground.Size = new System.Drawing.Size(119, 63);
            this.startButtonBackground.TabIndex = 29;
            // 
            // fps
            // 
            this.fps.AutoSize = true;
            this.fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fps.Location = new System.Drawing.Point(112, 789);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(34, 24);
            this.fps.TabIndex = 31;
            this.fps.Text = "fps";
            this.fps.Visible = false;
            // 
            // p1LoadButt
            // 
            this.p1LoadButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p1LoadButt.Location = new System.Drawing.Point(259, 602);
            this.p1LoadButt.Name = "p1LoadButt";
            this.p1LoadButt.Size = new System.Drawing.Size(75, 23);
            this.p1LoadButt.TabIndex = 32;
            this.p1LoadButt.Text = "Load";
            this.p1LoadButt.UseVisualStyleBackColor = true;
            this.p1LoadButt.Click += new System.EventHandler(this.p1LoadButt_Click);
            // 
            // p2LoadButt
            // 
            this.p2LoadButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2LoadButt.Location = new System.Drawing.Point(259, 629);
            this.p2LoadButt.Name = "p2LoadButt";
            this.p2LoadButt.Size = new System.Drawing.Size(75, 23);
            this.p2LoadButt.TabIndex = 33;
            this.p2LoadButt.Text = "Load";
            this.p2LoadButt.UseVisualStyleBackColor = true;
            this.p2LoadButt.Click += new System.EventHandler(this.p2LoadButt_Click);
            // 
            // p3LoadButt
            // 
            this.p3LoadButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p3LoadButt.Location = new System.Drawing.Point(259, 657);
            this.p3LoadButt.Name = "p3LoadButt";
            this.p3LoadButt.Size = new System.Drawing.Size(75, 23);
            this.p3LoadButt.TabIndex = 34;
            this.p3LoadButt.Text = "Load";
            this.p3LoadButt.UseVisualStyleBackColor = true;
            this.p3LoadButt.Click += new System.EventHandler(this.p3LoadButt_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(374, 605);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(289, 275);
            this.elementHost1.TabIndex = 30;
            this.elementHost1.Text = "t";
            this.elementHost1.Child = this.userControl11;
            // 
            // MWC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1884, 1021);
            this.Controls.Add(this.p3LoadButt);
            this.Controls.Add(this.p2LoadButt);
            this.Controls.Add(this.p1LoadButt);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.buttonIndicator);
            this.Controls.Add(this.recordingTime);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.p3Name);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButtonBackground);
            this.Controls.Add(this.elementHost1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MWC";
            this.Text = "MWC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.MWC_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MWC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resetButt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p1Name;
        private System.Windows.Forms.TextBox p3Name;
        private System.Windows.Forms.TextBox p2Name;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox recordingTime;
        private System.Windows.Forms.Panel buttonIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel startButtonBackground;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WpfControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.Label fps;
        private System.Windows.Forms.Button p1LoadButt;
        private System.Windows.Forms.Button p2LoadButt;
        private System.Windows.Forms.Button p3LoadButt;
    }
}

