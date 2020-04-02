using ImageProcessing101.algorithm;
using ImageProcessing101.utils;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing101
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public ImageState state;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Logger.LogBox = txtLogCat;
        }

        private async void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                RestoreDirectory = true,
                Filter = "Image File (*.jpg,*.bmp) |*.jpg;*.bmp| All File (*.*) |*.*",
                Title = "Open File",
                Multiselect = false
            };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Text = $"Image Processing - {ofd.FileName}";

            state = await Task.Run(() => new ImageState(new Bitmap(ofd.FileName)));

            pictureViewer1.Image = state.Image;
            pictureViewer2.Image = state.Image;

            await pictureViewer1.HistogramView();
            await pictureViewer1.GrayBandView();

            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                RestoreDirectory = true,
                Filter = "jpeg File (*.jpg) |*.jpg| All File (*.*) |*.*",
                Title = "Save File"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            state.Image.Save(sfd.FileName);
        }

        private async void btnGrayMeanWeight_Click(object sender, EventArgs e)
        {
            btnGrayMeanWeight.Enabled = false;
            Bitmap result = await Task.Run(() => Graycale.Weight(state.Image));
            state.Edit(result);
            pictureViewer2.Image = state.Image;
            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();
            btnGrayMeanWeight.Enabled = true;
        }

        private async void btnGrayMeanValue_Click(object sender, EventArgs e)
        {
            btnGrayMeanValue.Enabled = false;
            Bitmap result = await Task.Run(() => Graycale.Mean(state.Image));
            state.Edit(result);
            pictureViewer2.Image = state.Image;
            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();
            btnGrayMeanValue.Enabled = true;
        }

        private async void btnGrayMaxium_Click(object sender, EventArgs e)
        {
            btnGrayMax.Enabled = false;
            Bitmap resutImg = await Task.Run(() => Graycale.Max(state.Image));
            state.Edit(resutImg);
            pictureViewer2.Image = state.Image;
            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();
            btnGrayMax.Enabled = true;
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            txtLogCat.Text = "";
        }

        private async void btnUndo_Click(object sender, EventArgs e)
        {
            state.Undo();
            pictureViewer2.Image = state.Image;
            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();
        }

        private async void btnLagarithmic_Click(object sender, EventArgs e)
        {
            btnLagarithmic.Enabled = false;
            Bitmap resultImg = await Task.Run(() => Contrast.Logarithmic(state.Image, 40));
            state.Edit(resultImg);
            pictureViewer2.Image = state.Image;
            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();
            btnLagarithmic.Enabled = true;
        }

        private async void btnNegative_Click(object sender, EventArgs e)
        {
            btnNegative.Enabled = false;
            Bitmap resultImg = await Task.Run(() => Contrast.Negative(state.Image));
            state.Edit(resultImg);
            pictureViewer2.Image = state.Image;
            await pictureViewer2.HistogramView();
            await pictureViewer2.GrayBandView();
            btnNegative.Enabled = true;
        }
    }
}
