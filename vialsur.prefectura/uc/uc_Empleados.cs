﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vialsur.prefectura.uc
{
    using System.Windows.Forms;
    using System.Drawing;
    using logica.vialsur.prefectura;
    using entidades.vialsur.prefectura;
    public class uc_Empleados : ComboBox
    {
        #region UI
        public uc_Empleados()
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

        /// <summary>
        /// Carga los empleados acorde al TIPO DE USUARIO, ESTADO (ACTIVO/INACTIVO) Y EL TIPO_MANTENIMIENTO_ASIGNADO (EL MECANICO)
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="activo"></param>
        /// <param name="_Tipo_Mantenimiento_Asignado"></param>
        public void CargarDatos(entidades.vialsur.prefectura.TipoUsuario emp, bool activo, 
            Tipo_Mantenimiento_Asignado _Tipo_Mantenimiento_Asignado = Tipo_Mantenimiento_Asignado.NO_DEFINIDO)
        {
            try
            {
                this.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_emp_empleado().ListarPersonasPorTipoUsuario_UX(emp, activo, _Tipo_Mantenimiento_Asignado);
                this.ValueMember = "cedula";
                this.DisplayMember = "nombre";
                //this.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR-uc_Empleados" + ex.Message);
            }
        }

    }
}
