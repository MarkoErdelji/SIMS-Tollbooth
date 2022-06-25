using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;

namespace Simsprojekat.Model
{
    [BsonIgnoreExtraElements]
    public class Section
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("entryStation")]
        public int EntryStationId { get; set; }

        [BsonElement("exitStation")]
        public int ExitStationId { get; set; }

        [BsonElement("distance")]
        public int Distance { get; set; }
    }
}
