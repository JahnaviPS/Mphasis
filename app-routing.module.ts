import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { EmployeeComponent } from './employee/employee.component';
import { HomeComponent } from './home/home.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { UpdateemployeeComponent } from './updateemployee/updateemployee.component';
import { leavemanagent } from './login/Models/LeaveManagement';
import { LeavemanagementComponent } from './leavemanagement/leavemanagement.component';
import { PayrollService } from './payroll.service';
import { PayrollComponent } from './payroll/payroll.component';
import { AddpayrollComponent } from './addpayroll/addpayroll.component';
const routes: Routes = [
  {path:'LoginPage',component:LoginComponent},
  {path:'employee',component:EmployeeComponent},
  // {path:'home',component:homeComponent}
  {path:'home',component:HomeComponent},
  {path:'addemployee',component:AddemployeeComponent},
{path:'updateemployee',component:UpdateemployeeComponent},
{path:'leavemanagement',component:LeavemanagementComponent},
{path:'payroll',component:PayrollComponent},
{path:'addpayroll',component:AddpayrollComponent}
  
];
export default routes;
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }