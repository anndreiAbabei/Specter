import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { ScrollingModule } from '@angular/cdk/scrolling';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { JwtInterceptor } from '../services/interceptors/jwt.interceptor';
import { ErrorInterceptor } from '../services/interceptors/error.interceptor';
import { AuthGuard } from '../services/auth.guard';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { TimesheetComponent } from './timesheet/timesheet.component';
import { TimesheetTableComponent } from './timesheet-table/timesheet-table.component';
import { LoginComponent } from './user-management/login/login.component';
import { RegisterComponent } from './user-management/register/register.component';
import { ForgotPasswordComponent } from './user-management/forgot-password/forgot-password.component';
import { LogoutComponent } from './user-management/logout/logout.component';
import { ReportsComponents } from './reports/reports.component';

import { TimesheetEditDialog } from './timesheet/timesheet-edit-dialog/timesheet-edit-dialog.component';
import { ReportsFilterComponents } from './reports/reports-filter/reports-filter.component';

import { NgHttpLoaderModule } from 'ng-http-loader';

import {
  MatDatepickerModule,
  MatInputModule,
  MatNativeDateModule,
  MatSelectModule,
  MatButtonModule,
  MatButtonToggleModule,
  MatCheckboxModule,
  MatMenuModule,
  MatTableModule,
  MatIconModule,
  MatDialogModule,
  MatSnackBarModule
} from '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    TimesheetComponent,
    ReportsComponents,
    TimesheetTableComponent,
    ReportsFilterComponents,
    LoginComponent,
    RegisterComponent,
    ForgotPasswordComponent,
    LogoutComponent,
    TimesheetEditDialog
  ],
  exports: [
    DragDropModule,
    ScrollingModule,
    BrowserAnimationsModule,
    BrowserModule,
    FormsModule,
    MatDatepickerModule,
    MatInputModule,
    MatSelectModule,
    MatNativeDateModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCheckboxModule,
    MatMenuModule,
    MatTableModule,
    MatIconModule,
    MatDialogModule,
    MatSnackBarModule,
    TimesheetTableComponent,
    ReportsFilterComponents,
    TimesheetEditDialog
  ],
  imports: [
    HttpClientModule,
    DragDropModule,
    ScrollingModule,
    BrowserAnimationsModule,
    BrowserModule,
    FormsModule,
    MatDatepickerModule,
    MatInputModule,
    MatSelectModule,
    MatNativeDateModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCheckboxModule,
    MatMenuModule,
    MatTableModule,
    MatIconModule,
    MatDialogModule,
    MatSnackBarModule,
    NgHttpLoaderModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' , canActivate: [AuthGuard]},
      { path: 'timesheet', component: TimesheetComponent, canActivate: [AuthGuard] },
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent },
      { path: 'forgot', component: ForgotPasswordComponent },
      { path: 'logout', component: LogoutComponent},
      { path: 'reports', component: ReportsComponents, canActivate: [AuthGuard]},
      { path: '**', redirectTo: '' }
    ])
  ],
  entryComponents: [
    TimesheetEditDialog
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
