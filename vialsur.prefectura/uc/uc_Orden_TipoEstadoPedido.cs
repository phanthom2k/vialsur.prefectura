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

    public class uc_Orden_TipoEstadoPedido : ComboBox 
    {
        #region UI
        public uc_Orden_TipoEstadoPedido()
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


        //if you have DropDownList object called ddl you can do it as below

        //ddl.DataSource = Enum.GetNames(typeof(EmployeeType));
        //ddl.DataBind();

        //if you want the Enum value Back on Selection....

        // EmployeeType empType = (EmployeeType)Enum.Parse(typeof(EmployeeType), ddl.SelectedValue);


        /// <summary>
        /// Muestra todas las ordenes
        /// </summary>
        public void CargarDatos()
        {
            try
            {
                var e = Enum.GetNames(typeof(entidades.vialsur.prefectura.Orden_TipoEstadoPedido));
               // e[0] = "Seleccione";

                this.DataSource = e ;
               // this.ValueMember = "id";
                         
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR-uc_TipoOEstadosOrdenes" + ex.Message);
            }
        }

        

    }
}






