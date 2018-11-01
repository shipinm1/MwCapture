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
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int flags);

        // [DllImport("user32.dll")]
        //public static extern IntPtr CreateRectRgn(int x, int y, int z, int c);
        // [DllImport("user32.dll")]
        //public static extern int GetWindowRgn(IntPtr hWnd, IntPtr hRgn);

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
            Process proc = null;

            if (Process.GetProcessesByName("notepad").Length >1)
            {
                proc = Process.GetProcessesByName("notepad")[0];
                pictureBox1.Image = CaptureApplication(proc.MainWindowHandle);
                pictureBox2.Image = CaptureApplication(proc.MainWindowHandle);
                pictureBox3.Image = CaptureApplication(proc.MainWindowHandle);

                if (IsIconic(proc.MainWindowHandle))
                {
                    // MessageBox.Show("iconic");
                    ShowWindow(proc.MainWindowHandle, 9);
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("can not find process");
                
            }
            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void capture_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Bitmap save = CaptureApplication(this.Handle);
            f2.SetPic(save);
            f2.Show();
        }
    }
}
