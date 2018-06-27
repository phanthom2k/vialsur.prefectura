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
    using entidades.vialsur.prefectura;
    public partial class frmDetalleVistaControlador : Form
    {
        public frmDetalleVistaControlador()
        {
            InitializeComponent();
        }


        public string OrdenID { get; set; }

        orden obj_orden;

        ve_vehiculo obj_vehiculo;
        /// <summary>
        /// Obtiene o establece la informacion del vehiculo que se usara
        /// </summary>
     /*   public ve_vehiculo Obj_vehiculo
        {
            get
            {
                return obj_vehiculo;
            }

            set
            {
                obj_vehiculo = value;
            }
        }
        */


        private void frmDetalleVistaControlador_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
                obj_orden = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConsultarOrden(OrdenID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " +ex.Message);              
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
                    //  lbl_pais_fabricacion.Text = vehiculo.PaisCodigo;
                    entidades.vialsur.prefectura.ve_vehiculo_color col = vehiculo.ve_vehiculo_color;
                    lbl_color.Text = col.nombre_comun;
                    lbl_seriemotor.Text = vehiculo.serie_motor;
                    lbl_seriechasis.Text = vehiculo.serie_chasis;
                    // lbl_anofab.Text = vehiculo.anio_fabricacion.ToString();
                    //  lbl_anocomp.Text = vehiculo.anio_compra.ToString();
                    lbl_placa.Text = vehiculo.placa;
                    lbl_placa_prov.Text = vehiculo.placa_provisional;
                    if (vehiculo.estado != null)
                        lbl_estado.Text = (bool)vehiculo.estado ? "Activo" : "Inactivo";
                    lbl_TipoCombustible.Text = ((TipoCombustible)mod.tipo_combustible).ToString(); // == 1 ? "GASOLINA" : "DIESEL";
                    //lbl_TipoVehiculo.Text = (int)mod.clase_vehiculo == 1 ? "LIVIANO" :
                    //                        (int)mod.clase_vehiculo == 2 ? "PESADO" : "NO DEFINIDO";
                    lbl_TipoVehiculo.Text = ((TipoClaseVehiculo)mod.clase_vehiculo).ToString();
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


        void CargarDatosGrilla()
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ConsultarDetalleOrdenesByIdOrden_UI(OrdenID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
