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
    public class City
    {
        [BsonElement("zipCode")]
        public string ZipCode { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
