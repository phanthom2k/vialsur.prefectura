using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Vehiculos
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void btn_NuevoVehiculo_Click(object sender, EventArgs e)
        {
           
        }

        private void CargarDatosGrilla(string parametro="")
        {
            try
            {
                DataTable dt = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ListarVehiculos_UX(parametro);
                dataGridView1.DataSource = dt;
                Personalizar(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void Personalizar(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // if (string.IsNullOrEmpty(dt.Rows[i]["MARCA"].ToString()) & string.IsNullOrEmpty(dt.Rows[i]["modelo"].ToString()))
                    {
                        ((DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["cl_marca"]).Style.BackColor = Color.Green;
                        ((DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["cl_ve_vehiculo_modelo_id"]).Style.BackColor = Color.Green;
                    }
                }

            }
        }


        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Vehiculos registrados: "+new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ContarVehiculos().ToString();
                CargarDatosGrilla();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible mostrar el numero de registros","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                frm_Vehiculo.EsNuevo = true;
                frm_Vehiculo.EsVer = false;
                frm_Vehiculo.ShowDialog();
                frm_Vehiculo.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el vehiculo: "+ex.Message ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_input.Text))
                    CargarDatosGrilla(txt_input.Text);
                else
                    CargarDatosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible mostrar el numero de registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_input.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if ((dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" | dataGridView1.Columns[e.ColumnIndex].Name == "cl_modificar") & dataGridView1.RowCount > 0 )
                {
                    frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                    frm_Vehiculo.EsNuevo = false;
                    frm_Vehiculo.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    frm_Vehiculo.EsVer = dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" ? true : false;
                    frm_Vehiculo.ShowDialog(); 
                    frm_Vehiculo.Dispose();
                    btn_Buscar_Click(sender, e);
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_historiado" ) //| dataGridView1.Columns[e.ColumnIndex].Name == "cl_modificar") & dataGridView1.RowCount > 0)
                {
                    frmHistoriadoVehiculo frm_historiado = new frmHistoriadoVehiculo();
                    frm_historiado.IdVehiculo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());

                    frm_historiado.Show();

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
                MessageBox.Show("Error al intentar registrar el vehiculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
