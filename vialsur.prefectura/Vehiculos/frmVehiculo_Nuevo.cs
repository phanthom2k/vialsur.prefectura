using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Vehiculos
{
    public partial class frmVehiculo_Nuevo : Form
    {
        public frmVehiculo_Nuevo()
        {
            InitializeComponent();
        }
        public bool EsNuevo  { get; set; }
        public int Id { get; set; }

        private void frmVehiculo_Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                uc_VehiculoColor1.CargarDatos();
                uc_VehiculoMarca1.CargarDatos();
                uc_VehiculoMarca1.Ancho = 300;
                uc_VehiculoModelo1.CargarDatos();
                uc_VehiculoModelo1.Ancho = 300;
                uc_Pais1.CargarDatos();
                uc_Pais1.Ancho = 300;

                if(!EsNuevo)
                {




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( "Ocrrio un error: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        private void uc_VehiculoMarca1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(uc_VehiculoMarca1.SelectedIndex>0)
                {
                    uc_VehiculoModelo1.CargarDatos((int)uc_VehiculoMarca1.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
