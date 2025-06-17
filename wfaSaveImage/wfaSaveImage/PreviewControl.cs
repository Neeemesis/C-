using List;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using wfaSaveImage;
using static System.Net.Mime.MediaTypeNames;
using static wfaSaveImage.Form1;

namespace ImageConverter
{
    public partial class PreviewControl : UserControl
    {
        private double _zoom1 = 0.2;
        private Bitmap _image;

        public int Zoom { get; private set; } = 100;
        private Point StartPoint;
        public PreviewControl()
        {
            InitializeComponent();
            //зум одной картинки
            pbImage.MouseMove += PbImage_MouseMove;
            pbImage.MouseWheel += PbImage_MouseWheel1;



            //перемещение
            //pbImage.MouseDown += PbImage_MouseDown;
            //pbImage.MouseMove += PbImage_MouseMove;
            //pbImage.MouseUp += PbImage_MouseUp;

        }

        //перемещение
        //private bool _isDragging = false;
        //private Point _lastLocation;

        //private void PbImage_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        //_isDragging = true;
        //        //_lastLocation = e.Location;
        //        pbImage.Tag = new { X = e.X, Y = e.Y };
        //    }
        //}

        //private void PbImage_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //if (_isDragging)
        //    //{
        //    //    int deltaX = e.Location.X - _lastLocation.X;
        //    //    int deltaY = e.Location.Y - _lastLocation.Y;

        //    //    pbImage.Location = new Point(pbImage.Location.X + deltaX, pbImage.Location.Y + deltaY);
        //    //}

        //    if (pbImage.Tag != null)
        //    {
        //        dynamic offset = pbImage.Tag;
        //        pbImage.Left += e.X - offset.X;
        //        pbImage.Top += e.Y - offset.Y;
        //    }
        //}

        //private void PbImage_MouseUp(object sender, MouseEventArgs e)
        //{
        //    //_isDragging = false;
        //    pbImage.Tag = null;
        //}

        //одна картинка зум + перемещение
        public void PbImage_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(pbImage.Image,
                new Rectangle(0, 0, pbImage.Image.Width, pbImage.Image.Height),
                new Rectangle(StartPoint.X - Zoom, StartPoint.Y - Zoom, Zoom * 2, Zoom * 2),
                GraphicsUnit.Pixel);

            //Form1 form1 = new();
            //form1.ZoomPo(StartPoint, Zoom, e);
        }
        private void PbImage_MouseWheel1(object? sender, MouseEventArgs e)
        {
            pbImage.Paint += PbImage_Paint;
            Zoom += e.Delta > 0 ? 10 : -10;
            pbImage.Invalidate();
        }

        private void PbImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (pbImage.SizeMode == PictureBoxSizeMode.Zoom)
            {
                StartPoint.X = e.X * pbImage.Image.Width / pbImage.Width;
                StartPoint.Y = e.Y * pbImage.Image.Height / pbImage.Height;
            }
            else
            {
                StartPoint = e.Location;
            }
            pbImage.Invalidate();
        }


        //internal void Bind(System.Drawing.Image image, string quality, long size)
        //{
        //    listBox1.Text = quality;
        //    pbImage.Image = image;
        //    lbSize.Text = "Размер: " + size + " байт";

        //    Render();
        //}
        internal void Bind(System.Drawing.Image image, string quality, long size)
        {
            listBox1.Text = quality;
            _image = (Bitmap)image;
            lbSize.Text = "Размер: " + size + " байт";

            Render();
        }

        //public Bitmap Image => pbImage.Image as Bitmap;
        public Bitmap Image => _image;

        void Render()
        {
            var img = new Bitmap(
                _image,
                (int)(_image.Width * _zoom1),
                (int)(_image.Height * _zoom1));

            if (pbImage.Image != null)
            {
                pbImage.Image.Dispose();
            }

            pbImage.Image = img;
        }
        public void ZoomIn()
        {
            _zoom1 = _zoom1 * 2;
            if (_zoom1 > 2)
            {
                _zoom1 = 2;
            }

            Render();
        }

        public void ZoomOut()
        {
            _zoom1 = _zoom1 * 0.5;
            if (_zoom1 < 0.1)
            {
                _zoom1 = 0.1;
            }

            Render();
        }

    }
}
