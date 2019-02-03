import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiService } from '../../logic/api.service';
import { SupportModule } from '../../models/support.module.model';
import { SupportProblem } from '../../models/support.problem.model';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.scss']
})
export class StudentComponent implements OnInit {
  isLinear = false;
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  modules: Array<any>;
showpanel:boolean;

  commonQueries: Array<any>[];
  filteredStudent: Array<any>;


  status: boolean;

  constructor(private _formBuilder: FormBuilder,
    private _apiservice: ApiService) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
    this.getModules();

  }

  getModules() {
    this._apiservice.getModules().subscribe((data: Array<any>) => {
      this.modules = data;
    }
    );
  }

  getStudentList(clientId: any, studentName: any) {
    this._apiservice.getStudentList(clientId, studentName).subscribe((data: any) => {
      this.filteredStudent = data
    }
    );
  }

  getCommonQueries(moduleId) {
    this._apiservice.getCommonQueries(moduleId).subscribe((data: any) => {this.commonQueries = data});
  }


}
