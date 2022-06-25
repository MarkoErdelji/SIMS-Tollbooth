using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Simsprojekat.Model
{
    public enum UserType
    {
        Admin,
        HeadManager,
        StationManager,
        Worker
    }

    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        [EmailAddress]
        public string LastName { get; set; }

        [BsonElement("username")]
        [EmailAddress]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("email")]
        [EmailAddress]
        public string Email { get; set; }

        [BsonElement("type")]
        [EmailAddress]
        public UserType Type { get; set; }


    }
}
