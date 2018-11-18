namespace WindowCapture
{
    partial class Form2
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
            this.savePic = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.savePic)).BeginInit();
            this.SuspendLayout();
            // 
            // savePic
            // 
            this.savePic.Location = new System.Drawing.Point(110, 20);
            this.savePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savePic.Name = "savePic";
            this.savePic.Size = new System.Drawing.Size(1138, 789);
            this.savePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.savePic.TabIndex = 0;
            this.savePic.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 20);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 47);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 92);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 50);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(16, 242);
            this.test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(90, 47);
            this.test.TabIndex = 3;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 619);
            this.Controls.Add(this.test);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.savePic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox savePic;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button test;
    }
}