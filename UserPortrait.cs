using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using WFA_GenerateurTrombinoscope;

namespace AWF_crop_image
{
    public partial class UserPortrait : UserControl
    {
        private Size _sizeMax = new Size(350, 450);
        private Double _ratioSize = (double)350 / 450;
        private int _hBorder = SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 2;
        private int _vBorder = SystemInformation.HorizontalScrollBarHeight + SystemInformation.BorderSize.Height * 2;
        private Portrait _portrait;
        private double _ratioZoom = 0.5d;

        private const double RATIO_MAX = 2.0d;

        private string _pathImage = "";
        public string PathImage
        {
            get { return _pathImage; }
            set
            {
                if (value != string.Empty)
                {
                    _portrait = new Portrait(value);
                    pictureBox1.Image = _portrait.zoom(_ratioZoom);
                }
                _pathImage = value;
            }
        }

        private bool _isMarked = true;
        public bool IsMarked
        {
            get { return _isMarked; }
            set
            {
                _isMarked = value;
                pictureBox1.Refresh();
            }
        }

        public UserPortrait()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Location = new Point(0, 0);

            panel1.Dock = DockStyle.Fill;
            panel1.AutoScroll = true;
            panel1.MouseWheel += new MouseEventHandler(panel1_MouseWheel);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!IsMarked) return;

            Size sizeClip = e.ClipRectangle.Size;
            sizeClip.Width += SystemInformation.VerticalScrollBarWidth;
            sizeClip.Height += SystemInformation.HorizontalScrollBarHeight;

            Rectangle cr = e.ClipRectangle;
            Graphics g = e.Graphics;

            // DrawString _ratioZoom
            string ratio = string.Format("{0:N2}", _ratioZoom);
            Font font = new Font(FontFamily.GenericMonospace, 12.0F);
            Point point = new Point(cr.X + 2, cr.Y + 52);
            g.DrawString(ratio, font, new SolidBrush(Color.Black), point);
            point.Offset(1, 1);
            g.DrawString(ratio, font, new SolidBrush(Color.White), point);

            if (sizeClip == ClientSize) // form is fully display
            {
                Pen pen = new Pen(Color.Lime, 1);

                //drawMiddleHLine()
                int y = cr.Y + cr.Height / 2;
                g.DrawLine(pen, new Point(cr.X, y), new Point(cr.X + cr.Width, y));

                //drawMiddleVLine()
                int x = cr.X + cr.Width / 2;
                g.DrawLine(pen, new Point(x, cr.Y), new Point(x, cr.Y + cr.Height));

                //drawHead()
                int marginL = (int)(cr.Width * 0.12); // left margin ( = right margin)
                int marginT = (int)(cr.Height * 0.07); // top margin ( *2 = bottom margin)
                g.DrawEllipse(pen, cr.X + marginL, cr.Y + marginT, cr.Width - 2 * marginL, cr.Height - 3 * marginT);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type != ScrollEventType.ThumbPosition)
            {
                pictureBox1.Invalidate();
            }
        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            pictureBox1.Invalidate();
        }

        public bool zoomIn(double aIncrementValue)
        {
            _ratioZoom = Math.Min(_ratioZoom + aIncrementValue, RATIO_MAX);
            pictureBox1.Image = _portrait.zoom(_ratioZoom);
            return (_ratioZoom < RATIO_MAX);
        }

        public bool zoomOut(double aDecrementValue)
        {
            _ratioZoom = Math.Max(_ratioZoom - aDecrementValue, 0.1d);
            pictureBox1.Image = _portrait.zoom(_ratioZoom);
            return (_ratioZoom > 0.1d);
        }

        public void save(string aFileNameSrc = "")
        {
            if (aFileNameSrc == string.Empty) aFileNameSrc = _pathImage;

            // REF : https://stackoverflow.com/questions/25086374/how-can-i-capture-as-bitmap-only-what-a-picturebox-is-displaying-without-using
            Bitmap bmp = getActualImage();
            string extension = string.Format("_{0}x{1}.jpg", bmp.Width, bmp.Height);
            string photoname = aFileNameSrc.Remove(aFileNameSrc.LastIndexOf(".")) + extension;
            getActualImage().Save(photoname, ImageFormat.Jpeg);
        }

        public Bitmap getActualImage()
        {
            bool backupIsMarked = IsMarked;
            IsMarked = false;

            int bmWidth = panel1.ClientSize.Width;
            int bmHeight = panel1.ClientSize.Height;
            Rectangle clientRect = panel1.ClientRectangle;
            if (!panel1.HorizontalScroll.Visible)
            {
                bmWidth -= SystemInformation.VerticalScrollBarWidth;
                clientRect.Width -= SystemInformation.VerticalScrollBarWidth;
            }
            if (!panel1.VerticalScroll.Visible)
            {
                bmHeight -= SystemInformation.HorizontalScrollBarHeight;
                clientRect.Height -= SystemInformation.VerticalScrollBarWidth;
            }
            // REF : https://stackoverflow.com/questions/25086374/how-can-i-capture-as-bitmap-only-what-a-picturebox-is-displaying-without-using
            Bitmap bmp = new Bitmap(bmWidth, bmHeight);         
            panel1.DrawToBitmap(bmp, clientRect);
            IsMarked = backupIsMarked;
            return bmp;
        }

        public Bitmap rotate(RotateFlipType aRotateFlipType)
        {
            Bitmap bm = _portrait.rotate(aRotateFlipType);
            pictureBox1.Image = bm;
            return bm;
        }

        private void UserPortrait_Resize(object sender, EventArgs e)
        {
            Width = _sizeMax.Width + _hBorder;
            Height = _sizeMax.Height + _vBorder;
            pictureBox1.Refresh();

            Rectangle r = panel1.ClientRectangle;
            Point pBottomRight = new Point(r.X + r.Width - _hBorder , r.Y + r.Height - _vBorder);
            pBottomRight.Offset(-2 * 32, -32);
            button5.Location = pBottomRight;
            pBottomRight.Offset(32, 0);
            buttonOk.Location = pBottomRight;
                
        }

        public void setSize35x45(int aWidth=350)
        {
            _sizeMax.Width = aWidth;
            _sizeMax.Height = (int)(aWidth / _ratioSize);
            UserPortrait_Resize(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomOut(0.1d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoomOut(0.01d);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zoomIn(0.01d);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zoomIn(0.1d);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rotate(RotateFlipType.Rotate270FlipXY);
        }


        // REF : https://stackoverflow.com/questions/7880850/how-do-i-make-an-event-in-the-usercontrol-and-have-it-handled-in-the-main-form
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user click Ok button (save)")]
        public event EventHandler ButtonOkClick;

        protected void buttonOk_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonOkClick != null)
                this.ButtonOkClick(this, e);
        }

    }
}
