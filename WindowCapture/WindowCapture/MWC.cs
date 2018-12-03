﻿using System;
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
    public partial class MWC : Form
    {
        private string p1name, p2name, p3name;
        static Size e = Screen.PrimaryScreen.Bounds.Size;
        Bitmap temp = new Bitmap(e.Width, e.Height);
        public MWC()
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
            Process proc1 = null;
            Process proc2 = null;
            Process proc3 = null;
            if (p1name + p2name + p3name != "")
            {
                //MessageBox.Show(p1name + p2name + p3name);
                if (p1name != "" && Process.GetProcessesByName(p1name).Length > 0)
                {
                    proc1 = Process.GetProcessesByName(p1name)[0];
                    if (IsIconic(proc1.MainWindowHandle))
                    {
                        ShowWindow(proc1.MainWindowHandle, 9);
                    }
                    pictureBox1.Image = CaptureApplication(proc1.MainWindowHandle);
                   
                }

                if (p2name != "" && Process.GetProcessesByName(p2name).Length > 0)
                {
                    proc2 = Process.GetProcessesByName(p2name)[0];
                    if (IsIconic(proc2.MainWindowHandle))
                    {
                        ShowWindow(proc2.MainWindowHandle, 9);
                    }
                    pictureBox2.Image = CaptureApplication(proc2.MainWindowHandle);
                    
                }

                if (p3name != "" && Process.GetProcessesByName(p3name).Length > 0)
                {
                    proc3 = Process.GetProcessesByName(p3name)[0];
                    if (IsIconic(proc3.MainWindowHandle))
                    {
                        ShowWindow(proc3.MainWindowHandle, 9);
                    }
                    pictureBox3.Image = CaptureApplication(proc3.MainWindowHandle);
                    
                }
                
            }

            else
            {
                timer1.Stop();
                MessageBox.Show("Process Name Can Not Be Empty"); //"steam" change to process name variable

            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (p1name == "")
                MessageBox.Show("Process 1 not found or empty");
            if (p2name == "")
                MessageBox.Show("Process 1 not found or empty");
            if (p3name == "")
                MessageBox.Show("Process 1 not found or empty");
            string sTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            //Debug.WriteLine(sTime);
            //Debug.WriteLine("c:\\Users\\gsp\\Desktop\\test_" + DateTime.Now + ".jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private Bitmap cropImage(Bitmap img)
        {
            Rectangle cropArea = new Rectangle();
            cropArea.Width = this.Width - 126;
            cropArea.Height = this.Height - 41;
            cropArea.X = 125;
            cropArea.Y = 40;
            Debug.WriteLine(this.Size);
            Bitmap b = new Bitmap(img);
            return b.Clone(cropArea, b.PixelFormat);
        }

        private void capture_Click(object sender, EventArgs e)
        {
            CAPTURE f2 = new CAPTURE();
            Bitmap save = CaptureApplication(this.Handle);
            
            f2.SetPic(cropImage(save));
            f2.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["p1"] = p1Name.Text;
            Properties.Settings.Default["p2"] = p2Name.Text;
            Properties.Settings.Default["p3"] = p3Name.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            SETTING f3 = new SETTING();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1Name.Text = Properties.Settings.Default["p1"].ToString();
            p2Name.Text = Properties.Settings.Default["p2"].ToString();
            p3Name.Text = Properties.Settings.Default["p3"].ToString();
            
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void p1Name_TextChanged(object sender, EventArgs e)
        {
            p1name = p1Name.Text;
        }

        private void p2Name_TextChanged(object sender, EventArgs e)
        {
            p2name = p2Name.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        //resize event
        private void MWC_ResizeEnd(object sender, EventArgs e)
        {
            double formHeight = this.Size.Height;
            double formWidth = this.Size.Width;
            double ratio = 1.875;
            double secondaryRatio = 2.8;
            
            pictureBox1.Size = new Size((int)(formWidth / ratio), (int)(formHeight / ratio));
            pictureBox2.Size = new Size((int)(formWidth / secondaryRatio), (int)(formHeight / secondaryRatio));
            pictureBox3.Size = new Size((int)(formWidth / secondaryRatio), (int)(formHeight / secondaryRatio));
            pictureBox2.Location = new Point(pictureBox1.Location.X + pictureBox1.Size.Width + 5, 24);
            pictureBox3.Location = new Point(pictureBox1.Location.X + pictureBox1.Size.Width + 5, 30 + pictureBox2.Size.Height);
            label1.Location = new Point(label1.Location.X, pictureBox1.Size.Height + 26);
            label2.Location = new Point(label2.Location.X, pictureBox1.Size.Height + 26);
            label3.Location = new Point(label3.Location.X, pictureBox1.Size.Height + 26);
            p1Name.Location = new Point(p1Name.Location.X, pictureBox1.Size.Height + 26);
            p2Name.Location = new Point(p2Name.Location.X, pictureBox1.Size.Height + 26);
            p3Name.Location = new Point(p3Name.Location.X, pictureBox1.Size.Height + 26);
            
        }

        private void p3Name_TextChanged(object sender, EventArgs e)
        {
            p3name = p3Name.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["p1"] = p1Name.Text;
            Properties.Settings.Default["p2"] = p2Name.Text;
            Properties.Settings.Default["p3"] = p3Name.Text;
            Properties.Settings.Default.Save();
            
        }
    }
}