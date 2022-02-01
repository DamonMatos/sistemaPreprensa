using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprensa.Data
{

   
   
    public class Articulo
    {
        public int NumProducion { get; set; }
        public int IdArticulo { get; set; }
        public int cantProducion { get; set; }
        public string comentario { get; set; }
    }

    public class Pedido {
        public string NumPedido        { get;set;}
        public string Estado           { get;set;}
        public string FechaPedido      { get;set;}
        public string Representante    { get;set;}
        public string Cliente          { get;set;}
        public string Area             { get;set;}
        public string Trabajador       { get;set;}
        public string CargoTrabajador  { get;set;}
        public string Reporte          { get; set; }
    }

    public class Actividades
    {
        public int tipo { get; set; }
        public int IdActividad { get; set; }
        public int NumProducion { get; set; }
        public int IdArticulo { get; set; }
        public string actividad { get; set; }
        public string fecharegistro { get; set; }
        public string horainicio { get; set; }
        public string horafin { get; set; } 
        public string cantcorreciones { get; set; }
        public string cantPaginas { get; set; }
        public string comentariocoordinador { get; set; }
        public string comentariocolaborador { get; set; }
    }
}
