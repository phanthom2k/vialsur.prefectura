﻿using System;
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
    public partial class frmSeleccionarVehiculo : Form
    {
        public frmSeleccionarVehiculo()
        {
            InitializeComponent();
        }

        private void frmSeleccionarVehiculo_Load(object sender, EventArgs e)
        {
            limpiar();                            

        }

        void MostrarInformacionVehiculo(entidades.vialsur.prefectura.ve_vehiculo vehiculo  )
        {            
            try
            {
                if(vehiculo != null)
                {
                    lbk_codigo.Text = vehiculo.codigo;
                    lbl_codigo_anterior.Text = vehiculo.codigo_anterior;
                    entidades.vialsur.prefectura.ve_vehiculo_modelo mod = vehiculo.ve_vehiculo_modelo;
                    entidades.vialsur.prefectura.ve_vehiculo_marca mar = mod.ve_vehiculo_marca;
                    lbl_marca.Text = mar.nombre;
                    lbl_modelo.Text = mod.modelo;
                    lbl_pais_fabricacion.Text = vehiculo.PaisCodigo;
                    entidades.vialsur.prefectura.ve_vehiculo_color col = vehiculo.ve_vehiculo_color;
                    lbl_color.Text = col.nombre_comun;
                    lbl_seriemotor.Text = vehiculo.serie_motor;
                    lbl_seriechasis.Text = vehiculo.serie_chasis;
                    lbl_anofab.Text = vehiculo.anio_fabricacion.ToString();
                    lbl_anocomp.Text = vehiculo.anio_compra.ToString();
                    lbl_placa.Text = vehiculo.placa;
                    lbl_placa_prov.Text = vehiculo.placa_provisional;
                    if(vehiculo.estado != null)
                        lbl_estado.Text = (bool)vehiculo.estado ? "Activo" : "Inactivo";
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

        void limpiar()
        {
            lbk_codigo.Text = lbl_codigo_anterior.Text = lbl_marca.Text = lbl_modelo.Text =
            lbl_pais_fabricacion.Text = lbl_color.Text = lbl_seriemotor.Text =
            lbl_seriechasis.Text = lbl_anofab.Text = lbl_anocomp.Text =
            lbl_placa.Text = lbl_placa_prov.Text = lbl_estado.Text = string.Empty;
        }

        entidades.vialsur.prefectura.ve_vehiculo obj_vehiculo;
        /// <summary>
        /// Obtiene o establece la informacion del vehiculo que se usara
        /// </summary>
        public entidades.vialsur.prefectura.ve_vehiculo Obj_vehiculo
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


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                if(!string.IsNullOrEmpty(txt_ParametroABuscar.Text ) )                    
                {
                    obj_vehiculo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ConsultarDatosVehiculo(txt_ParametroABuscar.Text,
                      Convert.ToInt32(groupBox1.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault().Tag.ToString()));
                    if (obj_vehiculo != null & obj_vehiculo.estado != null)
                        MostrarInformacionVehiculo(obj_vehiculo);
                }
//int.Parse(groupBox1.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault().Tag.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_ParametroABuscar.Text = string.Empty;
            limpiar();
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            
            frmDesignacionMantenimientoRespondable frm_designacion = new frmDesignacionMantenimientoRespondable();
            frm_designacion.Obj_vehiculo = Obj_vehiculo;
            this.Hide();
            frm_designacion.ShowDialog();
            this.Close();

        }
    }
}
