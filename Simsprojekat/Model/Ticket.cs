using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsprojekat.Model
{
    [BsonIgnoreExtraElements]

    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("entryTime")]
        public string EntryTime { get; set; }

        [BsonElement("vehicle")]
        public Vehicle Vehicle { get; set; }

        [BsonElement("entryStationId")]

        public int EntryStationId { get; set; }

        [BsonElement("done")]

        public bool Done { get; set; }



    }
}
