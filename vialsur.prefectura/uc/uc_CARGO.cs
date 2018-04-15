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

    public class uc_CARGO : ComboBox
    {
        public uc_CARGO()
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

        public void CargarDatos()
        {
            try
            {
                System.Data.DataTable _dt_catalogo = new System.Data.DataTable();
                                    
                _dt_catalogo.Columns.Add(new System.Data.DataColumn("id", Type.GetType("System.Int32")));
                _dt_catalogo.Columns.Add(new System.Data.DataColumn("descripcion", Type.GetType("System.String")));

                System.Data.DataRow dr0 = _dt_catalogo.NewRow();
                dr0["id"] = 0;
                dr0["descripcion"] = "Seleccione";
                _dt_catalogo.Rows.Add(dr0);


                System.Data.DataRow dr1 = _dt_catalogo.NewRow();
                dr1["id"] = 1;
                dr1["descripcion"] = "ADMINISTRADOR";
                _dt_catalogo.Rows.Add(dr1);

                System.Data.DataRow dr2 = _dt_catalogo.NewRow();
                dr2["id"] = 2;
                dr2["descripcion"] = "CHOFER";
                _dt_catalogo.Rows.Add(dr2);

                System.Data.DataRow dr3 = _dt_catalogo.NewRow();
                dr3["id"] = 3;
                dr3["descripcion"] = "MECANICO";
                _dt_catalogo.Rows.Add(dr3);

                System.Data.DataRow dr4 = _dt_catalogo.NewRow();
                dr4["id"] = 4;
                dr4["descripcion"] = "ADMINISTRATIVO";
                _dt_catalogo.Rows.Add(dr4);

                this.DataSource = _dt_catalogo; 
                this.ValueMember = "id";
                this.DisplayMember = "descripcion";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al cargar el catalogo de cargos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
