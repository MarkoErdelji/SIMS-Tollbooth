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
    class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("date")]
        public string Date { get; set; }

        [BsonElement("amount")]
        public int Amount { get; set; }

        [BsonElement("paidInDinars")]
        public bool PaidInDinars { get; set; }

        [BsonElement("exitStationId")]
        public int  ExitStationId { get; set; }

        [BsonElement("ticketId")]
        public int TicketId { get; set; }

    }
}
