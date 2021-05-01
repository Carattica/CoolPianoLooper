using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoLooper
{
    public partial class PianoLooper : Form
    {
        BindingList<string> songList = new BindingList<string>();
        SoundPlayer sound = new SoundPlayer();
        State state;

        public PianoLooper()
        {
            InitializeComponent();
        }

        private void PianoLooper_Load(object sender, EventArgs e)
        {
            songList.Add("Hot Cross Buns");
            songList.Add("Mary Had a Little Lamb");
            effectComboBox.SelectedItem = "Standard";
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            presetsCheckBox.Checked = true;
            state = new Free(this);
            songComboBox.DataSource = songList;
        }

        private void keyC3_Click(object sender, EventArgs e)
        {

        }

        private void keyD3_Click(object sender, EventArgs e)
        {

        }

        private void keyE3_Click(object sender, EventArgs e)
        {

        }

        private void keyF3_Click(object sender, EventArgs e)
        {

        }

        private void keyG3_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/g3.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyA3_Click(object sender, EventArgs e)
        {

        }

        private void keyB3_Click(object sender, EventArgs e)
        {

        }

        private void keyC4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/c4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyD4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/d4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyE4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/e4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyF4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/f4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyG4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/g4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyA4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/a4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyB4_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/b4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyC5_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/c5.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyG3Sharp_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/gsharp3.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void keyG4Sharp_Click(object sender, EventArgs e)
        {
            string thing = "C:/Users/Keegan/School/SWENG/421/Final Project/PianoLooper/PianoLooper/Resources/Standard/gsharp4.wav";
            sound.SoundLocation = thing;
            sound.Play();
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            buttonTip.SetToolTip(playButton, "Play currently selected song");
        }

        private void stopButton_MouseHover(object sender, EventArgs e)
        {
            buttonTip.SetToolTip(stopButton, "Stop current playback");
        }

        private void recordButton_MouseHover(object sender, EventArgs e)
        {
            buttonTip.SetToolTip(recordButton, "Record a new song");
        }

        private void presetsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!presetsCheckBox.Checked)
            {

            }
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            bool isHere = false;
            foreach (string s in songComboBox.Items)
            {
                if (songComboBox.Text.Equals(s))
                {
                    isHere = true;
                }
            }
            if (!isHere)
            {
                songList.Add(songComboBox.Text);
            }



        }
    }
}
