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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersonal_Nuevo frm_Personal = new frmPersonal_Nuevo();
                frm_Personal.EsNuevo = true;
                frm_Personal.EsVer = false;
                frm_Personal.ShowDialog();
                frm_Personal.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
