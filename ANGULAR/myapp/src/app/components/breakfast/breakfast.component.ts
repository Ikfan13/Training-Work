import { Component } from '@angular/core';
import { MyserviceService } from '../../shared/services/myservice.service';

@Component({
  selector: 'app-breakfast',
  templateUrl: './breakfast.component.html',
  styleUrl: './breakfast.component.css'
})
export class BreakfastComponent {
  items:any;
  constructor(private myserObj:MyserviceService){}
  ngOnInit(){
    this.items=this.myserObj.breakfast
  }
}
