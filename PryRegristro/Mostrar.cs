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
        public string[,] MatrizActividad = new string[3, 5];
        int Indicefilas, Indicecolumnas;

        public frmMostrar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int Indicefilas = 0; Indicecolumnas < MatrizActividad.GetLength(0); Indicefilas++)
                if (MatrizActividad[Indicefilas,1] != null)
                {
                    dtgvRegistro.Rows.Add(MatrizActividad[Indicecolumnas, 0],
                     MatrizActividad[Indicecolumnas, 1],
                     MatrizActividad[Indicecolumnas, 2],
                     MatrizActividad[Indicecolumnas, 3],
                     MatrizActividad[Indicecolumnas, 4]);

                }
                    
           
            
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
                if (MatrizActividad[Indicefilas, Indicecolumnas] != null)
                {
                    dtgvRegistro.Rows.Add(Indicefilas, Indicecolumnas);
                }
                Indicefilas++;
            }
            Indicefilas++;






        }
    }
}
