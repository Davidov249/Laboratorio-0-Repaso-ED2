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
            Dictionary<string, List<string>> listas = new Dictionary<string, List<string>>();

        }

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
                    string path = openFileDialog1.FileName;
                    //axWindowsMediaPlayer1.URL = path;
                    List<string> playlist = openFileDialog1.FileNames.ToList();
                    ListaActual.Items.AddRange(playlist.ToArray());
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
    }
}
