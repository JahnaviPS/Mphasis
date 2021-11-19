import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, observable } from 'rxjs';
import { payroll } from './login/Models/Payroll';

@Injectable({
  providedIn: 'root'
})
export class PayrollService {
  public api='https://localhost:44352/api/PayRoll/displaypayroll';
 public getapi='https://localhost:44352/api/';

  constructor(private http:HttpClient) { }
  getEvents():Observable<Array<payroll>>{
 return this.http.get<Array<payroll>>(this.api);

}
public API='https://localhost:44352/api/PayRoll/InsertDetais';
mystatus:number=0;
 addpayroll(val:any)
  {

    this.http.post(this.API,val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus;
  }
}
