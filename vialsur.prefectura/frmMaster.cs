using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura
{
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
        }

        
        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form activeChild = this.ActiveMdiChild;
                if (activeChild == null)
                {
                    var vehiculos = new Vehiculos.frmVehiculos();
                    vehiculos.MdiParent = this;
                    vehiculos.WindowState = FormWindowState.Maximized;
                    vehiculos.Show();                    
                }
                /*if (vehiculos == null  )
                {
                    vehiculos = new frm_Master_Vehiculos();
                    vehiculos.MdiParent = this;
                    vehiculos.WindowState = FormWindowState.Maximized;

                    vehiculos.Show();
                }*/
                
                
            }
            catch(Exception ex)
            {

            }

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form activeChild = this.ActiveMdiChild;
                if (activeChild == null)
                {
                    var vehiculos = new Personal.frmPersonal();
                    vehiculos.MdiParent = this;
                   // vehiculos.WindowState = FormWindowState.Maximized;
                    vehiculos.Show();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            try
            {
                Ordenes.frmSeleccionarVehiculo Paso_1 = new Ordenes.frmSeleccionarVehiculo();
                Paso_1.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:"+ex.Message);
            }

        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            try
            {
                var ordenes = new Ordenes.frmOrdenes();
                ordenes.MdiParent = this;

                ordenes.Cedula = "1104126626";

                ordenes.WindowState = FormWindowState.Maximized;
                ordenes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tareasAsignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var ordenes = new Ordenes.frmOrdenes();
                ordenes.MdiParent = this;

                ordenes.Cedula = "1104126626";


                ordenes.WindowState = FormWindowState.Maximized;
                ordenes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void tareasPendientesDeAprobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ordenes.frmOrdenesPendientesAprobacion objFrm = new Ordenes.frmOrdenesPendientesAprobacion();
                objFrm.MdiParent = this;
                objFrm.WindowState = FormWindowState.Maximized;
                objFrm.Estado = entidades.vialsur.prefectura.Orden_TipoEstado.CREADO;
                objFrm.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
