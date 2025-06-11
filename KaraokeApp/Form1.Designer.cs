namespace KaraokeApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lyrics_list = new System.Windows.Forms.ListBox();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.lbl_lyrics = new System.Windows.Forms.Label();
            this.tb_lyrics = new System.Windows.Forms.TextBox();
            this.btn_loadLyrics = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_volume_name = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_songInfo = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lyrics_list);
            this.groupBox1.Controls.Add(this.btn_repeat);
            this.groupBox1.Controls.Add(this.lbl_lyrics);
            this.groupBox1.Controls.Add(this.tb_lyrics);
            this.groupBox1.Controls.Add(this.btn_loadLyrics);
            this.groupBox1.Controls.Add(this.track_list);
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_play);
            this.groupBox1.Controls.Add(this.btn_prev);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1000, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // lyrics_list
            // 
            this.lyrics_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lyrics_list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyrics_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lyrics_list.FormattingEnabled = true;
            this.lyrics_list.ItemHeight = 24;
            this.lyrics_list.Location = new System.Drawing.Point(529, 128);
            this.lyrics_list.Margin = new System.Windows.Forms.Padding(4);
            this.lyrics_list.Name = "lyrics_list";
            this.lyrics_list.Size = new System.Drawing.Size(464, 124);
            this.lyrics_list.TabIndex = 19;
            this.lyrics_list.SelectedIndexChanged += new System.EventHandler(this.lyrics_list_SelectedIndexChanged);
            // 
            // btn_repeat
            // 
            this.btn_repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repeat.ForeColor = System.Drawing.Color.Cyan;
            this.btn_repeat.Location = new System.Drawing.Point(852, 26);
            this.btn_repeat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(141, 43);
            this.btn_repeat.TabIndex = 18;
            this.btn_repeat.Text = "Repeat";
            this.btn_repeat.UseVisualStyleBackColor = true;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // lbl_lyrics
            // 
            this.lbl_lyrics.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lyrics.Location = new System.Drawing.Point(40, 309);
            this.lbl_lyrics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lyrics.Name = "lbl_lyrics";
            this.lbl_lyrics.Size = new System.Drawing.Size(924, 101);
            this.lbl_lyrics.TabIndex = 17;
            this.lbl_lyrics.Text = "Lyrics Display";
            this.lbl_lyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_lyrics
            // 
            this.tb_lyrics.BackColor = System.Drawing.Color.Black;
            this.tb_lyrics.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lyrics.ForeColor = System.Drawing.Color.Aqua;
            this.tb_lyrics.Location = new System.Drawing.Point(8, 260);
            this.tb_lyrics.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lyrics.Multiline = true;
            this.tb_lyrics.Name = "tb_lyrics";
            this.tb_lyrics.ReadOnly = true;
            this.tb_lyrics.Size = new System.Drawing.Size(982, 201);
            this.tb_lyrics.TabIndex = 16;
            this.tb_lyrics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_loadLyrics
            // 
            this.btn_loadLyrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadLyrics.ForeColor = System.Drawing.Color.Cyan;
            this.btn_loadLyrics.Location = new System.Drawing.Point(529, 77);
            this.btn_loadLyrics.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadLyrics.Name = "btn_loadLyrics";
            this.btn_loadLyrics.Size = new System.Drawing.Size(114, 43);
            this.btn_loadLyrics.TabIndex = 15;
            this.btn_loadLyrics.Text = "Lyrics";
            this.btn_loadLyrics.UseVisualStyleBackColor = true;
            this.btn_loadLyrics.Click += new System.EventHandler(this.btn_loadLyrics_Click);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 24;
            this.track_list.Location = new System.Drawing.Point(8, 128);
            this.track_list.Margin = new System.Windows.Forms.Padding(4);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(476, 124);
            this.track_list.TabIndex = 6;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.Cyan;
            this.btn_pause.Location = new System.Drawing.Point(529, 26);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(153, 43);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.Cyan;
            this.btn_open.Location = new System.Drawing.Point(8, 77);
            this.btn_open.Margin = new System.Windows.Forms.Padding(4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(114, 43);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Song";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.Cyan;
            this.btn_stop.Location = new System.Drawing.Point(691, 26);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(153, 43);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Cyan;
            this.btn_next.Location = new System.Drawing.Point(331, 26);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(153, 43);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.Cyan;
            this.btn_play.Location = new System.Drawing.Point(169, 26);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(153, 43);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.Color.Cyan;
            this.btn_prev.Location = new System.Drawing.Point(8, 26);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(153, 43);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_volume.Location = new System.Drawing.Point(971, 315);
            this.lbl_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(38, 24);
            this.lbl_volume.TabIndex = 9;
            this.lbl_volume.Text = "0%";
            // 
            // lbl_volume_name
            // 
            this.lbl_volume_name.AutoSize = true;
            this.lbl_volume_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume_name.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_volume_name.Location = new System.Drawing.Point(769, 312);
            this.lbl_volume_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_volume_name.Name = "lbl_volume_name";
            this.lbl_volume_name.Size = new System.Drawing.Size(40, 29);
            this.lbl_volume_name.TabIndex = 9;
            this.lbl_volume_name.Text = "🔊";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(804, 305);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(176, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.Black;
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(713, 38);
            this.pic_art.Margin = new System.Windows.Forms.Padding(4);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(303, 145);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 13;
            this.pic_art.TabStop = false;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_msg.Location = new System.Drawing.Point(11, 11);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(153, 24);
            this.lbl_msg.TabIndex = 8;
            this.lbl_msg.Text = "Karaoke Player";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 319);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 16);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_track_start.Location = new System.Drawing.Point(11, 315);
            this.lbl_track_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(61, 24);
            this.lbl_track_start.TabIndex = 10;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_end.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_track_end.Location = new System.Drawing.Point(701, 315);
            this.lbl_track_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(61, 24);
            this.lbl_track_end.TabIndex = 12;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_songInfo
            // 
            this.lbl_songInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_songInfo.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_songInfo.Location = new System.Drawing.Point(713, 187);
            this.lbl_songInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_songInfo.Name = "lbl_songInfo";
            this.lbl_songInfo.Size = new System.Drawing.Size(296, 103);
            this.lbl_songInfo.TabIndex = 14;
            this.lbl_songInfo.Text = "Song Info";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 31);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(686, 198);
            this.player.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1045, 842);
            this.Controls.Add(this.lbl_songInfo);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_volume_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.player);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karaoke";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_volume_name;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.Button btn_loadLyrics;
        private System.Windows.Forms.TextBox tb_lyrics;
        private System.Windows.Forms.Label lbl_songInfo;
        private System.Windows.Forms.Label lbl_lyrics;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.ListBox lyrics_list;
    }
}

