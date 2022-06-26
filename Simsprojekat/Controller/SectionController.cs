using MongoDB.Driver;
using Simsprojekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsprojekat.Controller
{
    internal class SectionController
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<Section> sectionCollection;
        public SectionController()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://PrlinaRozicBibinErdelji:PrlinaRozicBibinErdelji@cluster0.5qfgf.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            _database = client.GetDatabase("TollBooth");
            this.sectionCollection = _database.GetCollection<Section>("Sections");
        }

        public bool Delete(int stationOne, int stationTwo)
        {
            var section = _database.GetCollection<Section>("Sections");

            section.DeleteOne(tb => (tb.EntryStationId == stationOne && tb.ExitStationId == stationTwo) || (tb.EntryStationId == stationTwo && tb.ExitStationId == stationOne));

            return true;
        }

        public List<Section> GetByStationId(int id)
        {
            var section = _database.GetCollection<Section>("Sections");

            return section.Find(s => s.ExitStationId == id || s.EntryStationId == id).ToList();
        }
    }
}
