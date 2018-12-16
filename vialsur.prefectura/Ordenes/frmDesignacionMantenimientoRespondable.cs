using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades.vialsur.prefectura;

namespace vialsur.prefectura.Ordenes
{
    public partial class frmDesignacionMantenimientoRespondable : Form
    {
        public frmDesignacionMantenimientoRespondable()
        {
            InitializeComponent();

            uc_TipoMantenimiento1.CargarDatos();

            //uc_Empleados1.CargarDatos(entidades.vialsur.prefectura.TipoUsuario.MECANICO, true); //se comenta para que discrimine cuando se seleccion el TIPO DE MANTENIMIENTO

            uc_Empleados2.CargarDatos(entidades.vialsur.prefectura.TipoUsuario.CHOFER, true);
            
        }

        /// <summary>
        /// Representa el usuario
        /// </summary>
        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

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
                    lbl_TipoVehiculo.Text = ((ClaseVehiculo)mod.clase_vehiculo).ToString();
                    label19.Text = new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarKilometrajeDeVehiculo(vehiculo.placa).ToString();
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

        private void frmDesignacionMantenimientoRespondable_Load(object sender, EventArgs e)
        {
            MostrarInformacionVehiculo(obj_vehiculo);

        }
        
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            try
            {

                //FALTA IMPLEMENTAR CONTROLES EN DDBOX

                ve_vehiculo_responsable _mecanico = new ve_vehiculo_responsable();
                _mecanico.per_persona_cedula = uc_Empleados1.SelectedValue.ToString();
                _mecanico.ve_vehiculo_id = obj_vehiculo.id;
                _mecanico.estado = true;
                _mecanico.fecha = DateTime.Today;
                _mecanico.tipo_responsable = (int)TipoResponsable.MECANICO;

                ve_vehiculo_responsable _custodio = new ve_vehiculo_responsable();
                _custodio.per_persona_cedula = uc_Empleados2.SelectedValue.ToString();
                _custodio.ve_vehiculo_id = obj_vehiculo.id;
                _custodio.estado = true;
                _custodio.fecha = DateTime.Today;
                _custodio.tipo_responsable = (int)TipoResponsable.CUSTODIO;

                obj_orden.tipo_oden = (int)uc_TipoMantenimiento1.SelectedValue;
                obj_orden.fecha = DateTime.Today;
                obj_orden.hora = DateTime.Now.TimeOfDay;
                obj_orden.estado = (int)Orden_TipoEstado.CREADO;
                obj_orden.observacion = lettersTextBox1.Text.ToUpper();
                obj_orden.km_ingreso = int.Parse(numericTextBox1.Text);
                obj_orden.ve_vehiculo_responsable.Add(_mecanico);
                obj_orden.ve_vehiculo_responsable.Add(_custodio);

                frmDetalleTrabajos frm_detalles = new frmDetalleTrabajos();
                frm_detalles.Obj_vehiculo = Obj_vehiculo;
                frm_detalles.Obj_orden = Obj_orden;
                frm_detalles.Empleado = Empleado;
                this.Hide();
                frm_detalles.ShowDialog();
                this.Close();


                //frmDesignacionMantenimientoRespondable frm_designacion = new frmDesignacionMantenimientoRespondable();
                //frm_designacion.Obj_vehiculo = Obj_vehiculo;
                //this.Hide();
                //frm_designacion.ShowDialog();
                //this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Existio el siguiente error: "+ex.Message);
            }
        }

        //Verifica que el kilometraje ingresado sea mayor al ultimo
        private void numericTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                var km_registrado = new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarKilometrajeDeVehiculo(obj_vehiculo.placa);
                //if (int.Parse(numericTextBox1.Text) < new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarKilometrajeDeVehiculo(obj_vehiculo.placa))
                if (int.Parse(numericTextBox1.Text) < km_registrado)
                {
                    MessageBox.Show("El kilometraje ingresado es inferior al registrado "+ new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarKilometrajeDeVehiculo(obj_vehiculo.placa));
                    numericTextBox1.BackColor = Color.Red;
                }
                else
                    numericTextBox1.BackColor = Color.White;

            }
            catch (Exception ex)
            {
                MessageBox.Show("El kilometraje ingresado es inferior al registrado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        void VerificarSelecciones()
        {
            if(uc_TipoMantenimiento1.SelectedIndex>0 & uc_Empleados1.SelectedIndex >0  & numericTextBox1.Text != "") //& uc_Empleados2.SelectedIndex >0 )
            {
                btn_Siguiente.Enabled = true;
            }
            else
            {
                 btn_Siguiente.Enabled = false;
            }
        }

        private void uc_TipoMantenimiento1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSelecciones();
            if (uc_TipoMantenimiento1.SelectedIndex == 1) //preventivo
                uc_Empleados1.CargarDatos(entidades.vialsur.prefectura.TipoUsuario.MECANICO, true, Tipo_Mantenimiento_Asignado.PREVENTIVO);
            else
                uc_Empleados1.CargarDatos(entidades.vialsur.prefectura.TipoUsuario.MECANICO, true, Tipo_Mantenimiento_Asignado.CORRECTIVO );
        }

        private void uc_Empleados1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSelecciones();
        }

        private void numericTextBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarSelecciones();
        }
    }
}
