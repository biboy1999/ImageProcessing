using ImageProcessing101.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing101
{
    public static class Graycale
    {
        public static Bitmap Max(Bitmap image)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap temp = new Bitmap(image);
            for (int y = 0; y < temp.Height; y++)
            {
                for (int x = 0; x < temp.Width; x++)
                {
                    int max = new int[] { temp.GetPixel(x, y).R, temp.GetPixel(x, y).G, temp.GetPixel(x, y).B }.Max();
                    temp.SetPixel(x, y, Color.FromArgb(max, max, max));
                }
            }
            sw.Stop();
            Logger.Log($"[ImageProcess] Grayscale Max {sw.ElapsedMilliseconds.ToString()} ms");

            return temp;
        }

        public static Bitmap Mean(Bitmap image)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap result = new Bitmap(image);
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    Color pixelColor = result.GetPixel(x, y);
                    int meanNum = (int)Math.Round(new int[] { pixelColor.R, pixelColor.G, pixelColor.B }.Average());
                    result.SetPixel(x, y, Color.FromArgb(meanNum, meanNum, meanNum));
                }
            }

            sw.Stop();
            Logger.Log($"[ImageProcess] Grayscale Mean {sw.ElapsedMilliseconds.ToString()} ms");

            return result;
        }

        public static Bitmap Weight(Bitmap image)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap result = new Bitmap(image);
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    Color pixelColor = result.GetPixel(x, y);
                    int weighted = (int)Math.Round(pixelColor.R * 0.299 + pixelColor.G * 0.587 + pixelColor.B * 0.114);
                    result.SetPixel(x, y, Color.FromArgb(weighted, weighted, weighted));
                }
            }

            sw.Stop();
            Logger.Log($"[ImageProcess] Grayscale Weight {sw.ElapsedMilliseconds.ToString()} ms");

            return result;
        }

        public static Tuple<Bitmap, Bitmap, Bitmap> Band(Bitmap _image)
        {
            Bitmap bandR = new Bitmap(_image.Size.Width, _image.Size.Height, PixelFormat.Format32bppArgb);
            Bitmap bandG = new Bitmap(_image.Size.Width, _image.Size.Height, PixelFormat.Format32bppArgb);
            Bitmap bandB = new Bitmap(_image.Size.Width, _image.Size.Height, PixelFormat.Format32bppArgb);

            BitmapData inputBmd = _image.LockBits(new Rectangle(0, 0, _image.Width, _image.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData RBmd = bandR.LockBits(new Rectangle(0, 0, bandR.Width, bandR.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData GBmd = bandG.LockBits(new Rectangle(0, 0, bandG.Width, bandG.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData BBmd = bandB.LockBits(new Rectangle(0, 0, bandB.Width, bandB.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int PixelSize = 4;
            unsafe
            {
                for (int y = 0; y < inputBmd.Height; y++)
                {
                    byte* row = (byte*)inputBmd.Scan0 + (y * inputBmd.Stride);
                    byte* rowR = (byte*)RBmd.Scan0 + (y * RBmd.Stride);
                    byte* rowG = (byte*)GBmd.Scan0 + (y * GBmd.Stride);
                    byte* rowB = (byte*)BBmd.Scan0 + (y * BBmd.Stride);
                    for (int x = 0; x < inputBmd.Width; x++)
                    {
                        byte blue = row[x * PixelSize + 0];
                        byte green = row[x * PixelSize + 1];
                        byte red = row[x * PixelSize + 2];
                        byte alpha = row[x * PixelSize + 3];
                        for (int i = 0; i < 4; i++)
                        {
                            if (i != 3)
                            {
                                rowR[x * PixelSize + i] = red;
                                rowG[x * PixelSize + i] = green;
                                rowB[x * PixelSize + i] = blue;
                            }
                            else
                            {
                                rowR[x * PixelSize + i] = alpha;
                                rowG[x * PixelSize + i] = alpha;
                                rowB[x * PixelSize + i] = alpha;
                            }
                        }

                    }
                }
            }
            bandR.UnlockBits(RBmd);
            bandG.UnlockBits(GBmd);
            bandB.UnlockBits(BBmd);
            _image.UnlockBits(inputBmd);

            return new Tuple<Bitmap, Bitmap, Bitmap>(bandR, bandG, bandB);
        }
    }
}
