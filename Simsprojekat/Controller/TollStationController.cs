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

        public bool Insert(TollStation ts)
        {
            var tollStations = _database.GetCollection<TollStation>("TollStations");

            var id = tollStations.Find(e => true).SortByDescending(e => e.Id).FirstOrDefault().Id;
            ts.Id = id + 1;

            tollStations.InsertOne(ts);


            return true;
        }

        public bool Update(TollStation ts)
        {
            var tollStations = _database.GetCollection<TollStation>("TollStations");

            tollStations.ReplaceOne(u => u.Id == ts.Id, ts);


            return true;
        }


        public bool Delete(int tollStationId)
        {
            var tollStations = _database.GetCollection<TollStation>("TollStations");

            tollStations.DeleteOne(ts => ts.Id == tollStationId);

            return true;

        }
    }
}
