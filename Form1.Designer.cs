namespace Media_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicPlayer = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnArtı = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(75, 58);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(309, 243);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.AutoSize = true;
            this.MusicPlayer.BackColor = System.Drawing.Color.SpringGreen;
            this.MusicPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MusicPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusicPlayer.Location = new System.Drawing.Point(248, 26);
            this.MusicPlayer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.Size = new System.Drawing.Size(159, 27);
            this.MusicPlayer.TabIndex = 1;
            this.MusicPlayer.Text = "MUSIC PLAYER";
            // 
            // btnOK
            // 
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(393, 313);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(180, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 27;
            this.listBox.Location = new System.Drawing.Point(393, 58);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(180, 247);
            this.listBox.TabIndex = 5;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGeri.Location = new System.Drawing.Point(75, 313);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 39);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "<<";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.BackColor = System.Drawing.Color.SpringGreen;
            this.btnİleri.Location = new System.Drawing.Point(309, 313);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 39);
            this.btnİleri.TabIndex = 7;
            this.btnİleri.Text = ">>";
            this.btnİleri.UseVisualStyleBackColor = false;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SpringGreen;
            this.btnStop.Location = new System.Drawing.Point(289, 373);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 37);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPlay.Location = new System.Drawing.Point(75, 373);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 37);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPause.Location = new System.Drawing.Point(167, 313);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(124, 39);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEksi.Location = new System.Drawing.Point(393, 373);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(36, 37);
            this.btnEksi.TabIndex = 11;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = false;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnArtı
            // 
            this.btnArtı.BackColor = System.Drawing.Color.SpringGreen;
            this.btnArtı.Location = new System.Drawing.Point(537, 373);
            this.btnArtı.Name = "btnArtı";
            this.btnArtı.Size = new System.Drawing.Size(36, 37);
            this.btnArtı.TabIndex = 12;
            this.btnArtı.Text = "+";
            this.btnArtı.UseVisualStyleBackColor = false;
            this.btnArtı.Click += new System.EventHandler(this.btnArtı_Click);
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.SpringGreen;
            this.btnMix.Location = new System.Drawing.Point(435, 373);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(96, 37);
            this.btnMix.TabIndex = 13;
            this.btnMix.Text = "mıx";
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRemove.Location = new System.Drawing.Point(176, 373);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 37);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.btnArtı);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnİleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label MusicPlayer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnArtı;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnRemove;
    }
}

