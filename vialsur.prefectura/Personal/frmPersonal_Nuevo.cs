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
        }


        public bool EsNuevo { get; set; }
        public bool EsVer { get; set; }


        private void frmPersonal_Nuevo_Load(object sender, EventArgs e)
        {
            uc_CARGO1.CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
