import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders,HttpClientModule  } from '@angular/common/http';
import { SupportModule } from '../models/support.module.model';
import 'rxjs/Rx';

@Injectable()

export class ApiService {
    private headers: HttpHeaders;
    private accessPointUrl: string = 'http://localhost:50495/';

    constructor(private http: HttpClient) {
        this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
    }

    getStudentList(ClientId: any, StudentName: any) {
        return this.http.get(this.accessPointUrl + '' +'?ClientId=' + ClientId + '&StudentName=' + StudentName, { headers: this.headers });
    }

    getModules(){
      debugger;
        return this.http.get(this.accessPointUrl+'Module',{headers:this.headers})
                        .map((data:any[])=>data);
    }

    getCommonQueries(moduleId:any){
        return this.http.get(this.accessPointUrl + '' + 'Module/' +moduleId , {headers:this.headers});
    }
}
