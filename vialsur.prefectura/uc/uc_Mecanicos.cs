using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vialsur.prefectura.uc
{
    using System.Windows.Forms;
    using System.Drawing;
    using logica.vialsur.prefectura;

    public class uc_Mecanicos : ComboBox
    {
        #region UI
        public uc_Mecanicos()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DropDownWidth = Ancho;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        public int Ancho
        {
            get
            {
                if (this.DropDownWidth == 0)
                    return 300;
                else
                    return this.DropDownWidth;
            }
            set
            {
                this.DropDownWidth = value;
            }
        }
        #endregion

        public void CargarDatos()
        {
            try
            {
                //this.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo_color().UX_Consulta_Todos_Registros();
                //this.ValueMember = "id";
                //this.DisplayMember = "nombre_especifico";
                //this.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR-uc_VehiculoColor" + ex.Message);
            }
        }

    }
}
