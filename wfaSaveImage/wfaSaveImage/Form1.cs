using ImageConverter;
using List;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static wfaSaveImage.Form1;

namespace wfaSaveImage
{
    public partial class Form1 : Form
    {
        int pictureBoxCount = 0;
        private Bitmap Image;
        const string QualityPattern = "JPEG {0} %";

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(new Quality(QualityPattern, 0));
            for (int i = 10; i <= 100; i += 5)
            {
                listBox1.Items.Add(new Quality(QualityPattern, i));
            }
        }

        //    foreach (var control in flowLayoutPanel1.Controls.Cast<PreviewControl>())
        //    {
        //        //PreviewControl.PbImage_Paint(control, e);
        //        //Graphics q = control.Image;
        //        e.Graphics.DrawImage(control.Image,
        //       new Rectangle(0, 0, control.Image.Width, control.Image.Height),
        //       new Rectangle(StartPoint.X - Zoom, StartPoint.Y - Zoom, Zoom * 2, Zoom * 2),
        //       GraphicsUnit.Pixel);
        //        control.Width += 1;

        //    }
        //} 

        private void buOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP; *.JPG; *.PNG)|*.BMP; *.JPG; *.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image = Bitmap.FromFile(ofd.FileName) as Bitmap;
                    UpdateImagesList();

                    int imageWidth = Image.Width;
                    ImageWidth.Text = imageWidth.ToString();
                    int imageHeight = Image.Height;
                    ImageHeight.Text = imageHeight.ToString();
                    System.Drawing.Imaging.ImageFormat format = Image.RawFormat;
                    ImageFormat.Text = format.ToString();

                    long imageSize = 0;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image.Save(ms, Image.RawFormat);
                        imageSize = ms.Length;
                    }
                    ImageSize.Text = imageSize.ToString() + " байт";

                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }


        //качество
        private void ParseImage(Bitmap img, IEnumerable<Quality> qualities, bool checkDiag, bool checkLines)
        {
            flowLayoutPanel1.Controls.Clear();

            if (img == null)
            {
                return;
            }

            // для каждого требуемого качества 
            foreach (var quality in qualities)
            {
                long size;
                Bitmap bitmap = ConvertBitmapToJpeg(img, quality.Value, out size);
                if (checkDiag)
                {
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        Pen pen = new Pen(Color.Black, 2);
                        g.DrawLine(pen, 0, 0, bitmap.Width, bitmap.Height);
                        g.DrawLine(pen, 0, bitmap.Height, bitmap.Width, 0);
                    }
                }
                if (checkLines)
                {
                    const int step = 10;
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        for (int i = 0; i < bitmap.Height / step; i++)
                        {
                            g.DrawLine(Pens.Black, 0, i * step, bitmap.Width - 1, i * step);
                        }

                        for (int i = 0; i < bitmap.Width / step; i++)
                        {
                            g.DrawLine(Pens.Black, i * step, 0, i * step, bitmap.Height - 1);
                        }
                    }
                }
                PreviewControl pc = new PreviewControl();
                pc.Bind(bitmap, quality.ToString(), size);
                flowLayoutPanel1.Controls.Add(pc);

                //PictureBox pic = new PictureBox();
                //pic.Image = bitmap;
                //pic.Width = 8;
                //pic.Height = 300;
                //pic.Location = new Point(0, pic.Location.Y + 10);
                //flowLayoutPanel1.Controls.Add(pic);
                //PreviewControl.AttachZoomHandler(pic);
                //PictureBoxes.Add(pc);

                //PreviewControl.ZoomChanged += PreviewControl_ZoomChanged;

            }
            //ZoomManager.ZoomChanged += ZoomManager_ZoomChanged;
        }

        //private void ZoomManager_ZoomChanged(object sender, int newZoom)
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is PreviewControl pc)
        //        {
        //            PreviewControl.Zoom = newZoom;
        //            pc.Invalidate();
        //        }
        //    }
        //}

        public Bitmap ConvertBitmapToJpeg(Bitmap sourceBitmap, long quality, out long size)
        {
            EncoderParameters encoderParameters = new EncoderParameters(1);
            EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, quality);
            encoderParameters.Param[0] = encoderParameter;

            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

            if (jpegCodec == null)
            {
                throw new InvalidOperationException("JPEG codec not found");
            }

            MemoryStream stream = new MemoryStream();
            sourceBitmap.Save(stream, jpegCodec, encoderParameters);
            Bitmap resultBitmap = new Bitmap(stream);
            size = stream.Length;

            return resultBitmap;
        }
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            for (int i = 0; i < codecs.Length; i++)
            {
                if (codecs[i].MimeType == mimeType)
                {
                    return codecs[i];
                }
            }
            return null;
        }
        private void UpdateImagesList()
        {
            ParseImage(Image, listBox1.SelectedItems.Cast<Quality>(), checkBoxDiagonals.Checked, checkBoxLines.Checked);
        }
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateImagesList();
        }

        private void PictureBox_RightClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Bitmap clickedPictureBox = (Bitmap)sender;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP| Image Files(*.JPG)|*.JPG| Image Files(*.PNG)|*.PNG| All fiels(*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        clickedPictureBox.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void buSave_Click(object sender, EventArgs e)
        {
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

            foreach (var control in flowLayoutPanel1.Controls.Cast<PreviewControl>())
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP| Image Files(*.JPG)|*.JPG| Image Files(*.PNG)|*.PNG| All fiels(*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        control.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void checkBoxDiagonals_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImagesList();
        }

        private void checkBoxLines_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImagesList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var control in flowLayoutPanel1.Controls.Cast<PreviewControl>())
            {

                control.ZoomIn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var control in flowLayoutPanel1.Controls.Cast<PreviewControl>())
            {

                control.ZoomOut();
            }
        }
    }
}
