import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PayrollService } from '../payroll.service';
import { payroll } from '../login/Models/Payroll';

@Component({
  selector: 'app-payroll',
  templateUrl: './payroll.component.html',
  styleUrls: ['./payroll.component.css']
})
export class PayrollComponent implements OnInit {
  payrollist:Array<payroll>=[];
    constructor(private p:PayrollService,private r:Router) { }
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
   
      ngOnInit(): void {
        
        this.p.getEvents().subscribe(data => {
          this.payrollist = data;
        });
    
      }
     
  addpay()
    {
      this.r.navigate(['/addpayroll']);
    }
  
}

// export class AddemployeeComponent implements OnInit {

 
//   constructor(private p:MyloginService) { }

// adde:empdetails={
//   EmployeeID:0,
//   EmployeeName:"",
  
  
//      DateOfBirth:new Date(),
//      Gender:"",
//      EmpStatus:"",
//      Designation:"",
//      DeptNo :0,
//      Address:"",
//      Nationality:"", 
//      PhoneNo :0,
//      WorkLocation:"",
//      JoiningDate:new Date(),
//      ManagerId:0


// }
//   ngOnInit(): void {
//     //this.p.addemployeedetails(addemployee);
//   }
//   loginstatus:number=0;
//   addemp(addemp1:empdetails):number
//   {
//     this.loginstatus=this.p.addemployeedetails(addemp1);
//     alert("Employee Added succesfully");
//     return this.loginstatus;
    
//   }

// }

