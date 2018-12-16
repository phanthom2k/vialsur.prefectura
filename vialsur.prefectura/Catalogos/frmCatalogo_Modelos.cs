using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Catalogos
{
    public partial class frmCatalogo_Modelos : Form
    {
        public frmCatalogo_Modelos()
        {
            InitializeComponent();
            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("file-text-icon48x48.png", "new");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "new";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";
            uc_VehiculoMarca1.CargarDatos();

        }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        private void frmCatalogo_Modelos_Load(object sender, EventArgs e)
        {

        }

        void CargarDatosGrilla()
        {
            try
            {
                if (uc_VehiculoMarca1.SelectedIndex > 0)
                    dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_modelo().ListarModelos_UX(Convert.ToInt32(uc_VehiculoMarca1.SelectedValue));
                //else
                //    dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void uc_VehiculoMarca1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar consultar los modelos registrados." + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try  //nuevo
            {
                var objFromulario = new frmCatalogo_Modelos_Nuevo();
                objFromulario.Text = "Nuevo madelo";
                objFromulario.EsNuevo = true;
                if (objFromulario.ShowDialog() == DialogResult.Yes)
                    CargarDatosGrilla();
                //    dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().Consulta_Todas_Marcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar consultar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmCatalogo_Modelos_Nuevo frm_actualizar = new frmCatalogo_Modelos_Nuevo();
                
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" & dataGridView1.RowCount > 0)
                {
                    frm_actualizar.EsNuevo = false;
                    frm_actualizar.Text = "Actualizar datos de marca";
                    frm_actualizar.Marca = uc_VehiculoMarca1.Text;
                    frm_actualizar.Id_Modelo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());

                    if (frm_actualizar.ShowDialog() == DialogResult.Yes) ;
                     //   dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().Consulta_Todas_Marcas();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar consultar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
