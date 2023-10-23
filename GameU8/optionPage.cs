using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameU8
{
    public partial class optionPage : Form
    {


        private bool isBackgroundMusicOn = true;
        private System.Media.SoundPlayer backgroundMusicPlayer;


        // Initialise the code \\

        public optionPage()
        {
            InitializeComponent();
            backgroundMusicPlayer = new System.Media.SoundPlayer(Properties.Resources.backgroundmusic);
        }


        private void OptionPage_Load(object sender, EventArgs e)
        {
            trackBarVolume.Value = isBackgroundMusicOn ? trackBarVolume.Maximum : trackBarVolume.Minimum;
            UpdateBackgroundMusic();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            isBackgroundMusicOn = (trackBarVolume.Value > 0);
            UpdateBackgroundMusic();
        }


        private void pbAudio_Click(object sender, EventArgs e)
        {
            isBackgroundMusicOn = !isBackgroundMusicOn;
            UpdateBackgroundMusic();
        }


        // Play background music if it's on, stops if it's off \\

        private void UpdateBackgroundMusic()
        {
            if (isBackgroundMusicOn)
            {
                backgroundMusicPlayer.PlayLooping();
                pbAudio.Image = Properties.Resources.sound_on;
            }
            else
            {
                backgroundMusicPlayer.Stop();
                pbAudio.Image = Properties.Resources.sound_off;
            }
        }
       

        // If you click the back button, it will take you back to the main menu \\

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }






    }
}
