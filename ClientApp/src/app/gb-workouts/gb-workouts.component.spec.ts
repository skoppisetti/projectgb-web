import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GbWorkoutsComponent } from './gb-workouts.component';

describe('GbWorkoutsComponent', () => {
  let component: GbWorkoutsComponent;
  let fixture: ComponentFixture<GbWorkoutsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GbWorkoutsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GbWorkoutsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
