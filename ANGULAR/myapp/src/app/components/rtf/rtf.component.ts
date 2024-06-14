import { Component } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';

@Component({
  selector: 'app-rtf',
  templateUrl: './rtf.component.html',
  styleUrl: './rtf.component.css'
})
export class RtfComponent {
       userform:any;
       ngOnInit()
       {
        this.userform=new FormGroup({
          fname:new FormControl("",[Validators.required,Validators.pattern("^[a-zA-Z ]{3,20}$")]) ,Pass:new FormControl("",[Validators.required,Validators.pattern("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")])})
          
      
       }
}
