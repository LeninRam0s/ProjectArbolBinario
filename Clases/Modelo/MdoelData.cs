using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectArbolBinario.Clases.Modelo
{
    class MdoelData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("animal")]//HACE REFERENCIA CON LOS ENCABEZADOS A BD
        public string animal { get; set; }

        [BsonElement("gesto")]
        public string gesto { get; set; }
    }
}
