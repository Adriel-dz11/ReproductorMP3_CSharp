using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMP
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog()==System.Windows.Forms.DialogResult.OK){
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;

                foreach(var ArchivoMP3 in ArchivosMP3){
                    listBox1.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = rutasArchivosMP3[0];
                listBox1.SelectedIndex = 0;
                btnPlay.BackgroundImage = Properties.Resources.pause;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosMP3[listBox1.SelectedIndex];
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            switch (Play) {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay.BackgroundImage = Properties.Resources.play;
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay.BackgroundImage = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }

        public void ActualizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control del tiempo maximo del mp3 actual
                macTrackBar1.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start(); }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused) {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                macTrackBar1.Value = 0;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            macTrackBar1.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            macTrackVolumen.Value = Reproductor.settings.volume;

        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void macTrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = macTrackVolumen.Value;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
