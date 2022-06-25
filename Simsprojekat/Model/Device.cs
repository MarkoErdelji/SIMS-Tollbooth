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
    public class Device
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("faulty")]
        public bool Faulty { get; set; }

    }
}
