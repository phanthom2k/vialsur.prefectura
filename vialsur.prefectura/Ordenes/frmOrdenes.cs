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
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ///NUEVA ORDERDEN
            ///
            frmSeleccionarVehiculo Paso_1 = new frmSeleccionarVehiculo();

            Paso_1.ShowDialog();

        }

        void CargarDatosGrilla(string cedula="", string Placa="", string id_orden="")
        {
            try
            {
                DataTable dt = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConnsultarOrdenesAsignadasTecnicosPorCedula_UI(cedula, Placa, id_orden);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        entidades.vialsur.prefectura.per_persona persona_responsable = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                    dt.Rows[i]["cedula_responsable"].ToString());
                        this.dataGridView1.Rows[i].Cells["cedula_responsable"].Value = persona_responsable.apellidos + ", " + persona_responsable.nombres;


                        entidades.vialsur.prefectura.per_persona persona_chofer = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                    dt.Rows[i]["chofer"].ToString());
                        this.dataGridView1.Rows[i].Cells["chofer"].Value = persona_chofer.apellidos + ", " + persona_chofer.nombres;



                        // if (string.IsNullOrEmpty(dt.Rows[i]["MARCA"].ToString()) & string.IsNullOrEmpty(dt.Rows[i]["modelo"].ToString()))
                        //{
                        //    ((DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["cl_marca"]).Style.BackColor = Color.Green;
                        //    ((DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["cl_ve_vehiculo_modelo_id"]).Style.BackColor = Color.Green;
                        //}
                    }

                }

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
                CargarDatosGrilla("1104126626");
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
                CargarDatosGrilla("1104126626", txt_input.Text.ToUpper(), txt_input.Text.ToUpper());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
