using MongoDB.Driver;
using Simsprojekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsprojekat.Controller
{
    internal class TollStationController
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<TollStation> tollStationsCollection;
        public TollStationController()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://PrlinaRozicBibinErdelji:PrlinaRozicBibinErdelji@cluster0.5qfgf.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            _database = client.GetDatabase("TollBooth");
            this.tollStationsCollection = _database.GetCollection<TollStation>("TollStations");
        }

        public TollStation GetById(int id)
        {
            return tollStationsCollection.Find(item => item.Id == id).FirstOrDefault();
        }
        public List<TollStation> GetAll()
        {
            return tollStationsCollection.Find(item => true).ToList();
        }
    }
}
