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
        public DateTime Date { get; set; }

        [BsonElement("amount")]
        public double Amount { get; set; }

        [BsonElement("paidInDinars")]
        public bool PaidInDinars { get; set; }

        [BsonElement("exitStationId")]
        public int  ExitStationId { get; set; }

        [BsonElement("ticketId")]
        public int TicketId { get; set; }


        public Transaction(DateTime date, double amount, bool paidInDinars, int exitStationId, int ticketId)
        {
            Date = date;
            Amount = amount;
            PaidInDinars = paidInDinars;
            ExitStationId = exitStationId;
            TicketId = ticketId;
        }
    }
}
