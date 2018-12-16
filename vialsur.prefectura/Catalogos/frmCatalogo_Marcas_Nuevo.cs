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
    public partial class frmCatalogo_Marcas_Nuevo : Form
    {
        public frmCatalogo_Marcas_Nuevo()
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

        }

        /// <summary>
        /// ID de la marca, en caso de que se desee modificar
        /// </summary>
        public int Id_Marca { get; set; }

        /// <summary>
        /// EsNUEVO (TRUE)  = NUEVA MARCA 
        /// EsNUEVO (FALSE)  = ACTUALIZACION
        /// </summary>
        public bool EsNuevo { get; set; }

        entidades.vialsur.prefectura.ve_vehiculo_marca marca;

        private void frmCatalogo_Marcas_Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                if(!EsNuevo) //en el caso de que es nueva marca
                {
                    marca = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().InformacionMarca(Id_Marca);
                    textBox1.Text = marca.nombre;
                    textBox2.Text = marca.obserbacion;
                    chk_Estado.Checked = (bool)marca.activo;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar consultar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try  //GUARDAR
            {
                if(MessageBox.Show("¿Desea guardar la información?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes )
                {
                    this.DialogResult = DialogResult.Yes;
                    if(EsNuevo)  //registrar una marca nueva
                    {  
                        marca = new entidades.vialsur.prefectura.ve_vehiculo_marca();
                        marca.nombre = textBox1.Text.ToUpper();
                        marca.obserbacion = textBox2.Text.ToUpper();
                        marca.activo = chk_Estado.Checked;
                        new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().InsertarMarca(marca);                        
                    }
                    else  ///actualizar marca
                    {                        
                        marca.id = Id_Marca;
                        marca.nombre = textBox1.Text.ToUpper();
                        marca.obserbacion = textBox2.Text.ToUpper();
                        marca.activo = chk_Estado.Checked;

                        //llamar a actualizacion
                        new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_marca().ActualizarMarca(marca);

                    }
                    MessageBox.Show("Información registrada con exito","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar consultar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }
    }
}
