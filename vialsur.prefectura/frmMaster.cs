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

        /// <summary>
        /// Objeto que cuenta con informacion del usuario del sistema
        /// </summary>
        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

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
                    vehiculos.EmpleadoUsuario = Empleado;
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
                ordenes.Empleado = Empleado;
                //ordenes.Cedula = Empleado.cedula;

                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario))
                {
                    tareasPendientesDeAprobarToolStripMenuItem.Visible = true;
                    personalToolStripMenuItem.Visible = true;
                }

                toolStripStatusLabel1.Text = string.Format("USUARIO: {0} / TIPO USUARIO: {1}",
                    new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(Empleado.cedula).ApellidosNombres,
                                             ((entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario )).ToString());

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
                ordenes.Empleado = Empleado;
                //ordenes.Cedula = Empleado.cedula;

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
                objFrm.Empleado = Empleado;
                objFrm.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal.frmMiPerfil miPerfil = new Personal.frmMiPerfil();
            miPerfil.MdiParent = this;
            miPerfil.WindowState = FormWindowState.Maximized;
            miPerfil.Empleado = Empleado;
            miPerfil.Show();
        }
    }
}
