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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowCapture
{
    public partial class Form1 : Form
    {
        static Size e = Screen.PrimaryScreen.Bounds.Size;
        Bitmap temp = new Bitmap(e.Width, e.Height);
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        //private void StartProcess_Click(object sender, EventArgs e)
        //{
        //   Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
        //}

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        public static Bitmap CaptureApplication(IntPtr hwnd) {
            RECT rc;
            GetWindowRect(hwnd, out rc);

            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format24bppRgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(hwnd, hdcBitmap, 0);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            return bmp;
        }


        private void Get_source()
        {
            //Size e = Screen.PrimaryScreen.Bounds.Size;
            //Bitmap img = new Bitmap(e.Width, e.Height);
            using (Graphics g = Graphics.FromImage(temp))
            {
                g.CopyFromScreen(0, 0, 0, 0, e);
            }
            //y += 1;
            //Debug.WriteLine(img.Size);
            //return img;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Get_source();
            //Process proc = Process.GetProcessById(11304);
            Process proc = Process.GetProcessesByName("devenv")[0];
            Debug.WriteLine(proc.Id);
            pictureBox1.Image = CaptureApplication(proc.MainWindowHandle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
