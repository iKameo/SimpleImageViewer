using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleImageViewer
{
    public partial class analyzeFrm : Form
    {
        
        public analyzeFrm()
        {
            InitializeComponent();
        }

        private void analyzeFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(mainFrm.picturePath))
                    throw new FileNotFoundException();

                Image img = Image.FromFile(@mainFrm.picturePath);
                double length = new System.IO.FileInfo(mainFrm.picturePath).Length / 1000;
                string fileNameFromPath = mainFrm.picturePath;
                DateTime creation = File.GetCreationTime(@mainFrm.picturePath);
                DateTime modification = File.GetLastWriteTime(@mainFrm.picturePath);



                //Setup the Listview
                ListViewGroup categoryPicture = new ListViewGroup("Picture", HorizontalAlignment.Left);
                ListViewGroup categoryFile = new ListViewGroup("File", HorizontalAlignment.Left);
                lv_Values.Groups.Add(categoryPicture);
                lv_Values.Groups.Add(categoryFile);
                //Picture
                lv_Values.Items.Add(new ListViewItem() { Text = "Dimensions", Group = categoryPicture });
                lv_Values.Items.Add(new ListViewItem() { Text = "Width", Group = categoryPicture });
                lv_Values.Items.Add(new ListViewItem() { Text = "Height", Group = categoryPicture });
                lv_Values.Items.Add(new ListViewItem() { Text = "Depth", Group = categoryPicture });
                lv_Values.Items[0].SubItems.Add(img.Width + "x" + img.Height);
                lv_Values.Items[1].SubItems.Add(img.Width + " Pixel");
                lv_Values.Items[2].SubItems.Add(img.Height + " Pixel");
                lv_Values.Items[3].SubItems.Add(img.PixelFormat.ToString());
                //File
                lv_Values.Items.Add(new ListViewItem() { Text = "Name", Group = categoryFile });
                lv_Values.Items.Add(new ListViewItem() { Text = "Type", Group = categoryFile });
                lv_Values.Items.Add(new ListViewItem() { Text = "Path", Group = categoryFile });
                lv_Values.Items.Add(new ListViewItem() { Text = "Creation", Group = categoryFile });
                lv_Values.Items.Add(new ListViewItem() { Text = "Changed", Group = categoryFile });
                lv_Values.Items.Add(new ListViewItem() { Text = "Size", Group = categoryFile });
                lv_Values.Items[4].SubItems.Add(Path.GetFileName(fileNameFromPath));
                lv_Values.Items[5].SubItems.Add(Path.GetExtension(fileNameFromPath));
                lv_Values.Items[6].SubItems.Add(mainFrm.picturePath);
                lv_Values.Items[7].SubItems.Add(creation + "");
                lv_Values.Items[8].SubItems.Add(modification + "");
                lv_Values.Items[9].SubItems.Add(length + " KB");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("You need to choose a picture!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            


        }

        
    }
}
