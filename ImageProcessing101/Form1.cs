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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Filter = "jpeg File (*.jpg) |*.jpg| All File (*.*) |*.*";
            ofd.Title = "Open File";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            picOriginal.Load(ofd.FileName);
            txtOriginalSize.Text = $"{picOriginal.Image.Size.Width}x{picOriginal.Image.Size.Height}";
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.Filter = "jpeg File (*.jpg) |*.jpg| All File (*.*) |*.*";
            sfd.Title = "Save File";
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            picResult.Image.Save(sfd.FileName);
        }
    }
}
