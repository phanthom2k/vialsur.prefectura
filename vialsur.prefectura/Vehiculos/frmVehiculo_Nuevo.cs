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
    public partial class frmVehiculo_Nuevo : Form
    {
        public frmVehiculo_Nuevo()
        {
            InitializeComponent();

            try
            {
                cmb_color.CargarDatos();
                cmb_Marca.CargarDatos();
                cmb_Marca.Ancho = 300;
                cmb_modelo.CargarDatos();
                cmb_modelo.Ancho = 300;
                cmb_pais.CargarDatos();
                cmb_pais.Ancho = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los catalogos:"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }


        }
        /// <summary>
        /// Modo solo lectura de los controles no permite que se modifiquen por defecto.
        /// </summary>
        /// <param name="congelar">TRUE por defecto, FALSE para habilitarlos</param>
        void Freeze (bool congelar=true)
        {
            atxt_codigo.ReadOnly = atxt_codigoanterior.ReadOnly = atxt_seriemotor.ReadOnly = atxt_seriechasis.ReadOnly = nud_anofabricacion.ReadOnly = nud_anocompra.ReadOnly =
            atxt_placa.ReadOnly = atxt_placaprovisional.ReadOnly = ntxt_cilindraje.ReadOnly = dtxt_costo.ReadOnly = congelar;

            cmb_Marca.Enabled = cmb_modelo.Enabled = cmb_pais.Enabled = cmb_color.Enabled = !congelar;

        }
        bool VerificarCampos()
        {
            bool vc = true;
            error_Provider1.Clear();
            if (cmb_Marca.SelectedIndex == 0)
            {
                error_Provider1.Alerta(cmb_Marca, "Debe seleccionar una marca", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }
            if( cmb_modelo.SelectedIndex == 0 )
            {
                error_Provider1.Alerta(cmb_modelo, "Debe seleccionar un modelo", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }
            if (cmb_pais.SelectedIndex == 0)
            {
                error_Provider1.Alerta(cmb_pais, "Debe seleccionar un pais", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }
            if (cmb_color.SelectedIndex == 0)
            {
                error_Provider1.Alerta(cmb_color, "Debe seleccionar un color", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }                
            if (atxt_seriemotor.TextLength < 3)
            {
                error_Provider1.Alerta(atxt_seriemotor, "Debe ingresar un valor", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }
            if(atxt_seriechasis.TextLength < 3)
            {
                error_Provider1.Alerta(atxt_seriechasis, "Debe ingresar un valor", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }

            if (atxt_placa.TextLength < 3)
            {
                error_Provider1.Alerta(atxt_placa, "Debe ingresar un valor", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }
            if (atxt_placaprovisional.TextLength < 3)
            {
                error_Provider1.Alerta(atxt_placaprovisional, "Debe ingresar un valor", Vivaldi.UserControls.Tipo_EP.Rechazar);
                vc = false;
            }
            return vc;
        }

        public bool EsNuevo  { get; set; }
        public int Id { get; set; }

        private void frmVehiculo_Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                
                if(EsNuevo)
                {
                    obj_vehiculo = new entidades.vialsur.prefectura.ve_vehiculo();


                }
                else //actualizacion
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( "Ocrrio un error: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        private void uc_VehiculoMarca1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmb_Marca.SelectedIndex>0)
                {
                    cmb_modelo.CargarDatos((int)cmb_Marca.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        entidades.vialsur.prefectura.ve_vehiculo obj_vehiculo;
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if( VerificarCampos() )
                {
                    obj_vehiculo.codigo = atxt_codigo.Text;
                    obj_vehiculo.codigo_anterior = atxt_codigoanterior.Text.ToUpper();
                    obj_vehiculo.ve_vehiculo_modelo_id = (int)cmb_modelo.SelectedValue;
                    obj_vehiculo.PaisCodigo = (string)cmb_pais.SelectedValue;
                    obj_vehiculo.ve_vehiculo_color_id = (int)cmb_color.SelectedValue;
                    obj_vehiculo.serie_motor = atxt_seriemotor.Text.Trim().ToUpper();
                    obj_vehiculo.serie_chasis = atxt_seriechasis.Text.Trim().ToUpper();
                    obj_vehiculo.anio_fabricacion = (int)nud_anofabricacion.Value;
                    obj_vehiculo.anio_compra = (int)nud_anocompra.Value;
                    obj_vehiculo.placa = atxt_placa.Text.Trim().ToUpper();
                    obj_vehiculo.placa_provisional = atxt_placaprovisional.Text.Trim().ToUpper();
                    obj_vehiculo.cilindraje = ntxt_cilindraje.Text;
                    obj_vehiculo.estado = chk_activo.Checked;
                    obj_vehiculo.costo = dtxt_costo.DecimalValue;

                    bool _f = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().Nuevo(obj_vehiculo);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: "+ex.Message.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void nud_anocompra_ValueChanged(object sender, EventArgs e)
        {
            nud_anocompra.Minimum = nud_anofabricacion.Value;
        }

        private void nud_anofabricacion_ValueChanged(object sender, EventArgs e)
        {
            nud_anocompra.Minimum = nud_anofabricacion.Value;
        }
    }
}
