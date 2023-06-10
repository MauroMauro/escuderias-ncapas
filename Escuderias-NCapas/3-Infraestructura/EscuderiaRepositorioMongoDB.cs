using _2_Dominio;
using _2_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.Json.Nodes;

namespace _3_Infraestructura
{
    public class EscuderiaRepositorioMongoDB : IEscuderiaRepositorio
    {
        string string_conexion = "mongodb://mongo:2c40cwoJAUuonQFJRIMo@containers-us-west-88.railway.app:6293";
        public void borrarEscuderia(Escuderia escuderia)
        {
            Console.WriteLine("Borrando");
        }

        public void grabar(Escuderia escuderia)
        {
            MongoClient mongoDB = new MongoClient(this.string_conexion);
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            var escuderias = dbEscuderias.GetCollection<Escuderia>("Escuderias");
            escuderias.InsertOne(escuderia);
        }

        public List<Escuderia> obtenerTodos()
        {
            List<Escuderia> listado_escuderias = new List<Escuderia>();

            MongoClient mongoDB = new MongoClient(this.string_conexion);
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            var escuderias = dbEscuderias.GetCollection<BsonDocument>("Escuderias");
            var documentos = escuderias.Find(t => true).ToList();
            foreach (BsonDocument escuderia in documentos)
            {
                Console.WriteLine(escuderia);
            }
            return listado_escuderias;
        }
    }
}
