import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, RequiredValidator, Validators } from '@angular/forms';
//import { contactDetails } from 'src/Models/contactDetails';
@Component({
  selector: 'app-usercontact',
  templateUrl: './usercontact.component.html',
  styleUrls: ['./usercontact.component.css']
})
export class UsercontactComponent implements OnInit {
  // g1=["Male","Female","Others"];
  // countries=["India","NewZealand","England","Australia","Japan"];
  // contactForm=new FormGroup({
  //     firstname:new FormControl('',[Validators.required]),
  //     lastname:new FormControl(),
  //     email:new FormControl(),
  //     phoneno:new FormControl(),
  //     gender:new FormControl(),
  //     country:new FormControl(),
  // });
  firstname=new FormControl('',[Validators.required,Validators.minLength(5)]);
  lastname=new FormControl('',[Validators.required,Validators.minLength(5)]);
  email=new FormControl('',[Validators.email]);
  contactForm:FormGroup=this.bldr.group({firstname:this.firstname,lastname:this.lastname,email:this.email});

  constructor(private bldr:FormBuilder) { }

  ngOnInit(): void {
  }
  // get f()
  // {
  //   return this.contactForm.controls;
  // }
  submitData(){
    console.log(this.contactForm.value);
    //let contactDet:contactDetails=new contactDetails();
  // contactDet.firstname=this.contactForm.value["firstname"];
  // contactDet.lastname=this.contactForm.value["lastname"];
  // contactDet.phoneno=this.contactForm.value["phoneno"];
  }

}