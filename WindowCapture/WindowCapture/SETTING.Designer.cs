namespace WindowCapture
{
    partial class SETTING
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
            this.label1 = new System.Windows.Forms.Label();
            this.chooseButtonPicture = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.p3Location = new System.Windows.Forms.TextBox();
            this.p2Location = new System.Windows.Forms.TextBox();
            this.p1Location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseButtonP3 = new System.Windows.Forms.Button();
            this.chooseButtonP2 = new System.Windows.Forms.Button();
            this.chooseButtonP1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.borderStyleComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save to: ";
            // 
            // chooseButtonPicture
            // 
            this.chooseButtonPicture.Location = new System.Drawing.Point(436, 24);
            this.chooseButtonPicture.Margin = new System.Windows.Forms.Padding(2);
            this.chooseButtonPicture.Name = "chooseButtonPicture";
            this.chooseButtonPicture.Size = new System.Drawing.Size(62, 21);
            this.chooseButtonPicture.TabIndex = 1;
            this.chooseButtonPicture.Text = "choose";
            this.chooseButtonPicture.UseVisualStyleBackColor = true;
            this.chooseButtonPicture.Click += new System.EventHandler(this.choose_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(98, 25);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(308, 20);
            this.saveLocation.TabIndex = 2;
            this.saveLocation.TextChanged += new System.EventHandler(this.saveLocation_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(117, 317);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.cancelButton.Location = new System.Drawing.Point(331, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // p3Location
            // 
            this.p3Location.Location = new System.Drawing.Point(98, 103);
            this.p3Location.Name = "p3Location";
            this.p3Location.Size = new System.Drawing.Size(308, 20);
            this.p3Location.TabIndex = 5;
            this.p3Location.TextChanged += new System.EventHandler(this.p3Location_TextChanged);
            // 
            // p2Location
            // 
            this.p2Location.Location = new System.Drawing.Point(98, 77);
            this.p2Location.Name = "p2Location";
            this.p2Location.Size = new System.Drawing.Size(308, 20);
            this.p2Location.TabIndex = 6;
            this.p2Location.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // p1Location
            // 
            this.p1Location.Location = new System.Drawing.Point(98, 51);
            this.p1Location.Name = "p1Location";
            this.p1Location.Size = new System.Drawing.Size(308, 20);
            this.p1Location.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Program 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Program 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Program 1:";
            // 
            // chooseButtonP3
            // 
            this.chooseButtonP3.Location = new System.Drawing.Point(436, 102);
            this.chooseButtonP3.Margin = new System.Windows.Forms.Padding(2);
            this.chooseButtonP3.Name = "chooseButtonP3";
            this.chooseButtonP3.Size = new System.Drawing.Size(62, 21);
            this.chooseButtonP3.TabIndex = 11;
            this.chooseButtonP3.Text = "choose";
            this.chooseButtonP3.UseVisualStyleBackColor = true;
            this.chooseButtonP3.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseButtonP2
            // 
            this.chooseButtonP2.Location = new System.Drawing.Point(436, 76);
            this.chooseButtonP2.Margin = new System.Windows.Forms.Padding(2);
            this.chooseButtonP2.Name = "chooseButtonP2";
            this.chooseButtonP2.Size = new System.Drawing.Size(62, 21);
            this.chooseButtonP2.TabIndex = 12;
            this.chooseButtonP2.Text = "choose";
            this.chooseButtonP2.UseVisualStyleBackColor = true;
            this.chooseButtonP2.Click += new System.EventHandler(this.chooseButtonP2_Click);
            // 
            // chooseButtonP1
            // 
            this.chooseButtonP1.Location = new System.Drawing.Point(436, 50);
            this.chooseButtonP1.Margin = new System.Windows.Forms.Padding(2);
            this.chooseButtonP1.Name = "chooseButtonP1";
            this.chooseButtonP1.Size = new System.Drawing.Size(62, 21);
            this.chooseButtonP1.TabIndex = 13;
            this.chooseButtonP1.Text = "choose";
            this.chooseButtonP1.UseVisualStyleBackColor = true;
            this.chooseButtonP1.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Current App",
            "Desktop"});
            this.comboBox1.Location = new System.Drawing.Point(117, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Recording Style:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Border Style:";
            // 
            // borderStyleComboBox
            // 
            this.borderStyleComboBox.FormattingEnabled = true;
            this.borderStyleComboBox.Items.AddRange(new object[] {
            "Borderless",
            "Sizeable"});
            this.borderStyleComboBox.Location = new System.Drawing.Point(117, 159);
            this.borderStyleComboBox.Name = "borderStyleComboBox";
            this.borderStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.borderStyleComboBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(241, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "(Restart required)";
            // 
            // SETTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(529, 388);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.borderStyleComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chooseButtonP1);
            this.Controls.Add(this.chooseButtonP2);
            this.Controls.Add(this.chooseButtonP3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p1Location);
            this.Controls.Add(this.p2Location);
            this.Controls.Add(this.p3Location);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.chooseButtonPicture);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SETTING";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseButtonPicture;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox p3Location;
        private System.Windows.Forms.TextBox p2Location;
        private System.Windows.Forms.TextBox p1Location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chooseButtonP3;
        private System.Windows.Forms.Button chooseButtonP2;
        private System.Windows.Forms.Button chooseButtonP1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox borderStyleComboBox;
        private System.Windows.Forms.Label label9;
    }
}