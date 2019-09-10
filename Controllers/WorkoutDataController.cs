using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectgb_web.DataProviders;
using projectgb_web.Models;

namespace projectgb_web.Controllers 
{
    [Route("api/[controller]")]
    public class WorkoutDataController : Controller
    {
        private ILogger _logger;

        public WorkoutDataController(IDataProvider<GbWorkout> dataProvider, ILogger<WorkoutDataController> logger)
        {
            DataProvider = dataProvider;
            _logger = logger;
        }

        public IDataProvider<GbWorkout> DataProvider { get; }

        [HttpGet("[action]")]
        public IEnumerable<GbWorkout> Workouts()
        {
            // Console.WriteLine("Fetching workout data...");
            _logger.LogInformation("Fetching workout data...");
            return DataProvider.FetchData();
        }
    }
}