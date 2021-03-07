using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectArbolBinario.Clases.Modelo
{
    class ModelData
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public string Id { get; set; }

        //[BsonId]
        //[BsonRepresentation(BsonType.String)]
        //public string Id { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        [BsonElement("animal")]//HACE REFERENCIA CON LOS ENCABEZADOS A BD
        public string animal { get; set; }

        [BsonElement("gesto")]
        public string gesto { get; set; }
    }
}
