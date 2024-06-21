namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnOpenEqualizer = new Button();
            TrackBarProgress = new Guna.UI2.WinForms.Guna2TrackBar();
            VolumeBar = new Guna.UI2.WinForms.Guna2TrackBar();
            pictureBoxAlbumArt = new PictureBox();
            lblArtistName = new Label();
            lblTotalTime = new Label();
            lblCurrentTime = new Label();
            lblSongName = new Label();
            button3 = new Button();
            button2 = new Button();
            playB = new Button();
            fileManagerB = new Button();
            openFileDialog = new OpenFileDialog();
            listBoxSongs = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            label1 = new Label();
            btnClearSongs = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnOpenEqualizer);
            panel1.Controls.Add(TrackBarProgress);
            panel1.Controls.Add(VolumeBar);
            panel1.Controls.Add(pictureBoxAlbumArt);
            panel1.Controls.Add(lblArtistName);
            panel1.Controls.Add(lblTotalTime);
            panel1.Controls.Add(lblCurrentTime);
            panel1.Controls.Add(lblSongName);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(playB);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 681);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 80);
            panel1.TabIndex = 0;
            // 
            // btnOpenEqualizer
            // 
            btnOpenEqualizer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnOpenEqualizer.Cursor = Cursors.Hand;
            btnOpenEqualizer.FlatAppearance.BorderSize = 0;
            btnOpenEqualizer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOpenEqualizer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOpenEqualizer.FlatStyle = FlatStyle.Flat;
            btnOpenEqualizer.Image = Properties.Resources.equalizer;
            btnOpenEqualizer.Location = new Point(809, 18);
            btnOpenEqualizer.Name = "btnOpenEqualizer";
            btnOpenEqualizer.Size = new Size(49, 45);
            btnOpenEqualizer.TabIndex = 7;
            btnOpenEqualizer.UseVisualStyleBackColor = true;
            btnOpenEqualizer.Click += btnOpenEqualizer_Click;
            // 
            // TrackBarProgress
            // 
            TrackBarProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TrackBarProgress.Cursor = Cursors.Hand;
            TrackBarProgress.HoverState.FillColor = Color.DarkGray;
            TrackBarProgress.HoverState.ThumbColor = Color.DarkOrange;
            TrackBarProgress.Location = new Point(262, 44);
            TrackBarProgress.Name = "TrackBarProgress";
            TrackBarProgress.Size = new Size(316, 23);
            TrackBarProgress.TabIndex = 6;
            TrackBarProgress.ThumbColor = Color.DarkOrange;
            TrackBarProgress.Value = 0;
            TrackBarProgress.Scroll += TrackBarProgress_Scroll;
            // 
            // VolumeBar
            // 
            VolumeBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VolumeBar.Cursor = Cursors.Hand;
            VolumeBar.HoverState.FillColor = Color.DarkGray;
            VolumeBar.HoverState.ThumbColor = Color.DarkOrange;
            VolumeBar.Location = new Point(649, 32);
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Size = new Size(130, 31);
            VolumeBar.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            VolumeBar.TabIndex = 1;
            VolumeBar.ThumbColor = Color.White;
            VolumeBar.Value = 100;
            VolumeBar.ValueChanged += trackBarVolume_ValueChanged;
            // 
            // pictureBoxAlbumArt
            // 
            pictureBoxAlbumArt.ErrorImage = null;
            pictureBoxAlbumArt.InitialImage = null;
            pictureBoxAlbumArt.Location = new Point(12, 3);
            pictureBoxAlbumArt.Margin = new Padding(0);
            pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            pictureBoxAlbumArt.Size = new Size(60, 60);
            pictureBoxAlbumArt.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAlbumArt.TabIndex = 1;
            pictureBoxAlbumArt.TabStop = false;
            // 
            // lblArtistName
            // 
            lblArtistName.AutoEllipsis = true;
            lblArtistName.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArtistName.ForeColor = Color.DarkGray;
            lblArtistName.Location = new Point(78, 41);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(135, 17);
            lblArtistName.TabIndex = 5;
            lblArtistName.Text = "author";
            // 
            // lblTotalTime
            // 
            lblTotalTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalTime.AutoSize = true;
            lblTotalTime.BackColor = Color.Transparent;
            lblTotalTime.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTime.ForeColor = Color.Gray;
            lblTotalTime.Location = new Point(584, 47);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(35, 16);
            lblTotalTime.TabIndex = 4;
            lblTotalTime.Text = "0:00";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.BackColor = Color.Transparent;
            lblCurrentTime.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentTime.ForeColor = Color.Gray;
            lblCurrentTime.Location = new Point(218, 47);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(35, 16);
            lblCurrentTime.TabIndex = 1;
            lblCurrentTime.Text = "0:00";
            // 
            // lblSongName
            // 
            lblSongName.AutoEllipsis = true;
            lblSongName.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSongName.ForeColor = Color.White;
            lblSongName.Location = new Point(78, 14);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(220, 17);
            lblSongName.TabIndex = 1;
            lblSongName.Text = "name";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.prevSongGrey;
            button3.Location = new Point(358, 10);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnPrevious_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.nextSongGrey;
            button2.Location = new Point(468, 10);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnNext_Click;
            // 
            // playB
            // 
            playB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            playB.BackColor = Color.Transparent;
            playB.Cursor = Cursors.Hand;
            playB.FlatAppearance.BorderSize = 0;
            playB.FlatAppearance.MouseDownBackColor = Color.Transparent;
            playB.FlatAppearance.MouseOverBackColor = Color.Transparent;
            playB.FlatStyle = FlatStyle.Flat;
            playB.Image = Properties.Resources.play;
            playB.Location = new Point(408, 3);
            playB.Margin = new Padding(0);
            playB.Name = "playB";
            playB.Size = new Size(40, 40);
            playB.TabIndex = 0;
            playB.UseVisualStyleBackColor = false;
            playB.Click += btnPlayPause_Click;
            // 
            // fileManagerB
            // 
            fileManagerB.BackColor = Color.Transparent;
            fileManagerB.Cursor = Cursors.Hand;
            fileManagerB.FlatAppearance.BorderSize = 0;
            fileManagerB.FlatAppearance.MouseDownBackColor = Color.Transparent;
            fileManagerB.FlatAppearance.MouseOverBackColor = Color.Transparent;
            fileManagerB.FlatStyle = FlatStyle.Flat;
            fileManagerB.Image = Properties.Resources.filemanager;
            fileManagerB.Location = new Point(12, 12);
            fileManagerB.Name = "fileManagerB";
            fileManagerB.Size = new Size(40, 40);
            fileManagerB.TabIndex = 1;
            fileManagerB.Tag = "";
            fileManagerB.UseVisualStyleBackColor = false;
            fileManagerB.Click += FileManager_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxSongs.BackColor = Color.Black;
            listBoxSongs.BorderStyle = BorderStyle.None;
            listBoxSongs.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxSongs.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSongs.ForeColor = Color.White;
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.HorizontalScrollbar = true;
            listBoxSongs.ItemHeight = 21;
            listBoxSongs.Location = new Point(60, 9);
            listBoxSongs.Margin = new Padding(0);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(824, 672);
            listBoxSongs.TabIndex = 0;
            listBoxSongs.DrawItem += listBoxSongs_DrawItem;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnClearSongs);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(fileManagerB);
            panel2.Controls.Add(listBoxSongs);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 681);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(9, 143);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 26;
            label1.Text = "clear";
            // 
            // btnClearSongs
            // 
            btnClearSongs.BackColor = Color.Transparent;
            btnClearSongs.Cursor = Cursors.Hand;
            btnClearSongs.FlatAppearance.BorderSize = 0;
            btnClearSongs.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClearSongs.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClearSongs.FlatStyle = FlatStyle.Flat;
            btnClearSongs.Image = Properties.Resources.remove;
            btnClearSongs.Location = new Point(12, 87);
            btnClearSongs.Name = "btnClearSongs";
            btnClearSongs.Size = new Size(40, 40);
            btnClearSongs.TabIndex = 25;
            btnClearSongs.Tag = "";
            btnClearSongs.UseVisualStyleBackColor = false;
            btnClearSongs.Click += btnClearSongs_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkOrange;
            label11.Location = new Point(17, 55);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 24;
            label11.Text = "add";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(884, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 500);
            Name = "Form1";
            Opacity = 0.99D;
            Text = "Soundify";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button playB;
        private Button button3;
        private Button button2;
        private Button fileManagerB;
        private Label lblSongName;
        private Label lblCurrentTime;
        private Label lblTotalTime;
        private Label lblArtistName;
        private PictureBox pictureBoxAlbumArt;
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2TrackBar VolumeBar;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarProgress;
        private ListBox listBoxSongs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnOpenEqualizer;
        private Panel panel2;
        private Label label11;
        private Button btnClearSongs;
        private Label label1;
    }
}
