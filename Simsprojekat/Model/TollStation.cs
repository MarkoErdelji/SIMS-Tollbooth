using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Simsprojekat.Observer;

namespace Simsprojekat.Model
{
    [BsonIgnoreExtraElements]
    internal class TollStation : IObservable
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
