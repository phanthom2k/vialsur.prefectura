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

            if (EsVer & EsModificar)  //solo para mostrar los datos
            {
                
                //aqui va los elementos cargados implementar la consulta
                //persona = new entidades.vialsur.prefectura.per_persona();
                //empleado = new entidades.vialsur.prefectura.emp_empleado();


            }
            else  //es nuevo  //esto no topo ya
            {
                persona = new entidades.vialsur.prefectura.per_persona();
                empleado = new entidades.vialsur.prefectura.emp_empleado();
            }
                   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        entidades.vialsur.prefectura.per_persona persona;
        entidades.vialsur.prefectura.emp_empleado empleado;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try   
            {                
                if (new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().ExisteCedula(ntxt_Cedula.Text) &
                    new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ExisteCedula(ntxt_Cedula.Text))
                {
                    throw new Exception("Cedula del usuario ya registrada");
                }
                
                    //persona = new entidades.vialsur.prefectura.per_persona();
                    persona.cedula = ntxt_Cedula.Text;
                    persona.nombres = ltxt_Nombres.Text.ToUpper();
                    persona.apellidos = ltxt_Apellidos.Text.ToUpper();
                    persona.fecha_nacimiento = dtp_FechaNacimiento.Value;

                    //empleado = new entidades.vialsur.prefectura.emp_empleado();
                    empleado.cedula = persona.cedula;
                    empleado.cargo_id = Convert.ToInt32(uc_CARGO1.SelectedValue);
                    empleado.pwd = empleado.cedula;
                    empleado.activo = chk_Activo.Checked;
                    empleado.fecha_activacion = dtp_FechaActivacion.Value;

                    if (chk_Activo.Checked)
                    {
                        empleado.fecha_desactivacion = dtp_FechaDesactivacion.Value;
                    }
                    empleado.tipo_usuario = Convert.ToInt32(uc_TIPOUSUARIO1.SelectedValue);

                    empleado.per_persona_cedula_activacion = "1104126626";
                    empleado.observaciones_activacion = empleado.observaciones_desactivacion =
                                                        atxt_Observaciones.Text.ToUpper();

                    
                if (EsNuevo)
                {
                    new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Nueva_Per_Persona(persona);
                    new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().Nuevo_Emp_Empleado(empleado);

                    MessageBox.Show("Se registro los datos correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(EsModificar)
                {
                    //implemenyar lo de modificar
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
