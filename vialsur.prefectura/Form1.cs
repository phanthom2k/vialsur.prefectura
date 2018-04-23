using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_Catalogo_Parte_Principal1.CargarDatos();
        }

        private void uc_Catalogo_Parte_Principal1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Catalogo_Parte_Secundaria1.CargarDatos(Convert.ToInt32(uc_Catalogo_Parte_Principal1.SelectedValue),
                                                        entidades.vialsur.prefectura.TipoSubParte__catalogo_parte_secundiaria.LIVIANOS,
                                                        entidades.vialsur.prefectura.Estado_catalogo_parte_secundiaria.ACTIVO);
                                                        
        }
    }
}
