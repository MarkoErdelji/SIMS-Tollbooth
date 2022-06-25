using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsprojekat.Model
{

    public enum VehicleType
    {
        Car,
        Truck,
        Bike,
        Bus,
        Other
    }

    [BsonIgnoreExtraElements]
    public class Vehicle
    {
        [BsonElement("licencePlate")]
        public string LicencePlate { get; set; }

        [BsonElement("type")]
        public VehicleType Type { get; set; }

        [BsonElement("electronicTag")]
        public bool ElectronicTag { get; set; }

    }
}
