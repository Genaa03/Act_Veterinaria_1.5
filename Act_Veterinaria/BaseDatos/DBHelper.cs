using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Act_Veterinaria.Dominio;

namespace Act_Veterinaria.BaseDatos
{
    internal class DBHelper
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Vet_1.3;Integrated Security=True");
        SqlCommand comando = new SqlCommand();

        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        private void desconectar()
        {
            conexion.Close();
        }

        internal DataTable reporteCantidad()
        {
            conectar();

            comando.CommandText = "SP_CANTIDAD_ATENCIONES";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();

            return tabla;
        }

        public DataTable consultaBD(string NombreSP)
        {
            conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = NombreSP;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable consultaBDParametros_ID(string NombreSP, string nombre)
        {
            conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = NombreSP;
            comando.Parameters.AddWithValue("@nombre", nombre);
            tabla.Load(comando.ExecuteReader());
            desconectar();
            comando.Parameters.Clear();
            return tabla;
        }

        public DataTable consultaBDParametros_Masc(string NombreSP, int id)
        {
            conectar();
            DataTable tabla = new DataTable();
            comando.CommandText = NombreSP;
            comando.Parameters.AddWithValue("@id", id);
            tabla.Load(comando.ExecuteReader());
            desconectar();
            comando.Parameters.Clear();
            return tabla;
        }


        public int actualizarBD(string consultaSQL)
        {
            int filasAfectadas;
            conectar();
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }

        public int altaBaja_Cliente(string nombreSP, string nombre)
        {
            int filasAfectadas;
            conectar();
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@nombre", nombre);
            filasAfectadas = comando.ExecuteNonQuery();
            desconectar();
            comando.Parameters.Clear();
            return filasAfectadas;
        }

        public int ProximoCliente()
        {
            conectar();
            comando.CommandText = "SP_PROXIMO_COD";
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            comando.Parameters.Add(pOut);
            comando.ExecuteNonQuery();
            int cod = (int)pOut.Value;
            desconectar();
            comando.Parameters.Clear();

            return cod;
        }

        public int ProximaAtencion()
        {
            conectar();
            comando.CommandText = "SP_PROXIMO_ID_ATENCION";
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            comando.Parameters.Add(pOut);
            comando.ExecuteNonQuery();
            int cod = (int)pOut.Value;
            desconectar();
            comando.Parameters.Clear();

            return cod;
        }

        public int ProximaMascota()
        {
            conectar();
            comando.CommandText = "SP_PROXIMO_ID_MASCOTA";
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            comando.Parameters.Add(pOut);
            comando.ExecuteNonQuery();
            int id = (int)pOut.Value;
            desconectar();
            comando.Parameters.Clear();

            return id;
        }

        public int InsertarCliente(Cliente c)
        {
            int filas = 0;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "SP_INSERTAR_CLIENTE";
                comando.Parameters.AddWithValue("@nombre", c.pNombre);
                comando.Parameters.AddWithValue("@sexo", c.pSexo);
                filas = comando.ExecuteNonQuery();
                t.Commit();
            }
            catch(SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    desconectar();

            }
            comando.Parameters.Clear();
            return filas;
        }
        public int InsertarMascota(Mascota m)
        {

            int filas = 0;
            SqlTransaction t = null;

            try { 
            conectar();
            t = conexion.BeginTransaction();
            comando.Transaction = t;
            comando.CommandText = "SP_INSERTAR_MASCOTA";
            comando.Parameters.AddWithValue("@cod_cliente", m.Cliente.pCod_cliente);
            comando.Parameters.AddWithValue("@nombre", m.pNombre);
            comando.Parameters.AddWithValue("@edad", m.pEdad);
            comando.Parameters.AddWithValue("@id_tipo", m.pId_tipo);
            filas = comando.ExecuteNonQuery();
            t.Commit();

            }

            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }

            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    desconectar();

            }

            comando.Parameters.Clear();
            return filas;
        }

        public int InsertarAtencion(Atenciones a)
        {

            int filas = 0;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "SP_INSERTAR_ATENCION";
                comando.Parameters.AddWithValue("@id_mascota", a.Mascota.pId_mascota);
                comando.Parameters.AddWithValue("@fecha", a.fecha);
                comando.Parameters.AddWithValue("@descripcion", a.descripcion);
                comando.Parameters.AddWithValue("@importe", a.importe);
                filas = comando.ExecuteNonQuery();
                t.Commit();

            }

            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }

            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    desconectar();

            }

            comando.Parameters.Clear();
            return filas;
        }

        public DataTable reporteFechas(DateTime desde, DateTime hasta)
        {
            conectar();

            comando.CommandText = "SP_ATENCIONES_FECHA";
            comando.Parameters.AddWithValue("@fecha_desde", desde);
            comando.Parameters.AddWithValue("@fecha_hasta", hasta);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            desconectar();
            comando.Parameters.Clear();

            return tabla;
        }
    }
}
