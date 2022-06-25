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
    public class TollBooth
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("tollStationId")]
        public int TollStationId { get; set; }

        [BsonElement("devices")]
        public List<Device> Devices { get; set; }

        [BsonElement("tollBoothNumber")]
        public string TollBoothNumber { get; set; }
    }
}
