import { Component, OnInit, Inject, AfterViewInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GbWorkout } from '../models/gb-models';

@Component({
  selector: 'app-gb-workouts',
  templateUrl: './gb-workouts.component.html',
  styleUrls: ['./gb-workouts.component.css']
})
export class GbWorkoutsComponent implements OnInit, AfterViewInit {
  public workouts: GbWorkout[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    console.log(`Base URL: ${baseUrl}`);
    http.get<GbWorkout[]>(baseUrl + 'api/WorkoutData/Workouts').subscribe(result => {
      this.workouts = result;
      console.log(this.workouts);
    }, error => console.error(error));
  }

  ngOnInit() {
    
  }

  ngAfterViewInit(): void {
    
  }

  showWorkoutDetail() {
    console.log("Going to show workout detail...")
  }
}
