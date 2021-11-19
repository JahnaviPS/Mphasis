import { Component, OnInit } from '@angular/core';
import { payroll } from '../login/Models/Payroll';
import { PayrollService } from '../payroll.service';

@Component({
  selector: 'app-addpayroll',
  templateUrl: './addpayroll.component.html',
  styleUrls: ['./addpayroll.component.css']
})
export class AddpayrollComponent implements OnInit {
adde:payroll={
  Empid:0,
  BankaccountNo:0,
   Basicpay:0,
   HRA:0,
  Medicalallowance:0,
  Tax:0,
  Bonus:0,
  Noofworkdays:0,
  Grosspay:0,
  Pfno:0
}
 
  constructor(private p:PayrollService) { }

  ngOnInit(): void {

    
    
  }
  loginstatus:number=0;
  addpr(addemp1:payroll):number
    
{
  this.loginstatus=this.p.addpayroll(addemp1);
  alert("Employee Added succesfully");
  return this.loginstatus;
  
}

}
