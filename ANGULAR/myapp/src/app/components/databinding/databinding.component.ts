import { getSafePropertyAccessString } from '@angular/compiler';
import { Component } from '@angular/core';
import { getXHRResponse } from 'rxjs/internal/ajax/getXHRResponse';

@Component({
  selector: 'app-databinding',
  templateUrl: './databinding.component.html',
  styleUrl: './databinding.component.css'
})
export class DatabindingComponent {

  mydata:any;

  myname:string="Mohamed Ikfan"
  greeting()
{
  window.alert("Good Warning Frndss");
}

}
