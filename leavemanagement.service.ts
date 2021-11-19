import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, observable } from 'rxjs';
import { leavemanagent } from './login/Models/LeaveManagement';
leavemanagent
@Injectable({
  providedIn: 'root'
})
export class LeavemanagementService {
  public api='https://localhost:44352/api/LeaveManagement/showdetails';
public getapi='https://localhost:44352/api/';

constructor(private http:HttpClient) { }
  getEvents():Observable<Array<leavemanagent>>{
    return this.http.get<Array<leavemanagent>>(this.api);

  
}
    

}

