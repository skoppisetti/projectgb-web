import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GbWorkoutDetailComponent } from './gb-workout-detail.component';

describe('GbWorkoutDetailComponent', () => {
  let component: GbWorkoutDetailComponent;
  let fixture: ComponentFixture<GbWorkoutDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GbWorkoutDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GbWorkoutDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
