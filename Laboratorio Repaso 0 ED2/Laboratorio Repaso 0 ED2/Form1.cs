using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Repaso_0_ED2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //List<List<string>> listas = new List<List<string>>();
            

        }
        public Dictionary<string, List<string>> listas = new Dictionary<string, List<string>>();
        public List<string> temporal = new List<string>();
        public string listaactual = "";
        public int tamañolista = 0;
        //public List<>

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clista_Click(object sender, EventArgs e)
        {
            if (txtNombreL.Text != null)
            {
                string nombrelista = txtNombreL.Text;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //string path = openFileDialog1.FileName;
                    //axWindowsMediaPlayer1.URL = path;
                    List<string> playlist = openFileDialog1.FileNames.ToList();
                    ListaActual.Items.AddRange(playlist.ToArray());
                    listas.Add(nombrelista, playlist);
                    comboBox1.Items.AddRange(playlist.ToArray());
                    temporal = listas[nombrelista];
                    tamañolista = temporal.Count;
                }
            }
            else
            {
                
            }
            
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void ListaActual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaactual = comboBox1.SelectedText;
            temporal = listas[listaactual];
            tamañolista = temporal.Count;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string busqueda = txt1.Text;
            for (int i = 0; i < tamañolista; i++)
            {
                if (listaactual[tamañolista].Equals(busqueda))
                {
                    ListaActual.SetSelected(tamañolista, true);
                }
                else
                {
                    MessageBox.Show("No se encontro la cancion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
