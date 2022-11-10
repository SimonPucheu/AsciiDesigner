using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog.FileName;
            }
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(textBoxFileName.Text))
                pictureBoxPreview.Image = Image.FromFile(textBoxFileName.Text);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "Working on it...";
            richTextBoxResult.Text = AsciiArt.ConvertImage(new StreamReader(textBoxFileName.Text).BaseStream, decimal.ToInt32(numericUpDownSize.Value), checkBoxQuick.Checked);
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            richTextBoxResult.Font = new Font(FontFamily.GenericMonospace, (float)numericUpDownFontSize.Value, FontStyle.Regular);
        }

        private void numericUpDownZoom_ValueChanged(object sender, EventArgs e)
        {
            richTextBoxResult.ZoomFactor = (float)numericUpDownZoom.Value;
        }
    }

    public class AsciiArt
    {
        public static string ConvertImage(Stream stream, int ImageSize, bool Quick)
        {
            StringBuilder _asciiart = new StringBuilder();

            #region load image
            Image _img = Image.FromStream(stream);
            Bitmap _image = new Bitmap(_img, _img.Size);
            _img.Dispose();


            Rectangle bounds = new Rectangle(0, 0, _image.Width, _image.Height);
            #endregion

            #region greyscale image
            ColorMatrix _matrix = new ColorMatrix();

            _matrix[0, 0] = 1 / 3f;
            _matrix[0, 1] = 1 / 3f;
            _matrix[0, 2] = 1 / 3f;
            _matrix[1, 0] = 1 / 3f;
            _matrix[1, 1] = 1 / 3f;
            _matrix[1, 2] = 1 / 3f;
            _matrix[2, 0] = 1 / 3f;
            _matrix[2, 1] = 1 / 3f;
            _matrix[2, 2] = 1 / 3f;

            ImageAttributes _attributes = new ImageAttributes();
            _attributes.SetColorMatrix(_matrix);


            Graphics gphGrey = Graphics.FromImage(_image);
            gphGrey.DrawImage(_image, bounds, 0, 0, _image.Width, _image.Height,
                GraphicsUnit.Pixel, _attributes);

            gphGrey.Dispose();
            #endregion

            #region ascii image

            int _pixwidth;

            switch (ImageSize)
            {
                case 1:
                    {
                        _pixwidth = 1;
                        break;
                    }
                case 2:
                    {
                        _pixwidth = 2;
                        break;
                    }
                case 4:
                    {
                        _pixwidth = 6;
                        break;
                    }
                case 5:
                    {
                        _pixwidth = 8;
                        break;
                    }
                default:
                    {
                        _pixwidth = 3;
                        break;
                    }
            }
            int _pixhight = _pixwidth * 2;
            int _pixseg = _pixwidth * _pixhight;

            for (int h = 0; h < _image.Height / _pixhight; h++)
            {
                // segment hight
                int _startY = (h * _pixhight);
                // segment width
                for (int w = 0; w < _image.Width / _pixwidth; w++)
                {
                    int _startX = (w * _pixwidth);
                    int _allBrightness = 0;

                    if (Quick)
                    {
                        // each pix of this segment
                        for (int y = 0; y < _pixwidth; y++)
                        {
                            try
                            {
                                Color _c = _image.GetPixel(_startX, y + _startY);
                                int _b = (int)(_c.GetBrightness() * 100);
                                _allBrightness = _allBrightness + _b;
                            }
                            catch
                            {
                                _allBrightness = (_allBrightness + 50);
                            }
                        }
                    }
                    else
                    {
                        // each pix of this segment
                        for (int y = 0; y < _pixwidth; y++)
                        {
                            for (int x = 0; x < _pixhight; x++)
                            {
                                int _cY = y + _startY;
                                int _cX = x + _startX;
                                try
                                {
                                    Color _c = _image.GetPixel(_cX, _cY);
                                    int _b = (int)(_c.GetBrightness() * 100);
                                    _allBrightness = _allBrightness + _b;
                                }
                                catch
                                {
                                    _allBrightness = (_allBrightness + 50);
                                }
                            }
                        }
                    }

                    int _sb = (_allBrightness / _pixseg);
                    if (_sb < 10)
                    {
                        _asciiart.Append("#");
                    }
                    else if (_sb < 17)
                    {
                        _asciiart.Append("@");
                    }
                    else if (_sb < 24)
                    {
                        _asciiart.Append("&");
                    }
                    else if (_sb < 31)
                    {
                        _asciiart.Append("$");
                    }
                    else if (_sb < 38)
                    {
                        _asciiart.Append("%");
                    }
                    else if (_sb < 45)
                    {
                        _asciiart.Append("|");
                    }
                    else if (_sb < 52)
                    {
                        _asciiart.Append("!");
                    }
                    else if (_sb < 59)
                    {
                        _asciiart.Append(";");
                    }
                    else if (_sb < 66)
                    {
                        _asciiart.Append(":");
                    }
                    else if (_sb < 73)
                    {
                        _asciiart.Append("'");
                    }
                    else if (_sb < 80)
                    {
                        _asciiart.Append("`");
                    }
                    else if (_sb < 87)
                    {
                        _asciiart.Append(".");
                    }
                    else
                    {
                        _asciiart.Append(" ");
                    }
                }
                _asciiart.Append("\n");
            }
            #endregion

            //clean up
            _image.Dispose();

            return _asciiart.ToString();
        }
    }
}
