using _2_Dominio;
using _2_Dominio.Repositorio;
using _2_Dominio.ValueObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Infraestructura
{
    public class EscuderiaRepositorioSqlServer : IEscuderiaRepositorio
    {

        String connectionString = "Data Source=NICO;Initial Catalog=EscuderíasTP;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void borrarEscuderia(Escuderia escuderia)
        {
            using(SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using(SqlCommand comando = new SqlCommand("DELETE FROM Escuderias WHERE id=@id", conexion))
                {
                    comando.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = escuderia.Id();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void grabar(Escuderia escuderia)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO Escuderias (id, nombre, nacionalidad, anio_fundacion, motores) VALUES (@id, @nombre, @nacionalidad, @anio_fundacion, @motores)", conexion))
                {
                    comando.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = escuderia.Id();
                    comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = escuderia.Nombre();
                    comando.Parameters.Add("@nacionalidad", System.Data.SqlDbType.VarChar).Value = escuderia.Nacionalidad();
                    comando.Parameters.Add("@anio_fundacion", System.Data.SqlDbType.Int).Value = escuderia.AnioFundacion();
                    comando.Parameters.Add("@motores", System.Data.SqlDbType.VarChar).Value = escuderia.Motores();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Escuderia> obtenerTodos()
        {
            List<Escuderia> escuderias = new List<Escuderia>();
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT id, nombre, nacionalidad, anio_fundacion, motores FROM Escuderias", conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid id = reader.GetGuid(0);
                            String nombre = reader.GetString(1);
                            String nacionalidad = reader.GetString(2);
                            int anio_fundacion = reader.GetInt32(3);
                            String motores = reader.GetString(4);


                            Escuderia escuderia = new Escuderia(id, nombre, nacionalidad, anio_fundacion, motores);

                            escuderias.Add(escuderia);
                        }
                    }
                }
            }

            return escuderias;
        }


    }
}
