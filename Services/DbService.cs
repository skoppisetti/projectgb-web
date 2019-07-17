using System;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace projectgb_web.Services
{
    public class DbService
    {
        private readonly MongoClient _dbClient;

        public DbService(IConfiguration configuration)
        {
            _dbClient = new MongoClient(configuration["DbConnectionString"]);
            Console.WriteLine("DbService instance created.");
        }
    }
}
