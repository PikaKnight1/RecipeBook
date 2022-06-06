using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook48
{
    internal static class RecipeImages
    {
        public static Image LoadImageFromURL(string filePath, Size size)
        {
            Image finalImage = null;
            try
            {
                //get image
                var webImage = new WebClient().DownloadData(filePath);
                var streamImage = new MemoryStream(webImage);
                Image image = Image.FromStream(streamImage);

                //darken image
                Bitmap bmp = new Bitmap(image, size);
                Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
                int alpha = 128;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    using (Brush cloud_brush = new SolidBrush(Color.FromArgb(alpha, Color.Black)))
                    {
                        g.FillRectangle(cloud_brush, r);
                    }
                }
                finalImage = (Image)bmp;

            }
            catch
            {
                //if image won't load - skip showing tile
            }

            return finalImage;
        }

        public static bool TestImageURL(string filePath)
        {
            try
            {
                var webImage = new WebClient().DownloadData(filePath);
                var streamImage = new MemoryStream(webImage);
                Image image = Image.FromStream(streamImage);
                image.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
