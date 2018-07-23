using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Ordenes
{
    public partial class frmVisorOrden_1 : Form
    {
        public frmVisorOrden_1()
        {
            InitializeComponent();
        }
        
        public string RutaArchivo { get; set; }

        private void frmVisorOrden_1_Load(object sender, EventArgs e)
        {
            try
            {
                axAcroPDF1.Visible = true;
               // this.Text = NombreArchivo;
                axAcroPDF1.src = RutaArchivo;
                axAcroPDF1.setZoom(65);
                //axAcroPDF1.setShowToolbar(true);
            }
           
            catch (Exception ex)
            {
                if(ex.HResult == 80040154 | ex.HResult == 0x80040154)
                {
                    MessageBox.Show("Adobe acrobat no instalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else
                    MessageBox.Show("Ocurrio un problema al intentar abir el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {
                axAcroPDF1.Visible = false;
            }
        }
    }
}
