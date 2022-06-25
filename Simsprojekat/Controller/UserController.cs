﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Simsprojekat.Model;

public class UserController
{
    private readonly IMongoDatabase _database;

    public UserController()
    {
        var settings = MongoClientSettings.FromConnectionString("mongodb+srv://PrlinaRozicBibinErdelji:PrlinaRozicBibinErdelji@cluster0.5qfgf.mongodb.net/?retryWrites=true&w=majority");
        var client = new MongoClient(settings);
        _database = client.GetDatabase("TollBooth");
    }

    public List<User> GetAllUsers()
    {
        var users = _database.GetCollection<User>("Users");

        return users.Find(u => true).ToList();
    }
    public User Login(String username,String password)
    {
        var users = _database.GetCollection<User>("Users");

        User user = users.Find(u => u.Username == username && u.Password == password).FirstOrDefault();

        return user;
    }

    public Worker GetWorker(int id)
    {
        var users = _database.GetCollection<Worker>("Users");

        Worker worker = users.Find(u => u.Type == UserType.Worker && u.Id == id).FirstOrDefault();

        return worker;

    }

    public StationManager GetStationManagers(int id)
    {
        var users = _database.GetCollection<StationManager>("Users");

        StationManager stationManager = users.Find(u => u.Type == UserType.StationManager && u.Id == id).FirstOrDefault();

        return stationManager;

    }
    public TollBooth GetTollbooth(int id)
    {
        var users = _database.GetCollection<TollBooth>("TollBooths");

        TollBooth tollbooth = users.Find(tb => tb.Id == id).FirstOrDefault();

        return tollbooth;

    }


}