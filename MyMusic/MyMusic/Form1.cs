using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyMusic
{
    public partial class Form1 : Form
    {
        int i ;
        List<string> ListaReproduccion;
        public Form1()
        {
            InitializeComponent();
        
            listBox1.Text = "";
             i = listBox1.SelectedIndex;

        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this. Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectSong = listBox1.SelectedItem.ToString();
            axWindowsMediaPlayer1.URL=selectSong;
            this.Text = selectSong + "--MyMusic";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            i++;
            try
            {

                if (i == 0)
                {
                    i++;
                }

                string song = listBox1.Items[i].ToString();
                axWindowsMediaPlayer1.URL = song;
                this.Text = song + "--MyMusic";

            }
            catch (ArgumentOutOfRangeException arg)
            {
                
            }
                
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i--;
            try
            {

                

                string song = listBox1.Items[i].ToString();
                axWindowsMediaPlayer1.URL = song;
                this.Text = song + "--MyMusic";

            }
            catch (ArgumentOutOfRangeException arg)
            {

            }



        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "New music file";
            openfile.ValidateNames = true;
            openfile.Filter = "mp3|*.mp3|mp4|*.mp4";
            openfile.FilterIndex = 1;
            openfile.Multiselect = true;


            if (openfile.ShowDialog() == DialogResult.OK)
            {
                ListaReproduccion = new List<string>();
                foreach (String file in openfile.FileNames)
                {

                    ListaReproduccion.Add(file);

                }

                axWindowsMediaPlayer1.URL = openfile.FileName;
                this.Text = openfile.SafeFileName + "--MyMusic";
            }
            if (ListaReproduccion.Count == 0)
            {
                listBox1.Text = "Empty List";
            }
            if (ListaReproduccion.Count == 1)
            {
                listBox1.Hide();
            }
           
            else
            {
                listBox1.Show();
                foreach (var lista in ListaReproduccion)
                 {
                        listBox1.Items.Add(lista);
                 }
            }
            

        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "New video file";
            openfile.ValidateNames = true;
            openfile.Filter = "mp4|*.mp4|avi|*.avi";
            openfile.FilterIndex = 1;
            openfile.Multiselect = true;


            if (openfile.ShowDialog() == DialogResult.OK)
            {
                ListaReproduccion = new List<string>();
                foreach (String file in openfile.FileNames)
                {

                    ListaReproduccion.Add(file);

                }

                axWindowsMediaPlayer1.URL = openfile.FileName;
                this.Text = openfile.SafeFileName + "--MyMusic";
            }
            if(ListaReproduccion.Count == 1)
            {
                listBox1.Hide();
            }
            if (ListaReproduccion.Count == 0)
            {
                listBox1.Text = "Empty List";
            }
            else
            {
                listBox1.Show();
                foreach (var lista in ListaReproduccion)
                {
                    listBox1.Items.Add(lista);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }
    }
}
