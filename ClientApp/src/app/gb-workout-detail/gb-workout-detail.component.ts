import { Component, OnInit } from '@angular/core';
import { SuiModal, ComponentModalConfig, ModalSize, SuiModalService } from 'ng2-semantic-ui';

interface IWorkoutDetailModalContext 
{
  name: string;
  description: string;
}

@Component({
  selector: 'app-gb-workout-detail',
  templateUrl: './gb-workout-detail.component.html',
  styleUrls: ['./gb-workout-detail.component.css']
})
export class GbWorkoutDetailComponent implements OnInit {

  constructor(public modal:SuiModal<IWorkoutDetailModalContext, void, void>, public modalService:SuiModalService) { 
    this.modalService
      .open(new GbWorkoutDetailModal("Workout1","Workout1 Description"))
  }

  ngOnInit() {}
}

export class GbWorkoutDetailModal extends ComponentModalConfig<IWorkoutDetailModalContext, void, void> {
  constructor(name: string, description: string, size=ModalSize.Normal) {
    super(GbWorkoutDetailComponent, {name, description});
    this.isClosable = true;
    this.transitionDuration = 200;
    this.size = size;
  }
}
