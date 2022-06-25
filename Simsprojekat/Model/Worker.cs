using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Simsprojekat.Model
{
    [BsonDiscriminator(User.Worker)]
    public class Worker : User
    {
        [BsonElement("tollBoothId")]
        public int TollBoothId { get; set; }
    }
}
