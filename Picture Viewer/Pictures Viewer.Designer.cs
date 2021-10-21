
namespace Picture_Viewer
{
    partial class Pictures_Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pictures_Viewer));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnAddPictures = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picturesListBox = new System.Windows.Forms.ListBox();
            this.btnShowMultiPicture = new System.Windows.Forms.Button();
            this.btnSlideShow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.picBoxSinglePic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSinglePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMultiPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowSinglePicture = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSinglePic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 20;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnAddPictures
            // 
            this.btnAddPictures.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddPictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPictures.Location = new System.Drawing.Point(242, 111);
            this.btnAddPictures.Name = "btnAddPictures";
            this.btnAddPictures.Size = new System.Drawing.Size(197, 37);
            this.btnAddPictures.TabIndex = 0;
            this.btnAddPictures.Text = "Add Pictures";
            this.btnAddPictures.UseVisualStyleBackColor = false;
            this.btnAddPictures.Click += new System.EventHandler(this.btnAddImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pictures Viewer";
            // 
            // picturesListBox
            // 
            this.picturesListBox.FormattingEnabled = true;
            this.picturesListBox.ItemHeight = 24;
            this.picturesListBox.Location = new System.Drawing.Point(185, 63);
            this.picturesListBox.Name = "picturesListBox";
            this.picturesListBox.Size = new System.Drawing.Size(306, 292);
            this.picturesListBox.TabIndex = 2;
            // 
            // btnShowMultiPicture
            // 
            this.btnShowMultiPicture.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnShowMultiPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMultiPicture.Location = new System.Drawing.Point(250, 97);
            this.btnShowMultiPicture.Name = "btnShowMultiPicture";
            this.btnShowMultiPicture.Size = new System.Drawing.Size(185, 37);
            this.btnShowMultiPicture.TabIndex = 4;
            this.btnShowMultiPicture.Text = "Show Multi-Picture";
            this.btnShowMultiPicture.UseVisualStyleBackColor = false;
            this.btnShowMultiPicture.Click += new System.EventHandler(this.btnShowMultiPicture_Click);
            // 
            // btnSlideShow
            // 
            this.btnSlideShow.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSlideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlideShow.Location = new System.Drawing.Point(263, 97);
            this.btnSlideShow.Name = "btnSlideShow";
            this.btnSlideShow.Size = new System.Drawing.Size(144, 37);
            this.btnSlideShow.TabIndex = 5;
            this.btnSlideShow.Text = "Slide Show";
            this.btnSlideShow.UseVisualStyleBackColor = false;
            this.btnSlideShow.Click += new System.EventHandler(this.btnSlideShow_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(242, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 8;
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // picBoxSinglePic
            // 
            this.picBoxSinglePic.Location = new System.Drawing.Point(78, 43);
            this.picBoxSinglePic.Name = "picBoxSinglePic";
            this.picBoxSinglePic.Size = new System.Drawing.Size(522, 312);
            this.picBoxSinglePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSinglePic.TabIndex = 9;
            this.picBoxSinglePic.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPicturesToolStripMenuItem,
            this.showSinglePictureToolStripMenuItem,
            this.showMultiPictureToolStripMenuItem,
            this.slideShowToolStripMenuItem,
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 136);
            // 
            // addPicturesToolStripMenuItem
            // 
            this.addPicturesToolStripMenuItem.Name = "addPicturesToolStripMenuItem";
            this.addPicturesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addPicturesToolStripMenuItem.Text = "Add Pictures";
            this.addPicturesToolStripMenuItem.Click += new System.EventHandler(this.btnAddImages_Click);
            // 
            // showSinglePictureToolStripMenuItem
            // 
            this.showSinglePictureToolStripMenuItem.Name = "showSinglePictureToolStripMenuItem";
            this.showSinglePictureToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.showSinglePictureToolStripMenuItem.Text = "Show Single Picture";
            this.showSinglePictureToolStripMenuItem.Click += new System.EventHandler(this.btnShowSinglePicture_Click);
            // 
            // showMultiPictureToolStripMenuItem
            // 
            this.showMultiPictureToolStripMenuItem.Name = "showMultiPictureToolStripMenuItem";
            this.showMultiPictureToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.showMultiPictureToolStripMenuItem.Text = "Show Multi-Picture";
            this.showMultiPictureToolStripMenuItem.Click += new System.EventHandler(this.btnShowMultiPicture_Click);
            // 
            // slideShowToolStripMenuItem
            // 
            this.slideShowToolStripMenuItem.Name = "slideShowToolStripMenuItem";
            this.slideShowToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.slideShowToolStripMenuItem.Text = "Slide Show ";
            this.slideShowToolStripMenuItem.Click += new System.EventHandler(this.btnSlideShow_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(185, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(306, 193);
            this.textBox1.TabIndex = 10;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "There are no pictures.\r\npress Add Pictures from context menu to add some Pictures" +
    "!\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowSinglePicture
            // 
            this.btnShowSinglePicture.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnShowSinglePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSinglePicture.Location = new System.Drawing.Point(250, 140);
            this.btnShowSinglePicture.Name = "btnShowSinglePicture";
            this.btnShowSinglePicture.Size = new System.Drawing.Size(189, 37);
            this.btnShowSinglePicture.TabIndex = 3;
            this.btnShowSinglePicture.Text = "Show Single Picture";
            this.btnShowSinglePicture.UseVisualStyleBackColor = false;
            this.btnShowSinglePicture.Click += new System.EventHandler(this.btnShowSinglePicture_Click);
            // 
            // Pictures_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(710, 402);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSlideShow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowMultiPicture);
            this.Controls.Add(this.btnShowSinglePicture);
            this.Controls.Add(this.picturesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPictures);
            this.Controls.Add(this.picBoxSinglePic);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pictures_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pictures Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSinglePic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnAddPictures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox picturesListBox;
        private System.Windows.Forms.Button btnShowMultiPicture;
        private System.Windows.Forms.Button btnSlideShow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.PictureBox picBoxSinglePic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSinglePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMultiPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowSinglePicture;
    }
}

