using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;



namespace WindowCapture
{
    
    public partial class MWC : Form
    {
        private DateTime startingTime, sTime;
        private ScreenCaptureJob selfCapture;
        private string p1name, p2name, p3name;
        static Size e = Screen.PrimaryScreen.Bounds.Size;
        Bitmap temp = new Bitmap(e.Width, e.Height);
        public static int circlePosition = 0;


        public MWC()
        {
            InitializeComponent();
            buttonIndicator.Visible = false;
            startButtonBackground.Visible = false;
            DoubleBuffered = true;

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
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();

        // [DllImport("user32.dll")]
        //public static extern IntPtr CreateRectRgn(int x, int y, int z, int c);
        // [DllImport("user32.dll")]
        //public static extern int GetWindowRgn(IntPtr hWnd, IntPtr hRgn);

        public static Bitmap CaptureApplication(IntPtr hwnd) {
            RECT rc;
            GetWindowRect(hwnd, out rc);

            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppPArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(hwnd, hdcBitmap, 0);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();
            
            return bmp;
            
        }

        public static Bitmap CaptureDesktop()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format24bppRgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            gfxBmp.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            
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
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            if (selfCapture != null && selfCapture.Status == RecordStatus.Running)
            {
                recordingTime.Text = (DateTime.Now - startingTime).ToString("c");
            }

            if (p1name + p2name + p3name != "")
            {
                CaptureThread1();
                CaptureThread2();
                CaptureThread3();

            }

            else
            {
                timer1.Stop();
                MessageBox.Show("Process Name Can Not Be Empty"); //"steam" change to process name variable

            }
         
        }

        void indicator_mover(Button button)
        {
            buttonIndicator.Visible = true;
            buttonIndicator.Height = button.Height;
            buttonIndicator.Top = button.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indicator_mover(button1);
            timer1.Enabled = true;
            //timer2.Enabled = true;
            //timer3.Enabled = true;

            if (p1name == "")
                MessageBox.Show("Process 1 not found or empty");
            if (p2name == "")
                MessageBox.Show("Process 2 not found or empty");
            if (p3name == "")
                MessageBox.Show("Process 3 not found or empty");
            sTime = DateTime.Now;
            Debug.WriteLine(Process.GetCurrentProcess().Threads.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indicator_mover(button2);
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private Bitmap cropImage(Bitmap img)
        {
            Rectangle cropArea = new Rectangle();
            cropArea.X = this.Location.X + 116;
            cropArea.Y = this.Location.Y + 20;
            cropArea.Width = this.Width - 116;
            cropArea.Height = this.Height - 20;
            Bitmap b = new Bitmap(img);
            return b.Clone(cropArea, b.PixelFormat);
        }

        private void capture_Click(object sender, EventArgs e)
        {
            //indicator_mover(capture);
            CAPTURE f2 = new CAPTURE();
            //Bitmap save = CaptureApplication(this.Handle);
            Bitmap save = CaptureDesktop();
            f2.SetPic(cropImage(save));
            //f2.SetPic(cropImage(save));
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
            //indicator_mover(setting);
            SETTING f3 = new SETTING();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer2.Interval = 1000;
            timer3.Interval = 10;
            if (Convert.ToInt32(Properties.Settings.Default["formBorderStyle"]) == 0)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
                this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Location = new Point(5,5);
            p1Name.Text = Properties.Settings.Default["p1"].ToString();
            p2Name.Text = Properties.Settings.Default["p2"].ToString();
            p3Name.Text = Properties.Settings.Default["p3"].ToString();
            recordingTime.ReadOnly = true;

        }
  
        private void p1Name_TextChanged(object sender, EventArgs e)
        {
            p1name = p1Name.Text;
        }

        private void p2Name_TextChanged(object sender, EventArgs e)
        {
            p2name = p2Name.Text;
        }

        private void p3Name_TextChanged(object sender, EventArgs e)
        {
            p3name = p3Name.Text;
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
            if (this.Size.Height < 1060 && this.Size.Width < 1900)
            {
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
                startButton.Location = new Point(startButton.Location.X, pictureBox1.Size.Height + 66);
                stopButton.Location = new Point(stopButton.Location.X, pictureBox1.Size.Height + 66);
                recordingTime.Location = new Point(recordingTime.Location.X, pictureBox1.Size.Height + 66);
                elementHost1.Location = new Point(p3Name.Location.X + 46, p3Name.Location.Y);
                startButtonBackground.Location = new Point(startButton.Location.X - 5, startButton.Location.Y - 4);
            }


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButtonBackground.Visible = true;
            StartRecording();
            startingTime = DateTime.Now;

        }

        private void MWC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                CAPTURE f2 = new CAPTURE();
                Bitmap save = CaptureDesktop();
                f2.SetPic(cropImage(save));
                f2.Show();
            }
        }

        void StartRecording()
        {
            selfCapture = new ScreenCaptureJob();
            RECT selfRec;
            int recordingType = Convert.ToInt32(Properties.Settings.Default["recordingType"]);

            if (recordingType == 0)
            {
                GetWindowRect(this.Handle, out selfRec);
                if (selfRec.Size.Width % 4 != 0 || selfRec.Size.Height % 4 != 0)
                {
                    selfRec.Width = selfRec.Size.Width - selfRec.Size.Width % 4;
                    selfRec.Height = selfRec.Size.Height - selfRec.Size.Height % 4;
                }
            }

            else
            {
                Size rectArea = SystemInformation.WorkingArea.Size;
                selfRec = new RECT(0, 0, rectArea.Width - (rectArea.Width % 4), rectArea.Height - (rectArea.Height % 4));
            }
            
            //Debug.WriteLine(selfRec.Size.Width % 4);
            //Debug.WriteLine(selfRec.Size.Height % 4);
            selfCapture.CaptureRectangle = selfRec;
            selfCapture.ShowFlashingBoundary = true;
            selfCapture.CaptureMouseCursor = true;
            //selfCapture.ShowCountdown = true;
            selfCapture.OutputPath = Properties.Settings.Default["pictureLocation"].ToString();
            selfCapture.Start();
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButtonBackground.Visible = false;
            if (selfCapture != null)
            {
                if (selfCapture.Status == RecordStatus.Running)
                    selfCapture.Stop();
            }
            //else
                //MessageBox.Show("Recording not started.");
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["p1"] = p1Name.Text;
            Properties.Settings.Default["p2"] = p2Name.Text;
            Properties.Settings.Default["p3"] = p3Name.Text;
            Properties.Settings.Default.Save();
            if (selfCapture.Status == RecordStatus.Running)
                selfCapture.Stop();
            selfCapture.Dispose();
            
        }
        int seconds = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(count);
            seconds += 1;
            fps.Text = (count / seconds).ToString();

            //if (p1name + p2name + p3name != "")
            //{
            //    CaptureThread2();
            //}
            //else
            //{
            //    timer2.Stop();
            //    MessageBox.Show("Process Name Can Not Be Empty"); //"steam" change to process name variable
            //}
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (p1name + p2name + p3name != "")
                {
                    CaptureThread3();
                }
                else
                {
                timer3.Stop();
                MessageBox.Show("Process Name Can Not Be Empty"); //"steam" change to process name variable
            }
        }

        

        private void CaptureThread1()
        {
            Process proc1 = null;
            
            proc1 = Process.GetProcessesByName(p1name)[0];
            if (IsIconic(proc1.MainWindowHandle))
            {
                //ShowWindow(proc1.MainWindowHandle, 9);
            }
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = CaptureApplication(proc1.MainWindowHandle);
            
        }
        private void CaptureThread2()
        {
            Process proc2 = null;
            proc2 = Process.GetProcessesByName(p2name)[0];
            if (IsIconic(proc2.MainWindowHandle))
            {
                //ShowWindow(proc1.MainWindowHandle, 9);
            }
            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            pictureBox2.Image = CaptureApplication(proc2.MainWindowHandle);        }
        private void CaptureThread3()
        {
            Process proc3 = null;
            proc3 = Process.GetProcessesByName(p3name)[0];
            if (IsIconic(proc3.MainWindowHandle))
            {
                //ShowWindow(proc1.MainWindowHandle, 9);
            }
            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
            pictureBox3.Image = CaptureApplication(proc3.MainWindowHandle);
        }

    }
}
