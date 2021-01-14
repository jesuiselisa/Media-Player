using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> OynatmaListesi = new List<string>();

        private void OK_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listBox.Items.Add(openFileDialog1.FileNames[i].ToString());
                    OynatmaListesi.Add(openFileDialog1.FileNames[i].ToString());
                }
                if (listBox.Items.Count > 0)
                {
                    listBox.SelectedIndex = 0;
                }
            }
        }

        void MuzikCal()
        {
            axWindowsMediaPlayer1.URL = listBox.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MuzikCal();
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MuzikCal();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 5;
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 5;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, listBox.Items.Count);
            axWindowsMediaPlayer1.URL = listBox.Items[a].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
