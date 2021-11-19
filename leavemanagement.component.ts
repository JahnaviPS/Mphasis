import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LeavemanagementService } from '../leavemanagement.service';
import { leavemanagent } from '../login/Models/LeaveManagement';


@Component({
  selector: 'app-leavemanagement',
  templateUrl: './leavemanagement.component.html',
  styleUrls: ['./leavemanagement.component.css']
})
export class LeavemanagementComponent implements OnInit {
  
  leavelist:Array<leavemanagent>=[];
  constructor(private p:LeavemanagementService,private r:Router) { }
 
    ngOnInit(): void {
      this.p.getEvents().subscribe(data => {
        this.leavelist = data;
      });
  
    }
    

 
}
