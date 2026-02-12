using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrEDitor : Form
    {

        public FrEDitor()
        {
            InitializeComponent();
        }
        public bool saved = false;
        public string patch = "";
        string texto = "";
        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFP.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(OFP.FileName))
                {
                    richTextBox1.Text = File.ReadAllText(OFP.FileName);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                patch = SFD.FileName;
                using (StreamWriter archivo = new StreamWriter(patch))
                {
                    archivo.WriteLine(richTextBox1.Text);
                }

            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(patch)) //Voy a escribir un archivo //(la ruta del archivo que voy a guardar)
                {
                    archivo.Write(richTextBox1.Text);
                }

            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();  //Para que se limpie
            patch = "";
            saved = false;
        }

        private void SFD_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OFP_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
             texto = richTextBox1.Text;
            string[] palabra = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            ssTrip.Text = palabra.Length + "palabra";
            
        }

       
        

        private void ssTrip_Click(object sender, EventArgs e)
        {
            string[] palabra = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos=texto.Split(new char[] { '\n' },StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("estadisticas:\n\nPalabras:    " + palabra.Length.ToString ()+
                "\nLetras" + texto.Length.ToString()+
                "\nParrafos"+parrafos.Length.ToString(), "contenedor de Palabras");
        }
    }
}