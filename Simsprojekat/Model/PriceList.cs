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
    class PriceList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("basePriceEuro")]
        public double basePriceEuro { get; set; }


        [BsonElement("basePriceDinar")]
        public double basePriceDinar { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; }

        [BsonElement("lastActive")]
        public string LastActive { get; set; }

        [BsonElement("carCoeficient")]
        public double CarCoeficient { get; set; }

        [BsonElement("truckCoeficient")]
        public double TruckCoeficient { get; set; }

        [BsonElement("otherCoeficient")]
        public double OtherCoeficient { get; set; }

        [BsonElement("bikeCoeficient")]
        public double BikeCoeficient { get; set; }

        [BsonElement("busCoeficient")]
        public double BusCoeficient { get; set; }

    }
}
