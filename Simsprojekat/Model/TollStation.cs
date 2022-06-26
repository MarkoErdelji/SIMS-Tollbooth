using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Simsprojekat.Model
{
    [BsonIgnoreExtraElements]
    internal class TollStation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("location")]
        public City location { get; set; }

        [BsonElement("tollBooths")]
        public List<int> tollBoothsId { get; set; }
    }
}
