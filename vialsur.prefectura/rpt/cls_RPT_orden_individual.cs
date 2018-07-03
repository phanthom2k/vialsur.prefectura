using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vialsur.prefectura.rpt
{
    using iTextSharp;
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using iTextSharp.text.xml;
    using System.IO;
    using System.Collections;
    using System.Data;
    using entidades.vialsur.prefectura;
    public class cls_RPT_orden_individual
    {

        public string Orden_Id { get; set; }

        private static string ArchivoFichaUnipropiedad =  @"C:\template_orden_v1.pdf";

        private static string template_1 = System.Environment.CurrentDirectory + "\\template_orden_v1.pdf";

        public string Generar()
        {
            try
            {

                orden obj_orden =  new logica.vialsur.prefectura.Orden.cls_logica_orden().ConsultarOrden(Orden_Id);
                ve_vehiculo_responsable obj_ve_resp = obj_orden.ve_vehiculo_responsable.FirstOrDefault();

                ve_vehiculo obj_vehiculo = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().ConsultarDatosVehiculoPorId((int)obj_ve_resp.ve_vehiculo_id);                                
                ve_vehiculo_color obj_col = obj_vehiculo.ve_vehiculo_color;
                ve_vehiculo_modelo obj_modelo = obj_vehiculo.ve_vehiculo_modelo;
                ve_vehiculo_marca obj_marca = obj_modelo.ve_vehiculo_marca;

                per_persona obj_persona = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(obj_ve_resp.per_persona_cedula);


                PdfReader pdfReader = new PdfReader(template_1);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(@"C:\Temp\1.pdf", FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                //info de la orden
                pdfFormFields.SetField("ORDEN No", String.Format("{0:0000000000000}", obj_orden.id ));
                pdfFormFields.SetField("TIPO DE MANTENIMIENTO", ((entidades.vialsur.prefectura.Orden_TipoMantenimiento) obj_orden.tipo_oden).ToString() );
                pdfFormFields.SetField("MECANICO RESPONSABLE", obj_persona.GetFullName );
                pdfFormFields.SetField("FECHA DE REGISTRO",  obj_orden.fecha.ToString() );
                pdfFormFields.SetField("KILOMENTRAJE DE INGRESO", obj_orden.km_ingreso.ToString()+"Km" );
                pdfFormFields.SetField("KILOMETRAJE DE EGRESO", obj_orden.km_egreso.ToString()+"Km");
                pdfFormFields.SetField("OBSERVACIONES GENERALES", obj_orden.observacion );

                //info del vehiculo
                pdfFormFields.SetField("CODIGO", obj_vehiculo.codigo);
                pdfFormFields.SetField("MARCA", obj_marca.nombre );
                pdfFormFields.SetField("SERIE MOTOR", obj_vehiculo.serie_motor );
                pdfFormFields.SetField("SERIE CHASIS", obj_vehiculo.serie_chasis );
                pdfFormFields.SetField("PLACA", obj_vehiculo.placa );
                pdfFormFields.SetField("TIPO VEHICULO", "" );
                pdfFormFields.SetField("ESTADO", obj_vehiculo.estado.ToString() );
                pdfFormFields.SetField("MODELO", obj_modelo.modelo );
                pdfFormFields.SetField("COLOR", obj_col.nombre_comun);
                pdfFormFields.SetField("PLACA PROVISIONAL", obj_vehiculo.placa_provisional ) ;
                pdfFormFields.SetField("TIPO DE COMBUSTIBLE", ((TipoCombustible)((int)obj_modelo.tipo_combustible)).ToString() );

                //info detalle de trabajos realizados
               

               DataTable dt_detalle = new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ConsultarDetalleOrdenesByIdOrden_UI(Orden_Id);
                for(int i=0; i<dt_detalle.Rows.Count; i++ )
                {
                    
                    pdfFormFields.SetField("PARTE PRINCIPAL_" + (i + 1), dt_detalle.Rows[i]["nombrePP"].ToString()   );                    
                    pdfFormFields.SetField("SUB PARTE_" + (i+1), dt_detalle.Rows[i]["nombrePS"].ToString());
                    pdfFormFields.SetField("TRABAJO REQUERIDO_" + (i + 1), dt_detalle.Rows[i]["accion_requerida"].ToString());
                    pdfFormFields.SetField("TRABAJO REALIZADO_" + (i+1), dt_detalle.Rows[i]["accion_realizada"].ToString()  );
                    pdfFormFields.SetField("CANTIDAD_" + (i+1), dt_detalle.Rows[i]["cantidad"].ToString());                    
                    pdfFormFields.SetField("OBSERVACIONRow1_" + (i+1), dt_detalle.Rows[i]["observacion"].ToString());
                }
                dt_detalle.Clear();
                dt_detalle.Dispose();

                pdfStamper.FormFlattening = false;
                pdfStamper.Close();


                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //C:\Source\Repos\Proyecto\vialsur.prefectura\vialsur.prefectura\bin\Debug


    }

}
