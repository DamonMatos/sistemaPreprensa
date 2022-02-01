using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Preprensa.Data
{
   public class Produccion
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable InicioSesion(String Usu, String Clav)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_InicioSesion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", Usu);
            cmd.Parameters.AddWithValue("@Clave", Clav);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }


        public DataTable ListarPedidos()
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarPedidosProducir", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable BuscarPedidos(String FechaIni, String FechaFin)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_BuscarPedidosProducir", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FechaInicio",FechaIni);
            cmd.Parameters.AddWithValue("@FechaFin",FechaFin);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }


        public DataTable ListarActividades(int NumProducion, int IdArticulo)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarDetalleActividades", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumProducion", NumProducion);
            cmd.Parameters.AddWithValue("@IdArticulo", IdArticulo);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }


        public DataTable RegistrarActividades(Actividades obj)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_MantenimientoActividades", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
            cmd.Parameters.AddWithValue("@IdActividad", obj.IdActividad);
            cmd.Parameters.AddWithValue("@NumProducion", obj.NumProducion);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@Descripcion", obj.actividad);
            cmd.Parameters.AddWithValue("@FechaRegistro", obj.fecharegistro);
            cmd.Parameters.AddWithValue("@HoraInicio", obj.horainicio);
            cmd.Parameters.AddWithValue("@HoraFin", obj.horafin);
            cmd.Parameters.AddWithValue("@cantCorreciones", obj.cantcorreciones);
            cmd.Parameters.AddWithValue("@CantPaginas", obj.cantPaginas);
            cmd.Parameters.AddWithValue("@comentCol", obj.comentariocolaborador);
            cmd.Parameters.AddWithValue("@ComentCor", obj.comentariocoordinador);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }


        public DataTable BuscarActividades(Actividades obj)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarActividadesDetalle", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tipo", obj.tipo);
            cmd.Parameters.AddWithValue("@NumProducion", obj.NumProducion);
            cmd.Parameters.AddWithValue("@idarticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@IdActividad", obj.IdActividad);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }




        public DataSet BuscarPedido(int NumProduccion)
        {
            DataSet Dt = new DataSet();
            SqlCommand cmd = new SqlCommand("Sp_ListarDetallePedidoProducion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumProducion", NumProduccion);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataSet ReporteDiario(int NumProduccion)
        {
            DataSet Dt = new DataSet();
            SqlCommand cmd = new SqlCommand("sp_reporteActividadesProduccion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumProducion", NumProduccion);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }


        
        public DataSet ReporteBuscarPedido(int NumProduccion)
        {
            DataSet Dt = new DataSet();
            SqlCommand cmd = new SqlCommand("Sp_ReporteListarDetallePedidoProducion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumProducion", NumProduccion);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        

        public void RegistrarDetallePedidoProduccion(Articulo Obj)
        {
            DataTable Ds = new DataTable();
            
            SqlCommand cmd = new SqlCommand("Sp_UpdateDetallePedidoProducion", cn);        
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumProducion", Obj.NumProducion);
            cmd.Parameters.AddWithValue("@IdArticulo", Obj.IdArticulo);
            cmd.Parameters.AddWithValue("@CantProduccion", Obj.cantProducion);
            cmd.Parameters.AddWithValue("@Comentario", Obj.comentario);
            cn.Open();
            try{
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally{
                cn.Close();
            }
            
        }

    }
}
