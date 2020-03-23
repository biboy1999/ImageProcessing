using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
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


            //TODO: Refresh warpper

            //picOriginal.Load(ofd.FileName);
            //txtOriginalSize.Text = $"{picOriginal.Image.Size.Width}x{picOriginal.Image.Size.Height}";
            //txtOriginalSize.Left = picOriginal.Right - txtOriginalSize.Width;
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

            picResult.Image.Save(sfd.FileName);
        }
    }
}
