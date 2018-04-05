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
            finally
            {

            }
        }
    }
}
