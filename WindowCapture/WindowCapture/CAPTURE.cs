using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Encoder = System.Drawing.Imaging.Encoder;
//using Word = Microsoft.Office.Interop.Word;


namespace WindowCapture
{
    public partial class CAPTURE : Form
    {
        private string location;
        public CAPTURE()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString("yyyy/MM/dd-HH:mm:ss");
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void SetPic(Bitmap bp) {
            savePic.Image = bp;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
            var encParams = new EncoderParameters() { Param = new[] { new EncoderParameter(Encoder.Quality, 100L) } };
            //image.Save(path, encoder, encParams);
            location = SETTING.pictureSaveLocation;
            Image x = savePic.Image;
            //File.WriteAllText("C:\\Users", "empty");
            //Saved path should be changed to user input
            //100 quality jpeg file
            
            string sTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            if (location != null)
            {
                x.Save(SETTING.pictureSaveLocation + @"\test_" + sTime + ".jpg", encoder, encParams); //image name should be changed to unique image ID
                x.Dispose();
                savePic.Image.Dispose();
                MessageBox.Show("Image Saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid File Location\n\nPicture Saving Failed");
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            savePic.Image.Dispose();
        }

        private void test_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
