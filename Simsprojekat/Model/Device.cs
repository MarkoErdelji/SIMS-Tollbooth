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
    public class Device : IObservable
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("faulty")]
        public bool Faulty { get; set; }

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
