using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;
using Simsprojekat.Observer;

namespace Simsprojekat.Model
{
    [BsonIgnoreExtraElements]
    public class Section : IObservable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("entryStation")]
        public int EntryStationId { get; set; }

        [BsonElement("exitStation")]
        public int ExitStationId { get; set; }

        [BsonElement("distance")]
        public int Distance { get; set; }

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
