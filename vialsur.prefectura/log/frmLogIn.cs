using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.log
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape )
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text != "" && txtContrasena.Text !="" )
                {
                    bool _valid;
                    entidades.vialsur.prefectura.emp_empleado emp = new logica.vialsur.prefectura.log.cls_log_empleados().Verificar(txtUsuario.Text, txtContrasena.Text, out _valid);
                    var master = new frmMaster();
                    master.Empleado = emp;
                    this.Hide();                   
                    master.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
