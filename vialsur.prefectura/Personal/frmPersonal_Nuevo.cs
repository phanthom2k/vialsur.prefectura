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
    public partial class frmPersonal_Nuevo : Form
    {
        public frmPersonal_Nuevo()
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


            if (EsVer)
                toolStripButton2.Enabled = false;

        }


        public bool EsNuevo { get; set; }
        public bool EsVer { get; set; }
        public bool EsModificar { get; set; }

        public string Cedula { get; set; }


        private void frmPersonal_Nuevo_Load(object sender, EventArgs e)
        {
            uc_CARGO1.CargarDatos();
            uc_TIPOUSUARIO1.CargarDatos();

            if (EsVer | EsModificar)  //solo para mostrar los datos
            {
                persona = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(Cedula);
                empleado = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().Consultar_Emp_Empleado(Cedula);

                ntxt_Cedula.Enabled = false;
                ntxt_Cedula.Text = persona.cedula;
                ltxt_Nombres.Text = persona.nombres;
                ltxt_Apellidos.Text = persona.apellidos;
                dtp_FechaNacimiento.Value = (DateTime)persona.fecha_nacimiento;


                uc_CARGO1.SelectedValue = empleado.cargo_id;
                chk_Activo.Checked = (bool)empleado.activo;
                dtp_FechaActivacion.Value = (DateTime)empleado.fecha_activacion;

                textBox1.Text = empleado.pwd;

                if ((bool)empleado.activo)
                {
                    dtp_FechaDesactivacion.Value = (DateTime)empleado.fecha_desactivacion;
                }
                uc_TIPOUSUARIO1.SelectedValue = empleado.tipo_usuario;
                atxt_Observaciones.Text = empleado.observaciones_activacion + "\n" + empleado.observaciones_desactivacion;                

            }
            else  //es nuevo  //esto no topo ya
            {
                persona = new entidades.vialsur.prefectura.per_persona();
                empleado = new entidades.vialsur.prefectura.emp_empleado();
                empleado.per_persona_cedula_activacion = EmpleadoUsuario.cedula;  //se trae desde el evento guardar (en caso de ver o modificar no es necesario)
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        entidades.vialsur.prefectura.per_persona persona;
        entidades.vialsur.prefectura.emp_empleado empleado;

        /// <summary>
        /// Esta propiedad es para enviar el objeto emp_empleado que representa al administrador que este operando
        /// </summary>
        public entidades.vialsur.prefectura.emp_empleado EmpleadoUsuario;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try   
            {                
                
                //persona = new entidades.vialsur.prefectura.per_persona();
                persona.cedula = ntxt_Cedula.Text;
                persona.nombres = ltxt_Nombres.Text.ToUpper();
                persona.apellidos = ltxt_Apellidos.Text.ToUpper();
                persona.fecha_nacimiento = dtp_FechaNacimiento.Value;

                //empleado = new entidades.vialsur.prefectura.emp_empleado();
                empleado.cedula = persona.cedula;
                empleado.cargo_id = Convert.ToInt32(uc_CARGO1.SelectedValue);
                //empleado.pwd = empleado.cedula;
                empleado.pwd = textBox1.Text;  //CLAVE 10 letras maximo
                empleado.activo = chk_Activo.Checked;
                empleado.fecha_activacion = dtp_FechaActivacion.Value;

                if (chk_Activo.Checked)
                {
                    empleado.fecha_desactivacion = dtp_FechaDesactivacion.Value;
                }
                empleado.tipo_usuario = Convert.ToInt32(uc_TIPOUSUARIO1.SelectedValue);

                //si hay una persona con rol de admin (se mueve esto al load)
                //empleado.per_persona_cedula_activacion = "1104126626";
                

                empleado.observaciones_activacion = empleado.observaciones_desactivacion =
                                                    atxt_Observaciones.Text.ToUpper();

                    
                if (EsNuevo & MessageBox.Show("Desea guardar la información","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
                {
                    if (new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().ExisteCedula(ntxt_Cedula.Text) &
                    new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ExisteCedula(ntxt_Cedula.Text))
                    {
                        throw new Exception("Cedula del usuario ya registrada");
                    }

                    new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Nueva_Per_Persona(persona);
                    new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().Nuevo_Emp_Empleado(empleado);

                    MessageBox.Show("Se registro los datos correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(EsModificar & MessageBox.Show("Desea guardar la información", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Actualizar_Per_Persona(persona);
                    new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().Actualizar_Emp_Empleado(empleado);

                    MessageBox.Show("Se registro los datos correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al intentar registrar la información. "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void chk_Activo_CheckedChanged(object sender, EventArgs e)
        {
            dtp_FechaDesactivacion.Enabled = !chk_Activo.Checked;
        }
    }
}
