using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlayButton.Enabled = false;
            PlayButton.Visible = false;
            PauseButton.Enabled = false;
            PauseButton.Visible = false;
        }

        Music music = new Music();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseSongButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select File";
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.Multiselect = true;
            if ((fileDialog.ShowDialog() == DialogResult.OK) && (fileDialog.FileName != string.Empty))
            {
                String[] files = fileDialog.SafeFileNames;


                for (int index = 0; index < files.Length; ++index)
                {
                    listBox1.Items.Add(files[index]);
                    listBox2.Items.Add(fileDialog.FileNames.ElementAt(index));
                }

                Timer.Enabled = true;
                Timer.Interval = 1000;
                music.GetSong(fileDialog.FileName); 
                music.Play();
                PauseButton.Enabled = true;
                PauseButton.Visible = true;

            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            music.Pause();
            PauseButton.Enabled = false;
            PauseButton.Visible = false;
            PlayButton.Enabled = true;
            PlayButton.Visible = true;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            music.Play();
            PauseButton.Enabled = true;
            PauseButton.Visible = true;
            PlayButton.Enabled = false;
            PlayButton.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SongTimeBar.Enabled = true;
            SongTimeBar.Maximum = Convert.ToInt32(music.GetSongDuration());
            SongTimeBar.Value = Convert.ToInt32(music.GetCurrentPosition());

            if (music.GetSongDuration() != 0)
            {
                int seconds = Convert.ToInt32(music.GetSongDuration());
                int hours = seconds / 3600;
                int minutes = (seconds - (hours * 3600)) / 60;
                seconds = seconds - (hours * 3600 + minutes * 60);
                label3.Text = String.Format("{0:D}:{1:D2}:{2:D2}", hours, minutes, seconds);

                seconds = Convert.ToInt32(music.GetCurrentPosition());
                hours = seconds / 3600;
                minutes = (seconds - (hours * 3600)) / 60;
                seconds = seconds - (hours * 3600 + minutes * 60);
                label2.Text = String.Format("{0:D}:{1:D2}:{2:D2}", hours, minutes, seconds);
            } else
            {
                label3.Text = "0:00:00";
                label2.Text = "0:00:00";
                
            }
        }

        private void SongTimeBar_Scroll(object sender, EventArgs e)
        {
            music.SongBarScroll(SongTimeBar.Value);
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            music.SetVolume(VolumeBar.Value * 10);
        }

        private void PlaySelectedSong_Click_1(object sender, EventArgs e)
        {
            music.Pause();

            if (listBox1.SelectedIndex != -1)
            {
                var song = listBox2.Items[listBox1.SelectedIndex];

                if (song != "")
                {
                    music.GetSong(Convert.ToString(song));
                    music.Play();
                }
                else
                {
                    music.Play();
                }
            }
        }
    }

    public class Music
    {
        WindowsMediaPlayer windowsPlayer = new WindowsMediaPlayer();
        public IMusicState State { get; set; }

        public Music()
        {
            State = new PauseMusicState();
        }

        public void GetSong(string file)
        {
            windowsPlayer.URL = file;
        }

        public double GetSongDuration()
        {
            return windowsPlayer.currentMedia.duration;
        }

        public double GetCurrentPosition()
        {
            return windowsPlayer.controls.currentPosition;
        }
        public void SongBarScroll(double value)
        {
            windowsPlayer.controls.currentPosition = value;
        }

        public void SetVolume(int value)
        {
            windowsPlayer.settings.volume = value;
        }


        public void Play()
        {
            State.Play(this);
            windowsPlayer.controls.play();
        }

        public void Pause()
        {
            State.Pause(this);
            windowsPlayer.controls.pause();
        }
    }

    public interface IMusicState
    {
        void Play(Music music);
        void Pause(Music music);
    }

    public class PlayMusicState : IMusicState
    {
        public void Play(Music music)
        {

        }

        public void Pause(Music music)
        {
            music.State = new PauseMusicState();
        }
    }

    public class PauseMusicState : IMusicState
    {
        public void Play(Music music)
        {
            music.State = new PlayMusicState();
        }

        public void Pause(Music music)
        {

        }
    }
}
