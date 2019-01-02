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
    public partial class frmCatalogo_Marcas : Form
    {
        public frmCatalogo_Marcas()
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


        }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        private void frmCatalogo_Marcas_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().Consulta_Todas_Marcas();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar consultar"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try  //nuevo
            {
                var objFromulario = new frmCatalogo_Marcas_Nuevo();
                objFromulario.Text = "Nueva marca";
                objFromulario.EsNuevo = true;
                if (objFromulario.ShowDialog()== DialogResult.Yes)
                    dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().Consulta_Todas_Marcas();
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
                frmCatalogo_Marcas_Nuevo frm_actualizar = new frmCatalogo_Marcas_Nuevo();
                //frmPersonal_Nuevo frm_personal = new frmPersonal_Nuevo();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" & dataGridView1.RowCount > 0)
                {
                    frm_actualizar.EsNuevo = false;
                    frm_actualizar.Text = "Actualizar datos de marca";
                    frm_actualizar.Id_Marca = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());

                    if (frm_actualizar.ShowDialog() == DialogResult.Yes)
                        dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().Consulta_Todas_Marcas();

                    //frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                    //frm_Vehiculo.EsNuevo = false;
                    //frm_Vehiculo.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    //frm_Vehiculo.EsVer = dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" ? true : false;
                    //frm_Vehiculo.ShowDialog();
                    //frm_Vehiculo.Dispose();
                    //btn_Buscar_Click(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar consultar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["activo"].Index)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "ACTIVO" : "INACTIVO";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
