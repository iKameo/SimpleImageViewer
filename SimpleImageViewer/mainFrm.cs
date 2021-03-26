using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleImageViewer
{
    public partial class mainFrm : Form
    {
        public static string picturePath;
        public mainFrm()
        {
            InitializeComponent();
        }
        private void mainFrm_Load(object sender, EventArgs e)
        {
            pb_mainView.AllowDrop = true;
            this.MinimumSize = new Size(250, 250);
            ts_sizeMode.Alignment = ToolStripItemAlignment.Right;
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1 && args[1] != string.Empty)
            {              
                if (args == null || args.Length == 0)
                {
                    //MessageBox.Show("args.Length == 0");
                }
                else
                {                    
                    //MessageBox.Show("args.Length == 1");
                    pb_mainView.ImageLocation = args[1];
                    stlbl_path.Text = args[1];
                }
                
            }
            
        }

        private void pb_mainView_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb_mainView = sender as PictureBox;
            pb_mainView.DoDragDrop(pb_mainView.Image, DragDropEffects.All);
        }

        private void pb_mainView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pb_mainView_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                try
                {
                    Image img = Image.FromFile(pic);
                    pb_mainView.Image = img;
                    pb_mainView.Tag = pic;
                    stlbl_path.Text = pic;
                }
                catch
                {
                    MessageBox.Show("Thats not an Image you dummy.");
                }                
            }
            GC.Collect();
        }
              
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    stlbl_path.Text = dlg.FileName;
                    pb_mainView.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturePath = stlbl_path.Text;
            analyzeFrm af = new analyzeFrm();
            af.ShowDialog();

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_mainView.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_mainView.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void strechImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_mainView.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_mainView.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_mainView.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ts_Delete_Click(object sender, EventArgs e)
        {
            pb_mainView.Image = null;
            pb_mainView.Dispose();
            System.Threading.Thread.Sleep(2000);
            File.Delete(stlbl_path.Text);
        }

        private void ts_Rotate_left_Click(object sender, EventArgs e)
        {
            Image turnImage = pb_mainView.Image;
            turnImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pb_mainView.Image = turnImage;
        }          


    }
}
