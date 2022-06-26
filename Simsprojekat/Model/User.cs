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
        public User(int id, string firstName, string lastName, string username, string password, string email, UserType type, Address adress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Email = email;
            Type = type;
            Adress = adress;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("type")]
        public UserType Type { get; set; }

        [BsonElement("adress")]
        public Address Adress { get; set; }


    }
}
