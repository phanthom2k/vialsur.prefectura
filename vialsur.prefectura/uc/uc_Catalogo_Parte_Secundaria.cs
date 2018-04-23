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

    public class uc_Catalogo_Parte_Secundaria : ComboBox
    {

        #region UI
        public uc_Catalogo_Parte_Secundaria()
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


        public void CargarDatos(    int id,
                                    entidades.vialsur.prefectura.TipoSubParte__catalogo_parte_secundiaria tipo_sub_parte,
                                    entidades.vialsur.prefectura.Estado_catalogo_parte_secundiaria estado ) 
        {
            try
            {
                DataTable dt_Catalogo = new logica.vialsur.prefectura.Catalogos.cls_logica_catalogo_parte_secundaria().ListarCatalogoPartesSecundario(id, tipo_sub_parte, estado);

                dt_Catalogo.Columns.Remove("catalogo_parte_principal_id");
                dt_Catalogo.Columns.Remove("estado");
                dt_Catalogo.Columns.Remove("tipo_sub_parte");

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
