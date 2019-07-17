using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projectgb_web.DataProviders;
using projectgb_web.Models;

namespace projectgb_web.Controllers 
{
    [Route("api/[controller]")]
    public class WorkoutDataController : Controller
    {
        public WorkoutDataController(IDataProvider<GbWorkout> dataProvider)
        {
            DataProvider = dataProvider;
        }

        public IDataProvider<GbWorkout> DataProvider { get; }

        [HttpGet("[action]")]
        public IEnumerable<GbWorkout> Workouts()
        {
            Console.WriteLine("Fetching workout data...");
            return DataProvider.FetchData();
        }
    }
}