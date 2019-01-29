﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.PedidosFondoRotativo
{
    public partial class frmPedidosFondoRotativoOrden : Form
    {
        public frmPedidosFondoRotativoOrden()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ID DE LA ORDEN DE TRABAJO
        /// </summary>
        public string OrdenID { get; set; }

        public bool FondoRotativo { get; set; }

        entidades.vialsur.prefectura.fondo_pedido pedido;
        private void frmPedidosFondoRotativoOrden_Load(object sender, EventArgs e)
        {
            try
            {  //verificar si esta grabado o si no consultar el pedido normal


                pedido = new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_pedido().Consultar_Pedido(OrdenID);
/*
                //pedido = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().Consultar_Pedido(OrdenID);
                LBL_FECHA.Text = Convert.ToDateTime(pedido.fecha).ToShortDateString();  //Convert.ToDateTime(row("campofecha")).ToString("dd/MM/yyyy");
                LBL_ESTADO.Text = pedido.aprobada ? "APROBADO" : "CREADO";
                if (pedido.aprobada)
                {
                    lettersTextBox1.Enabled = toolStripButton3.Enabled = toolStripButton2.Enabled = false;
                    dataGridView1.Columns["cl_ver"].Visible = dataGridView1.Columns["cl_modificar"].Visible = false;
                }
                LBL_ORDEN.Text = OrdenID;
                lettersTextBox1.Text = pedido.observaciones;
                CargarDatos();
*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
}
