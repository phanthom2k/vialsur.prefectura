using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Catalogos
{
    public partial class frmCatalogo_Modelos_Nuevo : Form
    {
        public frmCatalogo_Modelos_Nuevo()
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

            uc_TipoCombustible1.CargarDatos();
            uc_VehiculoTipo1.CargarDatos();
            uc_ClaseVehiculo1.CargarDatos();
            uc_VehiculoMarca1.CargarDatos();

        }

        public bool EsNuevo { get; set; }
        public int Id_Modelo { get; set; }
        public string Marca { get; set; }

        entidades.vialsur.prefectura.ve_vehiculo_modelo modelo;

        private void frmCatalogo_Modelos_Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                if(!EsNuevo)
                {
                    modelo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_modelo().ConsultarModeloPorId(Id_Modelo);
                    //label8.Text = Marca;
                    uc_VehiculoMarca1.SelectedValue = modelo.ve_vehiculo_marca_id;
                    uc_VehiculoMarca1.Enabled = false;
                    textBox2.Text = modelo.modelo;
                    textBox1.Text = modelo.observacion;
                    checkBox1.Checked = (bool)modelo.traccion;
                    //uc_TipoCombustible1.SelectedValue = modelo.tipo_combustible;
                    uc_TipoCombustible1.SelectedIndex = (int)modelo.tipo_combustible;
                    //uc_VehiculoTipo1.SelectedValue = modelo.ve_vehiculo_tipo_id;
                    uc_VehiculoTipo1.SelectedValue = modelo.ve_vehiculo_tipo_id;
                    //uc_ClaseVehiculo1.SelectedValue = modelo.clase_vehiculo;
                    uc_ClaseVehiculo1.SelectedIndex = (int) modelo.clase_vehiculo;
                }
                else
                    modelo = new entidades.vialsur.prefectura.ve_vehiculo_modelo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema:"+ex.Message);
            }
        }

        /// <summary>
        /// Verifica que todos los campos esten llenos
        /// </summary>
        /// <returns></returns>
        bool verificar()
        {
            bool _k = true;
            if(EsNuevo)
            {
                if (uc_VehiculoMarca1.SelectedIndex == 0)
                    _k = false;
            }
            if (textBox2.Text == "")
                _k = false;
            if (uc_TipoCombustible1.SelectedIndex == 0)
                _k = false;
            if (uc_VehiculoTipo1.SelectedIndex == 0)
                _k = false;
            if (uc_ClaseVehiculo1.SelectedIndex == 0)
                _k = false;
            return _k;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {   //guardar
            try
            {
                if(MessageBox.Show("¿Desea registrar la información?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes )
                {
                    if(!verificar())
                    {
                        MessageBox.Show("No se ha ingresado todos los campos","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                    modelo.modelo = textBox2.Text;
                    modelo.observacion = textBox1.Text;
                    modelo.traccion = checkBox1.Checked;
                    modelo.tipo_combustible = uc_TipoCombustible1.SelectedIndex;  //1gas 2dies
                    modelo.ve_vehiculo_tipo_id = (int)uc_VehiculoTipo1.SelectedValue;  //1livia  2pesa  3nodef
                    modelo.clase_vehiculo = uc_ClaseVehiculo1.SelectedIndex;  //1camioneta  2auto  3camion  4bus
                    modelo.tipo_motor = 0;

                    if (EsNuevo)
                    {
                        modelo.ve_vehiculo_marca_id = (int)uc_VehiculoMarca1.SelectedValue;
                        new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_modelo().Insertar(modelo);
                    }
                    else   //actualizacion
                    {                       
                        new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_modelo().Actualizar(modelo);                        
                    }
                    MessageBox.Show("Se han registrado los datos","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al intentar actualizar la información."+ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
