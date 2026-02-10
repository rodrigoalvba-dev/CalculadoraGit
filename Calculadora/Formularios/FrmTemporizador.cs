using Microsoft.VisualBasic;
using System.Media;
namespace Calculadora.Formularios
{
    public partial class FrmTemporizador : Form
    {
        string alarma1 = "";
        public FrmTemporizador()
        {
            InitializeComponent();
        }


        private void tmrHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (labelHora.Text == alarma1)
            {

                SoundPlayer alarma = new SoundPlayer(@"C:\Users\Mario\Downloads\ringtones-page-gallo-despertador.wav");
                alarma.Play();
            }
        }



        private void mIalarma1_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora ", "Sistema", "00:00:00 x.x");

        }



        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmTemporizador_Load(object sender, EventArgs e)
        {

        }
    }
}
