using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;//Esta biblioteca hace posible el hacer uso de audios
using NAudio;
using System.IO;//Biblioteca que permite el manejo, uso de entrada y salida de archivos
using TagLib;//Biblioteca para trabajar con metadatos de audio

/*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

namespace ReproductorDeMusica

    
{
    
    public partial class Form1 : Form 
    {
        private IWavePlayer cancion;
        private AudioFileReader audioFile;
        


        public Form1()
        {
            InitializeComponent();
            cancion = new WaveOutEvent();

        }
        private void TrackBarSubirVolumen_ValueChanged(object sender, EventArgs e)
        {
            if (cancion != null)
            {
                float nuevoVolumen = (float)TrackBarSubirVolumen.Value / TrackBarSubirVolumen.Maximum;
                cancion.Volume = nuevoVolumen;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Agrega y carga la lista de canciones dentro de "listBoxCanciones"
            TrackBarSubirVolumen.ValueChanged += TrackBarSubirVolumen_ValueChanged;

            string carpetaDeMusica = @"D:\musica"; //Almacena la ruta de nuestra musica
            string[] archivosMusica = Directory.GetFiles(carpetaDeMusica, "*.mp3");

            // Agrega el titulo de las canciones
            foreach (string archivo in archivosMusica)
            {
                string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
                listBoxCanciones.Items.Add(nombreArchivo);
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            
            if (listBoxCanciones.SelectedIndex != -1)
            {
                string selectedSong = Path.Combine(@"D:\musica", listBoxCanciones.SelectedItem + ".mp3");
                audioFile = new AudioFileReader(selectedSong);

                // Detiene y libera la canción anterior (si existe)
                cancion.Stop();
                cancion.Dispose();
                cancion = new WaveOutEvent();

                // Asigna la fuente al reproductor y reproduce
                cancion.Init(audioFile);
                cancion.Play();

                // Cambiar la propiedad Enabled del PictureBox para habilitar/deshabilitar el GIF
                picture.Enabled = true;

                // Carga la portada de la canción en el PictureBox
                LoadAlbumArt(selectedSong);
                
            }
            else {
                MessageBox.Show("hubo un error");
        }
    


}

        private void LoadAlbumArt(string filePath)
        {
            using (TagLib.File tagFile = TagLib.File.Create(filePath))
            {
                if (tagFile.Tag.Pictures.Length >= 1)//Al hacer una revision de los metadatos, busca una portada de la cancion que se reproduce
                {
                    var albumArtBytes = tagFile.Tag.Pictures[0].Data.Data;
                    using (MemoryStream ms = new MemoryStream(albumArtBytes))
                    {
                        pictureBoxAlbumImagen.Image = new System.Drawing.Bitmap(ms);
                    }
                }
                else
                {
                    pictureBoxAlbumImagen.Image = Properties.Resources.alternativa;//Si al reproducir la cancion esta no posee ninguna portada se muestra una imagen por defecto o alternativa

                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            cancion.Pause();
            picture.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cancion != null)
            {
                cancion.Stop();
                audioFile.Position = 0; // Se reinicia la posicion de la cancion que se esta reproduciendo desde el inicio
                picture.Enabled = false;
            }
        }

        private void pictureBoxAlbumCover_Click(object sender, EventArgs e)
        {

        }

        private void btnConfigurarRuta_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//salir de la aplicacion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimizar
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picture.Enabled = !picture.Enabled;
        }

        private void settings_Click(object sender, EventArgs e)
        {

        }
    }
    }
//Desarrollador: Juan De Leon 
//Fecha de actualizacion: 18/08/2023


//Funcionamiento-------------------------------------------------------------------------------------------------------------------
/*importamos las bibliotecas que seran necesarias para el funcionamiento de la aplicacion, hacemos uso de un
lector de archivos de audio y uno de reproduccion, un evento que obtiene una lista de los archivos del directorio de musica
agregando solo los titulos
el boton "play" contiene un evento y carga el archivo que el usuario selecciona y carga una portada 
Método LoadAlbumArt: Carga la portada del álbum de la canción actual utilizando la biblioteca TagLib.
Si no se encuentra una portada, muestra una imagen alternativa.
*/

