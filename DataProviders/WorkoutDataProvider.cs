using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using projectgb_web.Models;
using projectgb_web.Services;

namespace projectgb_web.DataProviders
{
    public class WorkoutDataProvider : IDataProvider<GbWorkout>
    {
        private DbService _dbService;
        private ILogger _logger;

        public WorkoutDataProvider(DbService dbService, ILogger<WorkoutDataProvider> logger)
        {
            _dbService = dbService;
            _logger = logger;
        }

        public IEnumerable<GbWorkout> FetchData(Func<GbWorkout, bool> predicate = null)
        {
            return _dbService.GetAllWorkouts();
        }
    }
}
