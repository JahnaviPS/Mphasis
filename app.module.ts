import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import routs,{ AppRoutingModule } from './app-routing.module';

import { MyloginService } from './mylogin.service';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';



import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './employee.service';
import { HomeComponent } from './home/home.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { UpdateemployeeComponent } from './updateemployee/updateemployee.component';
import { LeavemanagementComponent } from './leavemanagement/leavemanagement.component';
import { PayrollComponent } from './payroll/payroll.component';
import { AddpayrollComponent } from './addpayroll/addpayroll.component';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    EmployeeComponent,
    HomeComponent,
    AddemployeeComponent,
    UpdateemployeeComponent,
    LeavemanagementComponent,
    PayrollComponent,
    AddpayrollComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    RouterModule.forRoot(routs),
    FormsModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
