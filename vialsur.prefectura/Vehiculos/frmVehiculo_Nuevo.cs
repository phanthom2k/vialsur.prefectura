﻿using System;
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

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("floppy-icon48x48.png", "save");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "save";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";


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

            atxt_codigo.ReadOnly = atxt_codigoanterior.ReadOnly = atxt_seriemotor.ReadOnly = atxt_seriechasis.ReadOnly = 
            atxt_placa.ReadOnly = atxt_placaprovisional.ReadOnly = ntxt_cilindraje.ReadOnly = dtxt_costo.ReadOnly = congelar;

            cmb_Marca.Enabled = cmb_modelo.Enabled = cmb_pais.Enabled = cmb_color.Enabled = !congelar;
            nud_anofabricacion.ReadOnly = nud_anocompra.ReadOnly = !congelar;

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
        public bool EsVer { get; set; }
        private void frmVehiculo_Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                if (EsVer)
                    toolStripButton2.Enabled = false;
                else toolStripButton2.Enabled = true;

                if (EsNuevo)
                {
                    obj_vehiculo = new entidades.vialsur.prefectura.ve_vehiculo();
                }
                else //actualizacion
                {
                    ///obj_vehiculo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ConsultarDatosVehiculoPorId(10);
                    obj_vehiculo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ConsultarDatosVehiculoPorId(Id);
                    chk_activo.Checked = (bool) obj_vehiculo.estado;
                    atxt_codigo.Text = obj_vehiculo.codigo;
                    atxt_codigoanterior.Text = obj_vehiculo.codigo_anterior;
                    cmb_Marca.SelectedValue = obj_vehiculo.ve_vehiculo_marca_id;
                    cmb_modelo.SelectedValue = obj_vehiculo.ve_vehiculo_modelo_id;
                    cmb_pais.SelectedValue = obj_vehiculo.PaisCodigo;
                    cmb_color.SelectedValue = obj_vehiculo.ve_vehiculo_color_id;
                    atxt_seriemotor.Text = obj_vehiculo.serie_motor;
                    atxt_seriechasis.Text = obj_vehiculo.serie_chasis;
                    nud_anofabricacion.Value = (decimal)obj_vehiculo.anio_fabricacion;
                    nud_anocompra.Value = (decimal)obj_vehiculo.anio_compra;
                    atxt_placa.Text = obj_vehiculo.placa;
                    atxt_placaprovisional.Text = obj_vehiculo.placa_provisional;
                    dtxt_costo.Text = obj_vehiculo.costo.ToString();
                    ntxt_cilindraje.Text = obj_vehiculo.cilindraje;
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

        private void nud_anocompra_ValueChanged(object sender, EventArgs e)
        {
            nud_anocompra.Minimum = nud_anofabricacion.Value;
        }

        private void nud_anofabricacion_ValueChanged(object sender, EventArgs e)
        {
            nud_anocompra.Minimum = nud_anofabricacion.Value;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                bool _f = false;
                if (VerificarCampos())
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

                    if (EsNuevo)
                    {
                        _f = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().Nuevo(obj_vehiculo);
                        Freeze();
                        MessageBox.Show("Datos registrados", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        EsNuevo = false;
                    }
                    else
                    {
                        _f = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ActualizarPorId(obj_vehiculo);
                        MessageBox.Show("Datos actualizados con exito", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
