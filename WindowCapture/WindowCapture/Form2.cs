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

namespace WindowCapture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void SetPic(Bitmap bp) {
            savePic.Image = bp;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Image x = savePic.Image;
            x.Save(@"C:\button.Jpeg", ImageFormat.Jpeg);
        }
    }
}
