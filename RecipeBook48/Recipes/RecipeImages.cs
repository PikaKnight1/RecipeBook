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
                var webImage = new WebClient().DownloadData(filePath);
                var streamImage = new MemoryStream(webImage);
                Image image = Image.FromStream(streamImage);
                finalImage = (Image)(new Bitmap(image, size));
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
