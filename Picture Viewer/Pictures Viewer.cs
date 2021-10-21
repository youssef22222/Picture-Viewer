using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Picture_Viewer
{
   
    public partial class Pictures_Viewer : Form
    {

        List<string> picturesPathes = new List<string>();
        public Pictures_Viewer()
        {
            InitializeComponent();
        }

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            //ofd.InitialDirectory = "D:\\Programes\\wallpapers";
            ofd.Title = "Select some images!";
            ofd.Multiselect = true;
            ofd.Filter = "Picture|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
          
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                picturesListBox.Visible = true;

                foreach (string s in ofd.FileNames)
                {
                    if (!picturesListBox.Items.Contains(Path.GetFileName(s)))
                    {
                        picturesListBox.Items.Add(Path.GetFileName(s));
                        picturesPathes.Add(s);
                    }
                }
              
                //btnShowSinglePicture.Visible = true;
                //btnShowMultiPicture.Visible = true;
                //btnSlideShow.Visible = true;
                textBox1.Visible = false;

                contextMenuStrip1.Items.Clear();
                contextMenuStrip1.Items.Add(addPicturesToolStripMenuItem);
                contextMenuStrip1.Items.Add(showSinglePictureToolStripMenuItem);
                contextMenuStrip1.Items.Add(showMultiPictureToolStripMenuItem);
                contextMenuStrip1.Items.Add(slideShowToolStripMenuItem);
                contextMenuStrip1.Items.Add(exitToolStripMenuItem);
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ContextMenuStrip = contextMenuStrip1;


            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add(addPicturesToolStripMenuItem);
            contextMenuStrip1.Items.Add(exitToolStripMenuItem);

            textBox1.ReadOnly = false;
            textBox1.Enabled = false;
           

            picturesListBox.Visible = false;
            btnAddPictures.Visible = false;
            btnShowSinglePicture.Visible = false;
            btnShowMultiPicture.Visible = false;
            btnSlideShow.Visible = false;
            btnBack.Visible = false;
            picBoxSinglePic.Visible = false;
            statusStrip1.Visible = false;
            this.components.Add(contextMenuStrip1);
            picturesListBox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnShowSinglePicture_Click(object sender, EventArgs e)
        {
            if(picturesListBox.SelectedItems.Count!=1)
            {
                picturesListBox.SelectedItems.Clear();

                MessageBox.Show("Please select one photo!");
                //toolTip.SetToolTip(btnShowSinglePicture,"Please select one photo!");

            }
            else
            {
                btnBack.Top = 288;
                toolTip.SetToolTip(btnShowSinglePicture,null);
                btnAddPictures.Visible = false;
                btnShowSinglePicture.Visible = false;
                btnShowMultiPicture.Visible = false;
                btnSlideShow.Visible = false;
                picturesListBox.Visible = false;
               // btnBack.Visible = true;
                picBoxSinglePic.Visible = true;

                int picpath = picturesListBox.SelectedIndex;
                try
                {
                    picBoxSinglePic.Image = Image.FromFile(picturesPathes[picpath]);

                }
                catch(Exception error)
                {
                    MessageBox.Show("Error may be The selected picture was removed from its path \n or renamed call program developer +201113885845");
                }
                statusStrip1.Visible = true;
                statusBar.Text = picturesListBox.SelectedItem.ToString();
                

                contextMenuStrip1.Items.Clear();
                contextMenuStrip1.Items.Add(backToolStripMenuItem);
                contextMenuStrip1.Items.Add(exitToolStripMenuItem);
            }
          


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Control co in this.Controls)
            {
                co.Visible = false;
            }
            //btnAddPictures.Visible = true;
            //btnShowSinglePicture.Visible = true;
            //btnShowMultiPicture.Visible = true;
            //btnSlideShow.Visible = true;
            picturesListBox.Visible = true;
            label1.Visible = true;
            timer.Stop();

            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add(addPicturesToolStripMenuItem);
            contextMenuStrip1.Items.Add(showSinglePictureToolStripMenuItem);
            contextMenuStrip1.Items.Add(showMultiPictureToolStripMenuItem);
            contextMenuStrip1.Items.Add(slideShowToolStripMenuItem);
            contextMenuStrip1.Items.Add(exitToolStripMenuItem);

        }

        private void btnSlideShow_Click(object sender, EventArgs e)
        {
            if(picturesListBox.Items.Count!=0)
            {
                picturesListBox.SelectedItems.Clear();
                btnBack.Top = 288;
                btnAddPictures.Visible = false;
                btnShowSinglePicture.Visible = false;
                btnShowMultiPicture.Visible = false;
                btnSlideShow.Visible = false;
                picturesListBox.Visible = false;
                //btnBack.Visible = true;
                picBoxSinglePic.Visible = true;

                contextMenuStrip1.Items.Clear();
                contextMenuStrip1.Items.Add(backToolStripMenuItem);
                contextMenuStrip1.Items.Add(exitToolStripMenuItem);
                statusStrip1.Visible = true;
                timer.Enabled = true;

                

            }

        }
        int i = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
           
            if (i == picturesListBox.Items.Count)
                i = 0;
            try
            {
                picBoxSinglePic.Image = Image.FromFile(picturesPathes[i]);
            }
               
             catch (Exception error)
            {
                timer.Stop();
                MessageBox.Show("Error may be a picture was removed from its path \n or renamed call program developer +201113885845");
            }
            statusBar.Text = picturesListBox.Items[i].ToString();
            i++;
         
        }

        private void btnShowMultiPicture_Click(object sender, EventArgs e)
        {
            if (picturesListBox.SelectedItems.Count ==0)
            {
                MessageBox.Show("Please select one or more photos!");

                // toolTip.SetToolTip(btnShowMultiPicture, "Please select one or more photos!");

            }
            else
            {
                btnAddPictures.Visible = false;
                btnShowSinglePicture.Visible = false;
                btnShowMultiPicture.Visible = false;
                btnSlideShow.Visible = false;
                picturesListBox.Visible = false;
                // btnBack.Visible = true;
               


                contextMenuStrip1.Items.Clear();
                contextMenuStrip1.Items.Add(backToolStripMenuItem);
                contextMenuStrip1.Items.Add(exitToolStripMenuItem);

                int top = 60,left=40;
                int picturesNumber = picturesListBox.SelectedItems.Count;
                int boxs = (int)Math.Ceiling(Math.Sqrt(picturesNumber));
                int picWidth = 600 / boxs;
                int picHeight = 300 / boxs;
                int counter = 1;
                for (int selectedPic = 0; selectedPic < picturesListBox.Items.Count; selectedPic++)
                {
                    PictureBox picBox = new PictureBox();
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.SetBounds(left,top,picWidth,picHeight);

                     if(picturesListBox.GetSelected(selectedPic)==true)
                    {
                        try
                        {
                            picBox.Image = Image.FromFile(picturesPathes[selectedPic]);

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error may be a selected picture was removed from its path \n or renamed call program developer +201113885845");
                        }
                        this.Controls.Add(picBox);
                        left += (picWidth+5);
                        if (counter % boxs == 0)
                        {
                            top += (picHeight+ 5);
                            left = 40;
                        }

                        counter++;
                    }
                    
                }
                    btnBack.Top = top+105 + 20;
                if (counter % 4 == 1)
                    btnBack.Top -= 105;
                    
            }
          
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
