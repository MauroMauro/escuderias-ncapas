using _2_Dominio;
using _2_Dominio.Repositorio;
using MongoDB.Driver;
using MongoDB.Bson;
using _2_Dominio.ValueObjects;
using static MongoDB.Driver.WriteConcern;

namespace _3_Infraestructura
{
    public class EscuderiaRepositorioMongoDB : IEscuderiaRepositorio
    {
        string string_conexion = "mongodb://mongo:2c40cwoJAUuonQFJRIMo@containers-us-west-88.railway.app:6293";

        public void actualizarEscuderia(Escuderia escuderia)
        {
            MongoClient mongoDB = new MongoClient(this.string_conexion);
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            var coleccionEscuderias = dbEscuderias.GetCollection<BsonDocument>("Escuderias");

            var escuderiaAActualizar = Builders<BsonDocument>.Filter.Eq("id", escuderia.Id().ToString());
            var escuderiaActualizada = Builders<BsonDocument>.Update.Set("nombre", escuderia.Nombre())
                .Set("nacionalidad", escuderia.Nacionalidad())
                .Set("anioFundacion", escuderia.AnioFundacion().ToString())
                .Set("motores", escuderia.Motores());

            coleccionEscuderias.UpdateOne(escuderiaAActualizar, escuderiaActualizada);
        }

        public void borrarEscuderia(Escuderia escuderia)
        {
            MongoClient mongoDB = new MongoClient(this.string_conexion);
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            var coleccionEscuderias = dbEscuderias.GetCollection<BsonDocument>("Escuderias");

            var deleteFilter = Builders<BsonDocument>.Filter.Eq("id", escuderia.Id().ToString());
            coleccionEscuderias.DeleteOne(deleteFilter);

        }

        public void grabar(Escuderia escuderia)
        {
            MongoClient mongoDB = new MongoClient(this.string_conexion);
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            var escuderias = dbEscuderias.GetCollection<BsonDocument>("Escuderias");

            // Le pedí ayuda a Franco porque no me salía nada
            var escuderiaJSON = @"{
                ""id"" : """ + escuderia.Id() + @""",
                ""nombre"" : """ + escuderia.Nombre() + @""",
                ""nacionalidad"" : """ + escuderia.Nacionalidad() + @""",
                ""anioFundacion"" : """ + escuderia.AnioFundacion() + @""",
                ""motores"" : """ + escuderia.Motores() + @""",
             }";
            var documento = BsonDocument.Parse(escuderiaJSON);
            escuderias.InsertOne(documento);
        }

        public List<Escuderia> obtenerTodos()
        {
            List<Escuderia> listado_escuderias = new List<Escuderia>();

            MongoClient mongoDB = new MongoClient(this.string_conexion);
            var dbEscuderias = mongoDB.GetDatabase("Escuderias");
            var coleccionEscuderias = dbEscuderias.GetCollection<BsonDocument>("Escuderias");
            var documentos = coleccionEscuderias.Find(t => true).ToList();
            foreach (BsonDocument escuderia in documentos)
            {
                Guid id = Guid.Parse(escuderia["id"].AsString);
                Escuderia e = new Escuderia(
                    id,
                    escuderia["nombre"].AsString,
                    escuderia["nacionalidad"].AsString,
                    int.Parse(escuderia["anioFundacion"].AsString),
                    escuderia["motores"].AsString
                );
                listado_escuderias.Add(e);
            }
            return listado_escuderias;
        }
    }
}
