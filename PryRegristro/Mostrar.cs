using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRegristro
{
    public partial class frmMostrar : Form
    {
        public string[,] MatrizActividad = new string[5, 5];
        int Indicefilas, Indicecolumnas;

        public frmMostrar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {     

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            Indicecolumnas = 0;
            Indicefilas = 0;

            while (Indicefilas < MatrizActividad.GetLength(0)) 
            {

                dtgvRegistro.Rows.Add(MatrizActividad[Indicefilas, 0],
                 MatrizActividad[Indicefilas, 1],
                 MatrizActividad[Indicefilas, 2],
                 MatrizActividad[Indicefilas, 3],
                 MatrizActividad[Indicefilas, 4]);
                Indicefilas++;  
                
            } 
        }
    }
}
