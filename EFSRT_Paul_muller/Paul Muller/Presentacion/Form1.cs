using AxWMPLib;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
         );

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Posiciona el formulario en el centro de la pantalla
            axWindowsMediaPlayer1.uiMode = "none"; // Oculta los controles del Windows Media Player
            string videoPath = Path.Combine(Application.StartupPath, "Elementos", "Logo_Muller.mp4");

            // Verifica si el archivo de video existe
            if (File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.URL = videoPath; // Establece la URL del video
                axWindowsMediaPlayer1.Ctlcontrols.play(); // Reproduce el video automáticamente
            }
            else
            {
                MessageBox.Show("El archivo de video no se encontró en la ruta especificada.");
                this.Hide(); // Cierra el formulario si el archivo no se encuentra
            }

            axWindowsMediaPlayer1.Enabled = false; // Desactiva la interacción del usuario con el control

            // Establece la región del formulario para bordes redondeados
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Maneja el evento de cambio de estado del reproductor
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) // Estado 8 indica que el video ha terminado
            {
                // En lugar de ocultar el formulario directamente, ciérralo y luego abre el formulario principal
                this.Hide(); // Cierra el formulario de splash

                // Crea una instancia del formulario principal
                Principal.Login lg = new Principal.Login(); // Asegúrate de que Login es el nombre correcto del formulario principal
                lg.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario principal
                lg.Show(); // Muestra el formulario principal
            }
        }
    }
}
