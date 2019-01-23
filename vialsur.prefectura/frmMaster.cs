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
                    vehiculos.Empleado = Empleado;
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
                Paso_1.Empleado = Empleado;
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

                //if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario)) //se comenta para re escribir codigo
                if ( Empleado.tipo_usuario == 1 ) //si el tipo de usuario es administrador
                {
                    tareasPendientesDeAprobarToolStripMenuItem.Visible = true;
                    personalToolStripMenuItem.Visible = true;
                    historialDeOrdenesToolStripMenuItem.Visible = true;
                    caToolStripMenuItem.Visible = true;
                    nuevaOrdenDePartesYPiezasToolStripMenuItem.Visible = true;
                }

                //toolStripStatusLabel1.Text = string.Format("USUARIO: {0} / TIPO USUARIO: {1}",
                //    new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(Empleado.cedula).ApellidosNombres,
                //                             ((entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario )).ToString());
                toolStripStatusLabel1.Text = string.Format("USUARIO: {0} / TIPO DE USUARIO: {1}",
                    new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(Empleado.cedula).ApellidosNombres,
                                                            new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado_tipo_usuario().Consultar_Nombre_Tipo_Usuario_Por_ID(Empleado.tipo_usuario));
                                                             //((entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario)).ToString());

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
            if(MessageBox.Show("¿Desea salir del aplicativo?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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

        private void historialDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var ordenes = new Ordenes.frmOrdenes();
                ordenes.MdiParent = this;
                ordenes.Empleado = Empleado;
                ordenes.Text = "Historial de ordenes";
                ordenes.WindowState = FormWindowState.Maximized;
                ordenes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void catalogoDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {   //CATALOGO DE MARCAS
            try
            {
                Form activeChild = this.ActiveMdiChild;
                if (activeChild == null)
                {

                    var catalogo_marcas = new Catalogos.frmCatalogo_Marcas();
                    catalogo_marcas.MdiParent = this;
                    catalogo_marcas.Empleado = Empleado;
                    catalogo_marcas.WindowState = FormWindowState.Maximized;
                    catalogo_marcas.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void catálogoDeModelosToolStripMenuItem_Click(object sender, EventArgs e)
        {   ///CATALOGO DE MODELOS
            try
            {
                Form activeChild = this.ActiveMdiChild;
                if (activeChild == null)
                {

                    var catalogo_modelo = new Catalogos.frmCatalogo_Modelos();
                    catalogo_modelo.MdiParent = this;
                    catalogo_modelo.Empleado = Empleado;
                    catalogo_modelo.WindowState = FormWindowState.Maximized;
                    catalogo_modelo.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void ordenesDePartesYPiezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nuevaOrdenDePartesYPiezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos.frmPedidosPendientesAprobacion objForm = new Pedidos.frmPedidosPendientesAprobacion();
                objForm.MdiParent = this;
                objForm.WindowState = FormWindowState.Maximized;
                //objForm.Estado = entidades.vialsur.prefectura.Orden_TipoEstado.CREADO;
                //objForm.Empleado = Empleado;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void ordenesDePartesYPiezasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos.frmPedidos objForm = new Pedidos.frmPedidos();
                objForm.MdiParent = this;
                objForm.WindowState = FormWindowState.Maximized;
                objForm.Cedula = Empleado.cedula;
                objForm.Empleado = Empleado;
                //objForm.Estado = entidades.vialsur.prefectura.Orden_TipoEstado.CREADO;
                //objForm.Empleado = Empleado;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
             new AboutBox1().ShowDialog();
        }

 

        private void manualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var manual = new vialsur.prefectura.Ordenes.frmVisorOrden_1();
            manual.RutaArchivo = System.Environment.CurrentDirectory + "\\manualdeusuario_v1.pdf";
            manual.StartPosition = FormStartPosition.CenterScreen;
            manual.ShowDialog();
        }
    }
}
