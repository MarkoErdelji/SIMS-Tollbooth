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
            var sections = _database.GetCollection<Section>("Sections");

            sections.DeleteOne(tb => (tb.EntryStationId == stationOne && tb.ExitStationId == stationTwo) || (tb.EntryStationId == stationTwo && tb.ExitStationId == stationOne));

            return true;
        }

        public List<Section> GetByStationId(int id)
        {
            var sections = _database.GetCollection<Section>("Sections");

            return sections.Find(s => s.ExitStationId == id || s.EntryStationId == id).ToList();
        }

        public bool Insert(Section s)
        {
            var sections = _database.GetCollection<Section>("Sections");

            if (CheckValidity(s.EntryStationId, s.ExitStationId))
            {
                sections.InsertOne(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Section GetByStationIds(int stationOneId, int stationTwoId)
        {
            var sections = _database.GetCollection<Section>("Sections");
            return sections.Find(u => (u.EntryStationId == stationOneId && u.ExitStationId == stationTwoId) || (u.EntryStationId == stationTwoId && u.ExitStationId == stationOneId)).FirstOrDefault();
        }

        public bool Update(Section s)
        {
            var sections = _database.GetCollection<Section>("Sections");

            sections.ReplaceOne(u => (u.EntryStationId == s.ExitStationId && u.ExitStationId == s.EntryStationId) || (u.EntryStationId == s.EntryStationId && u.ExitStationId == s.ExitStationId), s);


            return true;
        }

        public bool CheckValidity(int stationOneId, int tollStationId)
        {
            var sections = _database.GetCollection<Section>("Sections");

            if (sections.Find(s => (s.EntryStationId == tollStationId && s.ExitStationId == stationOneId) || (s.EntryStationId == stationOneId && s.ExitStationId == tollStationId)).ToList().Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
