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
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
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

        public string Cedula { get; set; }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ///NUEVA ORDERDEN
            ///
            frmSeleccionarVehiculo Paso_1 = new frmSeleccionarVehiculo();
            Paso_1.ShowDialog();
            //llamar para refrescar la grilla
            //CargarDatosGrilla(Cedula);
            CargarDatosGrilla(Empleado.cedula);
        }

        /// <summary>
        /// OJO IMPLEMENTO SIMILAR EN EL HISTORIADO DE LOS VEHICULOS
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="Placa"></param>
        /// <param name="id_orden"></param>
        void CargarDatosGrilla(string cedula="", string Placa="", string id_orden="")
        {
            try
            {
                DataTable dt = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConnsultarOrdenesAsignadasTecnicosPorCedula_UI_customized(cedula, Placa, id_orden,
                                                                                                    (int) entidades.vialsur.prefectura.Orden_TipoEstado.AUTORIZADO );
                dataGridView1.DataSource = dt;
               // dataGridView1.Columns["tipo_oden"].ValueType = typeof(string);
           /*     if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        entidades.vialsur.prefectura.per_persona persona_responsable = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                    dt.Rows[i]["cedula_responsable"].ToString());
                        this.dataGridView1.Rows[i].Cells["cedula_responsable"].Value = persona_responsable.apellidos + ", " + persona_responsable.nombres;


                        entidades.vialsur.prefectura.per_persona persona_chofer = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                    dt.Rows[i]["chofer"].ToString());
                        this.dataGridView1.Rows[i].Cells["chofer"].Value = persona_chofer.apellidos + ", " + persona_chofer.nombres;
                      //  string g = new logica.vialsur.prefectura.Orden.cls_logica_orden().Orden_TipoMantenimientoById(int.Parse(dt.Rows[i]["tipo_oden"].ToString()));
                      //  this.dataGridView1.Rows[i].Cells["tipo_oden"].Value = g;


                        // if (string.IsNullOrEmpty(dt.Rows[i]["MARCA"].ToString()) & string.IsNullOrEmpty(dt.Rows[i]["modelo"].ToString()))
                        //{
                        //    ((DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["cl_marca"]).Style.BackColor = Color.Green;
                        //    ((DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["cl_ve_vehiculo_modelo_id"]).Style.BackColor = Color.Green;
                        //}
                    }

                }
                */
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            try
            {
                //CargarDatosGrilla(Cedula);
                CargarDatosGrilla(Empleado.cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                //CargarDatosGrilla(Cedula, txt_input.Text.ToUpper(), txt_input.Text.ToUpper());
                CargarDatosGrilla(Empleado.cedula , txt_input.Text.ToUpper(), txt_input.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {           
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")
                {
                   
                    frmDetalleVistaControlador frmDetalle = new frmDetalleVistaControlador();
                    frmDetalle.OrdenID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    frmDetalle.Empleado = Empleado;
                    frmDetalle.ShowDialog();
                    frmDetalle.Dispose();
                    //CargarDatosGrilla(Cedula);
                    CargarDatosGrilla(Empleado.cedula);

                }


                /* frmPersonal_Nuevo frm_personal = new frmPersonal_Nuevo();
                 if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" & dataGridView1.RowCount > 0)
                 {

                     frm_personal.EsVer = true;
                     frm_personal.EsNuevo = false;
                     frm_personal.EsModificar = true;
                     frm_personal.Cedula = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();


                     //frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                     //frm_Vehiculo.EsNuevo = false;
                     //frm_Vehiculo.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                     //frm_Vehiculo.EsVer = dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" ? true : false;
                     //frm_Vehiculo.ShowDialog();
                     //frm_Vehiculo.Dispose();
                     //btn_Buscar_Click(sender, e);
                 }  */

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
