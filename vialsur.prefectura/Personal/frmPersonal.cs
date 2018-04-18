﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Personal
{
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersonal_Nuevo frm_Personal = new frmPersonal_Nuevo();
                frm_Personal.EsNuevo = true;
                frm_Personal.EsVer = false;
                frm_Personal.ShowDialog();
                frm_Personal.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            CargarDatosGrilla();
        }

        int pivote = 0;
        private void CargarDatosGrilla(string cedula ="" , bool BusquedaFrontal=true)
        {
            try
            {
                DataTable dt = new DataTable();
                if(cedula=="" & BusquedaFrontal)
                {
                    dt = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonas_UX(ref pivote);
                }
                else
                {

                    dt = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonas_UX(ref pivote, true, cedula);
                }
                    



                //  DataTable dt = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonas_UX(ref pivote);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pivote>=0)
            {
                lblPagActual.Text = pivote.ToString();
                pivote -= 25;
                CargarDatosGrilla("", false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblPagFinal.Text = (pivote + 25).ToString();
            pivote += 25;
            CargarDatosGrilla("", true);

        }
    }
}
