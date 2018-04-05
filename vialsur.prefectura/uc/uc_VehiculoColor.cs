using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vialsur.prefectura.uc
{
    using System.Windows.Forms;
    using System.Drawing;

    public class uc_VehiculoColor : ComboBox
    {
        #region UI
        public uc_VehiculoColor()
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR-uc_VehiculoColor"+ex.Message);                
            }
        }


    }

 
}
