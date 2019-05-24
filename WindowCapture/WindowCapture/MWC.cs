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
using System.Drawing.Drawing2D;

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
        Process proc1, proc2, proc3;
        private bool p1, p2, p3;


        public MWC()
        {
            InitializeComponent();
            buttonIndicator.Visible = false;
            startButtonBackground.Visible = false;
            DoubleBuffered = true;

        }

        #region Preperation block(dlls & structs)
        [StructLayout(LayoutKind.Sequential)]
        internal struct DWM_THUMBNAIL_PROPERTIES
        {
            public int dwFlags;
            public Rect rcDestination;
            public Rect rcSource;
            public byte opacity;
            public bool fVisible;
            public bool fSourceClientAreaOnly;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Rect
        {
            internal Rect(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct PSIZE
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int flags);
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("dwmapi.dll")]
        public static extern int DwmRegisterThumbnail(IntPtr dest, IntPtr source, out IntPtr thumb);
        [DllImport("dwmapi.dll")]
        private static extern int DwmUpdateThumbnailProperties(IntPtr thumb, ref DWM_THUMBNAIL_PROPERTIES props);
        [DllImport("dwmapi.dll")]
        private static extern int DwmQueryThumbnailSourceSize(IntPtr thumb, out PSIZE size);
        [DllImport("dwmapi.dll")]
        static extern int DwmUnregisterThumbnail(IntPtr thumb);

        #endregion
        //Take bitmap cauture from target application
        public static Bitmap CaptureApplication(IntPtr hwnd) {
            RECT rc;
            GetWindowRect(hwnd, out rc);
            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format24bppRgb);
                using (Graphics gfxBmp = Graphics.FromImage(bmp))
                {
                    IntPtr hdcBitmap = gfxBmp.GetHdc();
                    try
                    {
                        PrintWindow(hwnd, hdcBitmap, 0);
                    }
                    finally
                    {
                        gfxBmp.ReleaseHdc(hdcBitmap);
                    }
                    return bmp;
                }
        }
        //capture whole desktop as bitmap
        public static Bitmap CaptureDesktop()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format24bppRgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            gfxBmp.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            gfxBmp.Dispose();
            return bmp;
        }
        
        //timer1 per tick actions
        private void timer1_Tick(object sender, EventArgs e)
        {
            sTime = DateTime.Now;
            recordingTime.Text = (sTime - startingTime).ToString();
        }

        //move indicator to target button and transfor to suitable size
        void indicator_mover(Button button)
        {
            buttonIndicator.Visible = true;
            buttonIndicator.Height = button.Height;
            buttonIndicator.Top = button.Top;
        }

        //resetButt button click event
        private void button2_Click(object sender, EventArgs e)
        {
            indicator_mover(resetButt);
            p1Name.ReadOnly = false;
            p2Name.ReadOnly = false;
            p3Name.ReadOnly = false;
            p1LoadButt.BackColor = Color.Gray;
            p2LoadButt.BackColor = Color.Gray;
            p3LoadButt.BackColor = Color.Gray;
            DwmUnregisterThumbnail(proc1.MainWindowHandle);
            DwmUnregisterThumbnail(proc2.MainWindowHandle);
            DwmUnregisterThumbnail(proc3.MainWindowHandle);
            
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
            SETTING f3 = new SETTING();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
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
            if (this.Size.Height < 1060 || this.Size.Width < 1900)
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
            timer1.Enabled = true;
            startButtonBackground.Visible = true;
            StartRecording();
            startingTime = DateTime.Now;

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
            timer1.Enabled = false;
            startButtonBackground.Visible = false;
            if (selfCapture != null)
            {
                if (selfCapture.Status == RecordStatus.Running)
                    selfCapture.Stop();
            }
            else
                MessageBox.Show("Recording not started.");
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

        private void p1LoadButt_Click(object sender, EventArgs e)
        {
            p1Name.ReadOnly = true;
            p1LoadButt.BackColor = Color.Red;
            proc1 = Process.GetProcessesByName(p1name)[0];
            getSource(proc1, pictureBox1);
        }

        private void p2LoadButt_Click(object sender, EventArgs e)
        {
            p2Name.ReadOnly = true;
            p2LoadButt.BackColor = Color.Red;
            proc2 = Process.GetProcessesByName(p2name)[0];
            getSource(proc2, pictureBox2);
        }

        private void p3LoadButt_Click(object sender, EventArgs e)
        {
            p3Name.ReadOnly = true;
            p3LoadButt.BackColor = Color.Red;
            proc3 = Process.GetProcessesByName(p3name)[0];
            getSource(proc3, pictureBox3);
        }

        //Background color gradient
        private void MWC_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.WhiteSmoke, Color.Gray, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        //DMW method to get the thumbnail from target application
        private void getSource(Process proc, PictureBox pBox)
        {
            RECT rc;
            IntPtr hc;
            GetWindowRect(proc.MainWindowHandle, out rc);
            DwmRegisterThumbnail(this.Handle, proc.MainWindowHandle, out hc);
            //Connect target window with this window
            DwmQueryThumbnailSourceSize(hc, out PSIZE size);
            //setting properties for thumbnail
            DWM_THUMBNAIL_PROPERTIES props = new DWM_THUMBNAIL_PROPERTIES();
            props.dwFlags = DWMApi.DWM_TNP_VISIBLE | DWMApi.DWM_TNP_RECTDESTINATION | DWMApi.DWM_TNP_OPACITY;
            props.opacity = 255;
            props.fVisible = true;
            props.rcDestination = new Rect(pBox.Left, pBox.Top, pBox.Right, pBox.Bottom);
            if (size.x < pBox.Width)
                props.rcDestination.Right = props.rcDestination.Left + size.x;

            if (size.y < pBox.Height)
                props.rcDestination.Bottom = props.rcDestination.Top + size.y;

            DwmUpdateThumbnailProperties(hc, ref props);
        }
    }
}
