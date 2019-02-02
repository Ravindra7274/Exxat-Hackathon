import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from "@angular/router";
import {FormsModule} from "@angular/forms";
import {StudentsComponent} from "./students.component";
import {studentRoutes} from "./students.routes";

@NgModule({
  imports: [
      CommonModule,
      FormsModule,
      RouterModule.forChild(studentRoutes)
  ],
  declarations: [
    StudentsComponent
  ],
})
export class StudentsModule { }
