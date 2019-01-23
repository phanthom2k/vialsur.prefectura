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

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("file-text-icon48x48.png", "new");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "new";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";

        }

        public entidades.vialsur.prefectura.emp_empleado EmpleadoUsuario;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersonal_Nuevo frm_Personal = new frmPersonal_Nuevo();
                frm_Personal.EmpleadoUsuario = EmpleadoUsuario;
                frm_Personal.EsNuevo = true;
                frm_Personal.EsVer = false;
                frm_Personal.ShowDialog();
                frm_Personal.Dispose();
                CargarDatosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)EmpleadoUsuario.tipo_usuario))
                {
                    toolStripButton2.Visible = true;
                }
                //public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }            
        }

        int pivote = 0;
        int contador = 0;
        private void CargarDatosGrilla(string cedula ="" , bool BusquedaFrontal=true)
        {
            try
            {
                DataTable dt = new DataTable();
                if(cedula=="" & BusquedaFrontal)
                {
                    dt = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonas_UX(ref pivote);
                }
                else
                {

                    dt = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonas_UX(ref pivote, true, cedula);
                }
                contador = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ConsultarNumeroEmpleados();
                //contador = Convert.ToInt32(dt.Compute("COUNT(cedula)", string.Empty));
                //  DataTable dt = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonas_UX(ref pivote);

                DataColumn dtc_activo2 = new DataColumn("activo2", typeof(String));
                dt.Columns.Add(dtc_activo2);
                dataGridView1.DataSource = dt;
                
                for (int i=0; i< dataGridView1.RowCount; i++)
                {
                    if ( Convert.ToBoolean(dataGridView1.Rows[i].Cells["activo"].Value))
                        dataGridView1.Rows[i].Cells["activo2"].Value = "ACTIVO";                        
                    else dataGridView1.Rows[i].Cells["activo2"].Value = "INACTIVO";
                }
                dataGridView1.Update();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pivote > 0)
            {
                lblPagActual.Text = pivote.ToString();
                pivote -= 25;
                CargarDatosGrilla("", false);
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            pivote += 25;

            if (pivote <= contador)
            {
                lblPagFinal.Text = pivote.ToString();
                CargarDatosGrilla("", true);
                //lblPagFinal.Text = (pivote + 25).ToString();
                //pivote += 25;
                //CargarDatosGrilla("", true);
                button5.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                pivote -= 25;
                button5.Enabled = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmPersonal_Nuevo frm_personal = new frmPersonal_Nuevo();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" & dataGridView1.RowCount > 0)
                {
                    
                    frm_personal.EsVer = true;
                    frm_personal.EsNuevo = false;
                    frm_personal.EsModificar = true;
                    frm_personal.Cedula = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();

                    if (frm_personal.ShowDialog() == DialogResult.Yes)
                        CargarDatosGrilla();

                    //frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                    //frm_Vehiculo.EsNuevo = false;
                    //frm_Vehiculo.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    //frm_Vehiculo.EsVer = dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" ? true : false;
                    //frm_Vehiculo.ShowDialog();
                    //frm_Vehiculo.Dispose();
                    //btn_Buscar_Click(sender, e);
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_modificar" & dataGridView1.RowCount > 0)
                {
                    frm_personal.EmpleadoUsuario = EmpleadoUsuario;
                    frm_personal.EsVer = false;
                    frm_personal.EsNuevo = false;
                    frm_personal.EsModificar = true;
                    frm_personal.Cedula = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();

                    if (frm_personal.ShowDialog() == DialogResult.Yes)
                        CargarDatosGrilla();

                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el vehiculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                pivote = 0;
                CargarDatosGrilla(txt_input.Text, false);
            }
            catch (Exception EX)
            {
                MessageBox.Show("Ocurrio un problema al intentar buscar la persona","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pivote = 0;
                txt_input.Text = "";
                CargarDatosGrilla();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Ocurrio un problema al intentar buscar la persona", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["tipousuario"].Index)
            {
                if(e.Value.ToString() == "ADMINISTRADOR")
                {
                    //new Font("Times New Roman", 12.0f);
                    e.CellStyle.Font = new Font("Arial",10f, FontStyle.Bold);
                    e.CellStyle.BackColor = Color.GreenYellow;
                    e.FormattingApplied = true;
                }
                if (e.Value.ToString() == "MECANICO")
                {                                        
                    e.CellStyle.BackColor = Color.Aqua;
                    e.FormattingApplied = true;
                }
                if (e.Value.ToString() == "AYUDANTE DE MECANICA")
                {
                    e.CellStyle.BackColor = Color.Aquamarine;
                    e.FormattingApplied = true;
                }
                if (e.Value.ToString() == "SOLDADOR")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.FormattingApplied = true;
                }
                if (e.Value.ToString() == "ELECTRICISTA")
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.FormattingApplied = true;
                }
            }
            
            if (e.ColumnIndex == dataGridView1.Columns["activo2"].Index)
            {
                if (e.Value.ToString() == "ACTIVO")
                {                    
                    e.CellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
                    e.CellStyle.BackColor = Color.GreenYellow;
                    e.FormattingApplied = true;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["tipo_mantenimiento_asignado"].Index)
            {
                if ((int)e.Value == (int)entidades.vialsur.prefectura.Tipo_Mantenimiento_Asignado.CORRECTIVO)
                {
                    e.CellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
                    e.CellStyle.BackColor = Color.GreenYellow;
                }
                e.Value = ((entidades.vialsur.prefectura.Tipo_Mantenimiento_Asignado)(int)e.Value).ToString();                                
                e.FormattingApplied = true;

                //if (e.Value is bool)
                //{
                //    bool value = (bool)e.Value;
                //    e.Value = (value) ? "ACTIVO" : "INACTIVO";
                //    e.FormattingApplied = true;
                //}

            }



        }
    }
}
