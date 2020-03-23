using ImageProcessing101.algorithm;
using ImageProcessing101.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessing101.controls
{
    public partial class PictureViewer : UserControl
    {
        public PictureViewer()
        {
            InitializeComponent();
        }
        public string Title { get => lbTitle.Text; set => lbTitle.Text = value; }
        public Image Image
        {
            get => picView.Image;
            set
            {
                picView.Image = value;
                if (value != null)
                {
                    lbSize.Text = $"{value.Width}x{value.Height}";
                    lbSize.Left = picView.Right - lbSize.Width;
                }
            }
        }
        private void ViewComparer_Load(object sender, EventArgs e)
        {
            foreach (var item in Controls.OfType<Chart>())
            {
                item.Series[0].Points.Clear();
            }
        }
        public async Task GrayBandView()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var set = await Task.Run(() => Graycale.Band(new Bitmap(picView.Image)));
            picR.Image = set.Item1;
            picG.Image = set.Item2;
            picB.Image = set.Item3;

            sw.Stop();
            Logger.Log($"[{Title}] Gray band Loaded {sw.ElapsedMilliseconds.ToString()} ms");
        }

        public async Task HistogramView()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var set = await Task.Run(() => Histogram.Generate(new Bitmap(picView.Image)));
            chartR.Series[0].Points.Clear();
            chartG.Series[0].Points.Clear();
            chartB.Series[0].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chartR.Series[0].Points.AddXY(i, set.Item1[i]);
                chartG.Series[0].Points.AddXY(i, set.Item2[i]);
                chartB.Series[0].Points.AddXY(i, set.Item3[i]);
            }

            sw.Stop();

            Logger.Log($"[{Title}] Gray band Loaded {sw.ElapsedMilliseconds.ToString()} ms");
        }
    }
}
