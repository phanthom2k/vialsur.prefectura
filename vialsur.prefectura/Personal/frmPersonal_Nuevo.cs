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
            tabPage2.Enabled = false;
        }


        public bool EsNuevo { get; set; }
        public bool EsVer { get; set; }


        private void frmPersonal_Nuevo_Load(object sender, EventArgs e)
        {
            uc_CARGO1.CargarDatos();
            uc_TIPOUSUARIO1.CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().ExisteCedula(ntxt_Cedula.Text) |
                   new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ExisteCedula(ntxt_Cedula.Text) )
                {
                    throw new Exception("Cedula del usuario ya registrada");
                }
                entidades.vialsur.prefectura.per_persona persona = new entidades.vialsur.prefectura.per_persona();
                entidades.vialsur.prefectura.emp_empleado empleadi = new entidades.vialsur.prefectura.emp_empleado();





            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al intentar registrar la información. "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void chk_EsUsuario_CheckedChanged(object sender, EventArgs e)
        {
            tabPage2.Enabled = chk_EsUsuario.Checked;
        }
    }
}
