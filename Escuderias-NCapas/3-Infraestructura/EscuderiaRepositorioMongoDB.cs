using _2_Dominio;
using _2_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace _3_Infraestructura
{
    public class EscuderiaRepositorioMongoDB : IEscuderiaRepositorio
    {
        public void borrarEscuderia(Escuderia escuderia)
        {
            throw new NotImplementedException();
        }

        public void grabar(Escuderia escuderia)
        {
            MongoClient mongoDB = new MongoClient("mongodb://mongo:2c40cwoJAUuonQFJRIMo@containers-us-west-88.railway.app:6293");
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            Console.WriteLine("Listado de Colecciones: ");
            foreach (var item in dbEscuderias.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Fin del Listado");
            Console.WriteLine("\n\n\n");
        }

        public List<Escuderia> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
