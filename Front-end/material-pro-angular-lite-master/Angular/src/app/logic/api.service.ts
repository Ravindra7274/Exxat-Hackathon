import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders,HttpClientModule  } from '@angular/common/http';

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
        return this.http.get(this.accessPointUrl+'Module',{headers:this.headers});
    }

    getCommonQueries(moduleId:any){
        return this.http.get(this.accessPointUrl + '' + 'Query/' +moduleId , {headers:this.headers});
    }
}
