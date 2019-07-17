using System;
using System.Collections.Generic;
using projectgb_web.Models;

namespace projectgb_web.DataProviders
{
    class MockDataProvider : IDataProvider<GbWorkout>
    {
        public IEnumerable<GbWorkout> FetchData(Func<GbWorkout, bool> predicate = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Going to fetch mock workout data...");
            Console.ResetColor();
            return new [] { 
                new GbWorkout
                {
                    Name = "Test Workout",
                    Description = "Test Workout Description",
                    Tags = new [] {"tag1", "tag2"},
                    WorkoutRoutine = new GbRoutine
                    {
                        WorkoutStations = new [] {
                            new GbStation<IEffort>
                            {
                                Exercise = new GbExercise 
                                {
                                    Name = "Test Exercise",
                                    Description = "Test Exercise Description",
                                    Tags = new [] {"tag1", "tag2"}
                                },
                                Effort = new GbEffort<IEffort>
                                {
                                    Effort = new GbDuration 
                                    {
                                        Hours = 0,
                                        Minutes = 0,
                                        Seconds = 45,
                                    }
                                }
                            },
                            new GbStation<IEffort>
                            {
                                Exercise = new GbExercise 
                                {
                                    Name = "Test Exercise 2",
                                    Description = "Test Exercise 2 Description",
                                    Tags = new [] {"tag1", "tag2"}
                                },
                                Effort = new GbEffort<IEffort>
                                {
                                    Effort = new GbReps 
                                    {
                                        Reps = 10,
                                        GapBetween = 2
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}