using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing101.algorithm
{
    public static class Histogram
    {
        public static Tuple<int[], int[], int[]> Generate(Bitmap bitmap)
        {
            int[] R = new int[256];
            int[] G = new int[256];
            int[] B = new int[256];

            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmd = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int PixelSize = 4;
            unsafe
            {
                for (int y = 0; y < bmd.Height; y++)
                {
                    byte* row = (byte*)bmd.Scan0 + (y * bmd.Stride);
                    for (int x = 0; x < bmd.Width; x++)
                    {
                        int blue = row[x * PixelSize + 0];
                        int green = row[x * PixelSize + 1];
                        int red = row[x * PixelSize + 2];
                        //int alpha = row[x * PixelSize + 3];
                        R[red]++;
                        G[green]++;
                        B[blue]++;
                    }
                }
            }
            bitmap.UnlockBits(bmd);

            return new Tuple<int[], int[], int[]>(R, G, B);
        }
    }
}
