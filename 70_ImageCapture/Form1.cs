using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70_ImageCapture
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(out POINT pt);
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator System.Drawing.Point(POINT point)
            {
                return new System.Drawing.Point(point.X, point.Y);
            }
        }

        Bitmap btMain;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            btMain = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(btMain))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                    Screen.PrimaryScreen.Bounds.Y,
                                    0, 0,
                                    btMain.Size,
                                    CopyPixelOperation.SourceCopy);

                //Picture Box Display
                pBoxImage.Image = btMain;

            }
        }

        private static System.Threading.Timer _timer = null;
        public static void Start()
        {

            _timer = new System.Threading.Timer(TimerCallback, null, 0, 5000);

        }


        private static void TimerCallback(Object o)
        {
            GetMousePositionAndScreenCapture();
        }

        public static void GetMousePositionAndScreenCapture()
        {

            POINT lpPoint;
            GetCursorPos(out lpPoint);

            System.Drawing.Size sz = new System.Drawing.Size();
            sz.Height = 100;
            sz.Width = 100;

            var bounds = new Rectangle(lpPoint, sz);
            var image = new Bitmap(bounds.Width, bounds.Height);
            using (var graphics = Graphics.FromImage(image))
            {
                graphics.CopyFromScreen(new System.Drawing.Point(bounds.Left, bounds.Top), System.Drawing.Point.Empty, bounds.Size);
            }
            image.Save(@"C:\temp\newss.jpeg", ImageFormat.Jpeg);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            if (btMain != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "JPG File(*.jpg) | *.jpg";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    btMain.Save(sfd.FileName);
                }

            }*/
            Start();
        }
    }
}
