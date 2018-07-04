using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Orden
{
    using entidades.vialsur.prefectura;
    using datos.vialsur.prefectura;

    public class cls_logica_orden
    {
        /// <summary>
        /// Consulta el objeto orden y entrega con los objetos dependientes
        /// </summary>
        /// <param name="Id_Orden"></param>
        /// <returns></returns>
        public orden ConsultarOrden(string Id_Orden)
        {
            try
            {
                return new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarOrdenPorId(Id_Orden);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     
        /// <summary>
        /// Registra una orden y retorna el ID de la orden
        /// </summary>
        /// <param name="mi_ve_vehiculo"></param>
        /// <param name="mi_orden"></param>
        /// <param name="mi_orde_detalle"></param>
        /// <returns>IR DE LA ORDEN</returns>
        public string RegistrarOrdenMantenimiento(ve_vehiculo mi_ve_vehiculo, orden mi_orden, List<orde_detalle> mi_orde_detalle) //, ve_vehiculo_responsable mi_ve_vehiculo_responsable)
        {
            try
            {
                var _ve_vehiculo_responsable = new cls_data_ve_vehiculo_responsable();
                ve_vehiculo_responsable mi_ve_vehiculo_responsable = mi_orden.ve_vehiculo_responsable.First();
                int ve_vehiculo_responsable_id = _ve_vehiculo_responsable.Insertar_ve_vehiculo_responsable(mi_ve_vehiculo_responsable);
                
                var _orden = new cls_data_orden();
                mi_orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable_id;
                string orden_id = _orden.Insertar_orden(mi_orden);

                for(int i= 0; i< mi_orde_detalle.Count; i++  )
                {
                    var _orde_detalle = mi_orde_detalle[i];
                    _orde_detalle.orden_id = orden_id;
                    new cls_data_orde_detalle().Insertar_orde_detalle(_orde_detalle);
                }
                return orden_id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Retorna un datatable para ser usado en la grilla del listado de ordenes
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="Placa"></param>
        /// <param name="id_orden"></param>
        /// <param name="estado">-1 representa que no se tome en cuenta el estado durante la busqueda</param>
        /// <returns></returns>
        public System.Data.DataTable ConnsultarOrdenesAsignadasTecnicosPorCedula_UI(string Cedula,string Placa, string id_orden, int estado)
        {
            try
            {
                return new cls_data_orden().ObtenerOrdenesByTecnicoAsignado_UI(Cedula,Placa, id_orden,estado );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna un DataTable personalizado para ser usado en la grilla de la UI
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="Placa"></param>
        /// <param name="id_orden"></param>
        /// <param name="estado">-1 representa que no busque segun el estado</param>
        /// <returns></returns>
        public System.Data.DataTable ConnsultarOrdenesAsignadasTecnicosPorCedula_UI_customized(string Cedula, string Placa, string id_orden, int estado)
        {
            try
            {
                System.Data.DataTable dt =  new cls_data_orden().ObtenerOrdenesByTecnicoAsignado_UI(Cedula, Placa, id_orden, estado);
                //dataGridView1.Columns["tipo_oden"].ValueType = typeof(string);
                // dt.Columns["tipo_oden"].DataType = typeof(string);

                System.Data.DataTable dt_clodana = dt.Clone();
                dt_clodana.Columns["tipo_oden"].DataType = typeof(string);
                dt_clodana.Columns["ve_vehiculo_id"].DataType = typeof(string);
                dt_clodana.Columns["estado"].DataType = typeof(string);
                dt_clodana.Columns["hora"].DataType = typeof(string);

                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    dt_clodana.LoadDataRow(dr.ItemArray, false);
                }
                dt.Clear();
                dt.Dispose();


                for (int i = 0; i < dt_clodana.Rows.Count; i++)
                {
                    entidades.vialsur.prefectura.per_persona persona_responsable = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                dt_clodana.Rows[i]["cedula_responsable"].ToString());

                    dt_clodana.Rows[i]["cedula_responsable"] = persona_responsable.apellidos + ", " + persona_responsable.nombres;
                    
                    entidades.vialsur.prefectura.per_persona persona_chofer = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                dt_clodana.Rows[i]["chofer"].ToString());

                    dt_clodana.Rows[i]["chofer"] = persona_chofer.apellidos + ", " + persona_chofer.nombres;

                    dt_clodana.Rows[i]["tipo_oden"] = Orden_TipoMantenimientoById(int.Parse(dt_clodana.Rows[i]["tipo_oden"].ToString()));

                    dt_clodana.Rows[i]["ve_vehiculo_id"] = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().GetPlacaById(int.Parse(dt_clodana.Rows[i]["ve_vehiculo_id"].ToString()));

                    dt_clodana.Rows[i]["estado"] = Orden_TipoEstadoById(int.Parse(dt_clodana.Rows[i]["estado"].ToString()));
                    dt_clodana.Rows[i]["hora"] = dt_clodana.Rows[i]["hora"].ToString().Substring(0, 5);


                }
                return dt_clodana;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// CONSULTA LAS ORDENES SEGUN EL ESTADO
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public System.Data.DataTable ConnsultarOrdenesSegunEstado_UI_customized(Orden_TipoEstado estado )
        {
            try
            {
                System.Data.DataTable dt = new cls_data_orden().ObtenerOrdenesByEstado_UI(estado);
                
                System.Data.DataTable dt_clodana = dt.Clone();
                dt_clodana.Columns["tipo_oden"].DataType = typeof(string);
                dt_clodana.Columns["ve_vehiculo_id"].DataType = typeof(string);
                dt_clodana.Columns["estado"].DataType = typeof(string);
                dt_clodana.Columns["hora"].DataType = typeof(string);

                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    dt_clodana.LoadDataRow(dr.ItemArray, false);
                }
                dt.Clear();
                dt.Dispose();


                for (int i = 0; i < dt_clodana.Rows.Count; i++)
                {
                    entidades.vialsur.prefectura.per_persona persona_responsable = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                dt_clodana.Rows[i]["cedula_responsable"].ToString());

                    dt_clodana.Rows[i]["cedula_responsable"] = persona_responsable.apellidos + ", " + persona_responsable.nombres;

                    entidades.vialsur.prefectura.per_persona persona_chofer = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                dt_clodana.Rows[i]["chofer"].ToString());

                    dt_clodana.Rows[i]["chofer"] = persona_chofer.apellidos + ", " + persona_chofer.nombres;

                    dt_clodana.Rows[i]["tipo_oden"] = Orden_TipoMantenimientoById(int.Parse(dt_clodana.Rows[i]["tipo_oden"].ToString()));

                    dt_clodana.Rows[i]["ve_vehiculo_id"] = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().GetPlacaById(int.Parse(dt_clodana.Rows[i]["ve_vehiculo_id"].ToString()));

                    dt_clodana.Rows[i]["estado"] = Orden_TipoEstadoById(int.Parse(dt_clodana.Rows[i]["estado"].ToString()));
                    dt_clodana.Rows[i]["hora"] = dt_clodana.Rows[i]["hora"].ToString().Substring(0, 5);


                }
                return dt_clodana;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna un DataTable personalizado para ser usado en la grilla de la UI
        /// </summary>
        /// <param name="IdVehiculo"></param>
        /// <param name="IdOrden"></param>
        /// <returns></returns>
        public System.Data.DataTable ConnsultarOrdenesAsignadasVehiculoPorIdVehiculo_UI_customized(int IdVehiculo, string IdOrden="")
        {
            try
            {
                ve_vehiculo obj_vehiculo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ConsultarDatosVehiculoPorId(IdVehiculo);

                System.Data.DataTable dt = new cls_data_orden().ObtenerOrdenesByIdVehiculoOIdOrden_UI(obj_vehiculo.placa, IdOrden);


                System.Data.DataTable dt_clodana = dt.Clone();
                dt_clodana.Columns["tipo_oden"].DataType = typeof(string);
                dt_clodana.Columns["ve_vehiculo_id"].DataType = typeof(string);
                dt_clodana.Columns["estado"].DataType = typeof(string);
                dt_clodana.Columns["hora"].DataType = typeof(string);

                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    dt_clodana.LoadDataRow(dr.ItemArray, false);
                }
                dt.Clear();
                dt.Dispose();


                for (int i = 0; i < dt_clodana.Rows.Count; i++)
                {
                    entidades.vialsur.prefectura.per_persona persona_responsable = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                dt_clodana.Rows[i]["cedula_responsable"].ToString());

                    dt_clodana.Rows[i]["cedula_responsable"] = persona_responsable.apellidos + ", " + persona_responsable.nombres;

                    entidades.vialsur.prefectura.per_persona persona_chofer = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                                                                                dt_clodana.Rows[i]["chofer"].ToString());

                    dt_clodana.Rows[i]["chofer"] = persona_chofer.apellidos + ", " + persona_chofer.nombres;

                    dt_clodana.Rows[i]["tipo_oden"] = Orden_TipoMantenimientoById(int.Parse(dt_clodana.Rows[i]["tipo_oden"].ToString()));

                    dt_clodana.Rows[i]["ve_vehiculo_id"] = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().GetPlacaById(int.Parse(dt_clodana.Rows[i]["ve_vehiculo_id"].ToString()));

                    dt_clodana.Rows[i]["estado"] = Orden_TipoEstadoById(int.Parse(dt_clodana.Rows[i]["estado"].ToString()));
                    dt_clodana.Rows[i]["hora"] = dt_clodana.Rows[i]["hora"].ToString().Substring(0, 5);


                }
                return dt_clodana;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Transforma el equivalente numerico en el tipo de mantenimiento
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public  string Orden_TipoMantenimientoById(int i)
        {
            return ((Orden_TipoMantenimiento)i).ToString();
            //return i == 1 ? "PREVENTIVO" : "CORRECTIVO";
        }

        /// <summary>
        /// Rtorna el equivalente numerico en el tipo de estado
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string Orden_TipoEstadoById(int i)
        {
            return ((Orden_TipoEstado)i).ToString();
            //return i == 1 ? "CREADO" : i == 2 ? "AUTORIZADO" : i == 3 ? "FINALIZADO" : "DESCARTADO";
        }     

        /// <summary>
        /// Verifica que esten cumplidos los items del detalle de la orden
        /// </summary>
        /// <param name="Id_orden"></param>
        /// <returns></returns>
        public bool VerificarCumplimientoDetallesAsignados(string Id_orden)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_orde_detalle().VerificarCumplimientoDetallesAsignados(Id_orden) == 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
