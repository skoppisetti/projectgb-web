using System;
using System.Collections.Generic;
// using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
// using MongoDB.Bson;
// using MongoDB.Driver;
using projectgb_web.Models;
using projectgb_web.Repositories;

namespace projectgb_web.Services
{
    public class DbService
    {
        // private readonly MongoClient _dbClient;
        private readonly ILogger _logger;
        private readonly IDataRepository<GbWorkout> _dataRepository;

        public DbService(ILogger<DbService> logger, IDataRepository<GbWorkout> dataRepository)
        {
            // _dbClient = new MongoClient(configuration["DbConnectionString"]);
            _logger = logger;
            _logger.LogInformation("DbService instance created.");
            _dataRepository = dataRepository;
        }

        public void InitializeRepositories()
        {
            _logger.LogInformation("Initializing the data repositories...");
            _dataRepository.Build();
        }

        public void RefreshRepository(Type repositoryType)
        {
            if (repositoryType == typeof(GbWorkout))
            {
                _logger.LogInformation("Refreshing workouts repository...");
            }
        }

        public IEnumerable<GbWorkout> GetAllWorkouts() 
        {
            return _dataRepository.Data.Values;
        }
    }
}
