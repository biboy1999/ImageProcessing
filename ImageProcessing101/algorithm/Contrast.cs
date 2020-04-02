using ImageProcessing101.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing101.algorithm
{
    public static class Contrast
    {
        public static Bitmap Logarithmic(Bitmap image, int C)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap result = new Bitmap(image);
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    Color pixelColor = result.GetPixel(x, y);
                    int R = (int)Math.Round(C * Math.Log(pixelColor.R + 1));
                    int G = (int)Math.Round(C * Math.Log(pixelColor.G + 1));
                    int B = (int)Math.Round(C * Math.Log(pixelColor.B + 1));
                    result.SetPixel(x, y, Color.FromArgb(pixelColor.A, R, G, B));
                }
            }

            sw.Stop();
            Logger.Log($"[ImageProcess] Contrast Logarithmic {sw.ElapsedMilliseconds.ToString()} ms");
            return result;
        }

        public static Bitmap Negative(Bitmap image)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap result = new Bitmap(image);
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    Color pixelColor = result.GetPixel(x, y);
                    int R = 255 - pixelColor.R;
                    int G = 255 - pixelColor.G;
                    int B = 255 - pixelColor.B;
                    result.SetPixel(x, y, Color.FromArgb(pixelColor.A, R, G, B));
                }
            }

            sw.Stop();
            Logger.Log($"[ImageProcess] Contrast Negative {sw.ElapsedMilliseconds.ToString()} ms");
            return result;
        }
    }
}
