using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Simsprojekat.Model
{
    [BsonIgnoreExtraElements]
    public class StationManager : User
    {
        public StationManager(int id, string firstName, string lastName, string username, string password, string email, UserType type, Address adress, int tollStationId) : base(id, firstName, lastName, username, password, email, type, adress)
        {
            TollStationId = tollStationId;
        }

        [BsonElement("tollStationId")]
        public int TollStationId { get; set; }
    }
}
