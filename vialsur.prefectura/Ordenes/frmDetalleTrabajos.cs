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
    public partial class frmDetalleTrabajos : Form
    {
        public frmDetalleTrabajos()
        {
            InitializeComponent();
        }


        ve_vehiculo obj_vehiculo;
        /// <summary>
        /// Obtiene o establece la informacion del vehiculo que se usara
        /// </summary>
        public ve_vehiculo Obj_vehiculo
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

        orden obj_orden = new orden();
        public orden Obj_orden
        {
            get
            {
                return obj_orden;
            }

            set
            {
                obj_orden = value;
            }
        }

        //List<Part> parts = new List<Part>();

        List<orde_detalle> detalle = new List<orde_detalle>();

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
                    //lbl_TipoCombustible.Text = (int)mod.tipo_combustible == 1 ? "GASOLINA" : "DIESEL";
                    lbl_TipoCombustible.Text = ((TipoCombustible)mod.tipo_combustible).ToString();
                    //lbl_TipoVehiculo.Text = (int)mod.clase_vehiculo == 1 ? "LIVIANO" :
                    //                        (int)mod.clase_vehiculo == 2 ? "PESADO" : "NO DEFINIDO";
                    lbl_TipoVehiculo.Text = ((TipoClaseVehiculo)mod.clase_vehiculo).ToString();

                    lblNombresMecanicoResponsable.Text =
                        new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                            obj_orden.ve_vehiculo_responsable.Where(r => r.tipo_responsable == (int)TipoResponsable.MECANICO).FirstOrDefault().per_persona_cedula
                            ).GetFullName;

                    lblNombresCustodioVehiculo.Text =
                                        new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                            obj_orden.ve_vehiculo_responsable.Where(r => r.tipo_responsable == (int)TipoResponsable.CUSTODIO).FirstOrDefault().per_persona_cedula
                                            ).GetFullName;

                    lblTipoMantenimiento.Text = ((Orden_TipoMantenimiento)obj_orden.tipo_oden).ToString();

                    //groupBox1.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault().Tag.ToString()));
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

        private void frmDetalleTrabajos_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarInformacionVehiculo(obj_vehiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            frmSeleccionadorTrabajo obj = new frmSeleccionadorTrabajo();
            obj.Obj_vehiculo = this.obj_vehiculo;
            obj.ShowDialog();
            detalle.Add(obj.Obj_orden_detalle);
            dataGridView1.DataSource = detalle;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "clParte")
            {
                if (e.Value != null)
                {
                    e.Value = new logica.vialsur.prefectura.Catalogos.cls_logica_catalogo_parte_principal().Parte_Principal_Get((int)e.Value).nombre;

                    #region comentado

                    // Check for the string "pink" in the cell.
                    //string stringValue = (string)e.Value;
                    //stringValue = stringValue.ToLower();
                    //if ((stringValue.IndexOf("pink") > -1))
                    //{
                    //    e.CellStyle.BackColor = Color.Pink;
                    //}
                    #endregion
                }
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "clSubParte")
            {
                if (e.Value != null)
                {
                    e.Value = new logica.vialsur.prefectura.Catalogos.cls_logica_catalogo_parte_secundaria().Parte_Secundaria_Get((int)e.Value).nombre;
                }
            }
            //else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "clCantidad")
            //{
            //    if (e.Value != null)
            //    {

            //    }
            //}
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "clEstado")
            {
                if (e.Value != null)
                {

                }
            }
        }
    }
}
