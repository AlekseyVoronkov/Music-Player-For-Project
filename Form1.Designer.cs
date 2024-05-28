namespace MusicPlayer
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
            this.ChooseSongButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SongTimeBar = new System.Windows.Forms.TrackBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlaySelectedSong = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.SongTimeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseSongButton
            // 
            this.ChooseSongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseSongButton.Location = new System.Drawing.Point(12, 50);
            this.ChooseSongButton.Name = "ChooseSongButton";
            this.ChooseSongButton.Size = new System.Drawing.Size(144, 38);
            this.ChooseSongButton.TabIndex = 0;
            this.ChooseSongButton.Text = "Choose song";
            this.ChooseSongButton.UseVisualStyleBackColor = true;
            this.ChooseSongButton.Click += new System.EventHandler(this.ChooseSongButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(48, 94);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(174, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 134);
            this.listBox1.TabIndex = 3;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(48, 94);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SongTimeBar
            // 
            this.SongTimeBar.Enabled = false;
            this.SongTimeBar.Location = new System.Drawing.Point(58, 189);
            this.SongTimeBar.Maximum = 150;
            this.SongTimeBar.Name = "SongTimeBar";
            this.SongTimeBar.Size = new System.Drawing.Size(407, 45);
            this.SongTimeBar.TabIndex = 6;
            this.SongTimeBar.Scroll += new System.EventHandler(this.SongTimeBar_Scroll);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "0:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0:00:00";
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(505, 130);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(45, 104);
            this.VolumeBar.TabIndex = 9;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 5;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Volume";
            // 
            // PlaySelectedSong
            // 
            this.PlaySelectedSong.Location = new System.Drawing.Point(270, 152);
            this.PlaySelectedSong.Name = "PlaySelectedSong";
            this.PlaySelectedSong.Size = new System.Drawing.Size(108, 23);
            this.PlaySelectedSong.TabIndex = 13;
            this.PlaySelectedSong.Text = "Play Selected Song ";
            this.PlaySelectedSong.UseVisualStyleBackColor = true;
            this.PlaySelectedSong.Click += new System.EventHandler(this.PlaySelectedSong_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(152, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(16, 17);
            this.listBox2.TabIndex = 14;
            this.listBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(562, 246);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.PlaySelectedSong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SongTimeBar);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ChooseSongButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.SongTimeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button ChooseSongButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TrackBar SongTimeBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PlaySelectedSong;
        private System.Windows.Forms.ListBox listBox2;
    }
}

