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
        
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dtgvRegistro.Rows.Add();

            
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
