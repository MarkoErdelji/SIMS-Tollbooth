using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Simsprojekat.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsprojekat.Model
{

    [BsonIgnoreExtraElements]
    class PriceList : IObservable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("basePriceEuro")]
        public double BasePriceEuro { get; set; }

        [BsonElement("basePriceDinar")]
        public double BasePriceDinar { get; set; }

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

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (_observers == null) _observers = new List<IObserver>();
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }
}
