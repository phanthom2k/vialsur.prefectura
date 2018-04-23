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
    using System.Data;

    public class uc_Catalogo_Parte_Principal : ComboBox 
    {
        #region UI
        public uc_Catalogo_Parte_Principal()
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
                DataTable dt_Catalogo = new logica.vialsur.prefectura.Catalogos.cls_logica_catalogo_parte_principal().ListarCatalogoPartesPrincipal();
                DataRow dr_0 = dt_Catalogo.NewRow();
                dr_0["id"] = 0;
                dr_0["nombre"] = "Seleccione";

                dt_Catalogo.Rows.InsertAt(dr_0, 0);

                this.ValueMember = "id";
                this.DisplayMember = "nombre";
                //this.SelectedValue = "ECU";
                this.DataSource = dt_Catalogo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR-uc_Catalogo_Parte_Principal" + ex.Message);
            }
        }


    }
}
