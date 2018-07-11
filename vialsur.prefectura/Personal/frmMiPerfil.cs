using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Personal
{
    public partial class frmMiPerfil : Form
    {
        public frmMiPerfil()
        {
            InitializeComponent();

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("floppy-icon48x48.png", "save");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "save";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";


        }

        /// <summary>
        /// Objeto que cuenta con informacion del usuario del sistema
        /// </summary>
        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        entidades.vialsur.prefectura.per_persona persona;

        private void frmMiPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                uc_CARGO1.CargarDatos();
                uc_TIPOUSUARIO1.CargarDatos();

                persona = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(Empleado.cedula);

                ntxt_Cedula.Text = persona.cedula;
                ltxt_Nombres.Text = persona.nombres;
                ltxt_Apellidos.Text = persona.apellidos;
                dtp_FechaNacimiento.Value = (DateTime)persona.fecha_nacimiento;


                uc_CARGO1.SelectedValue = Empleado.cargo_id;
                chk_Activo.Checked = (bool)Empleado.activo;
                dtp_FechaActivacion.Value = (DateTime)Empleado.fecha_activacion;

                textBox1.Text = textBox2.Text = Empleado.pwd;

                if ((bool)Empleado.activo)
                {
                    dtp_FechaDesactivacion.Value = (DateTime)Empleado.fecha_desactivacion;
                }
                uc_TIPOUSUARIO1.SelectedValue = Empleado.tipo_usuario;
                atxt_Observaciones.Text = Empleado.observaciones_activacion + "\n" + Empleado.observaciones_desactivacion;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cambiar la contraseña","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                if( textBox1.Text.Equals(textBox2.Text) & textBox1.Text.Length > 5 )
                {
                    Empleado.pwd = textBox1.Text;
                    new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().Actualizar_Emp_Empleado_PWD(Empleado);
                    MessageBox.Show("Clave actualizada","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No coincide la clave");
                }
        }
    }
}
