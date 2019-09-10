using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using projectgb_web.Models;
using projectgb_web.Services;
using System.Linq;

namespace projectgb_web.Repositories
{
    public class WorkoutDataRepository : IDataRepository<GbWorkout>
    {
        private readonly MongoClient _dbClient;
        private readonly ILogger _logger;
        private IDictionary<string, GbWorkout> data;
        private const string DB_NAME = "projectgb";
        private const string WORKOUTS_COLLECTION_NAME = "workouts";
        private const string EXERCISES_COLLECTION_NAME = "exercises";
        private const string USERS_COLLECTION_NAME = "users";
        private bool _isRepositoryFresh = false;
        private IDictionary collections;

        public IDictionary<string, GbWorkout> Data => data;

        public WorkoutDataRepository(IConfiguration configuration, ILogger<WorkoutDataRepository> logger)
        {
            // _dbServioce = dbService;
            _dbClient = new MongoClient(configuration["DbConnectionString"]);
            _logger = logger;
            data = new Dictionary<string, GbWorkout>();
            collections = new Hashtable();
            collections.Add("workouts", null);
            collections.Add("exercises", null);
            collections.Add("users", null);
        }

        public void Build()
        {
            if(data == null || !_isRepositoryFresh)
            {
                _logger.LogInformation("Building the repository for the first time.");
                var db = _dbClient.GetDatabase(DB_NAME);
                collections["workouts"] = db.GetCollection<GbWorkout>(WORKOUTS_COLLECTION_NAME);
                collections["exercises"] = db.GetCollection<GbExercise>(EXERCISES_COLLECTION_NAME);
                collections["users"] = db.GetCollection<GbExercise>(USERS_COLLECTION_NAME);

                var workouts = (collections["workouts"] as IMongoCollection<GbWorkout>).AsQueryable();
                var exercises = collections["exercises"] as IMongoCollection<GbExercise>;

                foreach (var workout in workouts)
                {
                    var wkt = new GbWorkout() {
                        Id = workout.Id,
                        Name = workout.Name,
                        Description = workout.Description,
                        Tags = workout.Tags,
                        WorkoutRoutine = new GbRoutine() {
                            WorkoutStations = new List<GbStation<IEffort>>()
                        }
                    };
                    var stations = workout.WorkoutRoutine.WorkoutStations;
                    foreach (var station in stations)
                    {
                        var ex = exercises.Find(e => e.Id == station.ExerciseId.ToString()).FirstOrDefault();
                        ((List<GbStation<IEffort>>)wkt.WorkoutRoutine.WorkoutStations)
                        .Add(new GbStation<IEffort>{
                            ExerciseId = station.ExerciseId,
                            Exercise = ex,
                            Effort = station.Effort
                        });
                    }
                    data.Add(workout.Id, wkt);
                }
                
                _logger.LogInformation($"Retrieved workout data from the database.");
                _isRepositoryFresh = true;
            }
            else
            {
                // Data is already initiaized, update the cache asynchronously in a thread safe manner
            }
        }

        public GbWorkout Get(Func<GbWorkout, bool> selector = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(GbWorkout data)
        {
            throw new NotImplementedException();
        }

        public void Update(GbWorkout data)
        {
            throw new NotImplementedException();
        }

        public void Delete(GbWorkout data)
        {
            throw new NotImplementedException();
        }
    }
}
