using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRegristro
{
    public partial class frmRegistro : Form
    {
        string[] VectorActividades = new string[3];
        string[] VectorDatos = new string[5];
        string varReunion;
        string varTareas;
        frmMostrar ventanaMostrar = new frmMostrar();
        int IndiceFilaRegistro;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mrcTareas_Enter(object sender, EventArgs e)
        {
            if (optSi.Checked == true) 
            { 
              mrcTareas. Enabled = true ;
            }
            else
            {
                mrcTareas.Enabled = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value>= DateTime.Today)
            {
                if (cboTipoActividad.SelectedIndex != -1) 
                {
                    if (optSi.Checked == true)
                    {
                        varReunion = "Si";
                    }
                    else
                    {
                        varReunion = "No";
                    }
                    
                    if (txtDetalleActividad.Text != "") 
                    {
                        MessageBox.Show("¿Grabar?");

                        ventanaMostrar.MatrizActividad[IndiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        ventanaMostrar.MatrizActividad[IndiceFilaRegistro, 1] = cboTipoActividad.Text;
                        ventanaMostrar.MatrizActividad[IndiceFilaRegistro, 2] = txtDetalleActividad.Text;
                    }
                    else
                    {
                        MessageBox.Show("Falta completar Detalle Actividad");
                        txtDetalleActividad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad");
                    cboTipoActividad.Focus();
                }
               
            }
            else
            {
                MessageBox.Show("Tiene que ser una fecha actual o hacia futuro","Cargar tarea",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
            
        }


        private void cboTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cboTipoActividad.Items.Add("Actividad 1");
            cboTipoActividad.Items.Add("Actividad 2");
            cboTipoActividad.Items.Add("Actividad 3");
            

        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.ShowDialog();
           
        }
    }
}
