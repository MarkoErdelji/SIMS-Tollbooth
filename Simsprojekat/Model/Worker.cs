using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Simsprojekat.Model
{
    public class Worker : User
    {
        public Worker(string? _id, int id, string firstName, string lastName, string username, string password, string email, UserType type, Address adress,int tollBoothId) : base(_id,id,firstName,lastName,username,password,email,type,adress)
        {
            TollBoothId = tollBoothId;
        }

        [BsonElement("tollBoothId")]
        public int TollBoothId { get; set; }
    }
   
}
