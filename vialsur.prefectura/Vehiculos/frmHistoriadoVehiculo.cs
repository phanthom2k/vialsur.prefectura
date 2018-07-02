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
    public partial class frmHistoriadoVehiculo : Form
    {
        public frmHistoriadoVehiculo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ID del Behiculo
        /// </summary>
        public int IdVehiculo { get; set; }

        entidades.vialsur.prefectura.ve_vehiculo obj_vehiculo;

        private void frmHistoriadoVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
                obj_vehiculo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ConsultarDatosVehiculoPorId(IdVehiculo);
                MostrarInformacionVehiculo(obj_vehiculo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("eRROR:"+ex.Message);
            }
        }




        void CargarDatosGrilla(string id_orden = "")
        {
            try
            {
                DataTable dt = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConnsultarOrdenesAsignadasVehiculoPorIdVehiculo_UI_customized(IdVehiculo, id_orden);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void MostrarInformacionVehiculo(entidades.vialsur.prefectura.ve_vehiculo vehiculo)
        {
            try
            {
                if (vehiculo != null)
                {
                    lbk_codigo.Text = vehiculo.codigo;
                    // lbl_codigo_anterior.Text = vehiculo.codigo_anterior;
                    entidades.vialsur.prefectura.ve_vehiculo_modelo mod = vehiculo.ve_vehiculo_modelo;
                    entidades.vialsur.prefectura.ve_vehiculo_marca mar = mod.ve_vehiculo_marca;
                    lbl_marca.Text = mar.nombre;
                    lbl_modelo.Text = mod.modelo;

                    entidades.vialsur.prefectura.ve_vehiculo_color col = vehiculo.ve_vehiculo_color;                    
                    lbl_color.Text = col.nombre_comun;
                    lbl_seriemotor.Text = vehiculo.serie_motor;
                    lbl_seriechasis.Text = vehiculo.serie_chasis;                    
                    lbl_placa.Text = vehiculo.placa;
                    lbl_placa_prov.Text = vehiculo.placa_provisional;
                    if (vehiculo.estado != null)
                        lbl_estado.Text = (bool)vehiculo.estado ? "Activo" : "Inactivo";
                    lbl_TipoCombustible.Text = ((entidades.vialsur.prefectura.TipoCombustible)mod.tipo_combustible).ToString(); // == 1 ? "GASOLINA" : "DIESEL";                    
                    lbl_TipoVehiculo.Text = ((entidades.vialsur.prefectura.TipoClaseVehiculo)mod.clase_vehiculo).ToString();                 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(numericTextBox1.IntValue > 0)
                {
                    CargarDatosGrilla(numericTextBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                numericTextBox1.Text = string.Empty;
                CargarDatosGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
