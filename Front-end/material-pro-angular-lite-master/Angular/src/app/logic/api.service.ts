import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()

export class ApiService {
    private headers: HttpHeaders;
    private accessPointUrl: string = 'http://localhost:53877/';

    constructor(private http: HttpClient) {
        this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
    }

    getStudentList(ClientId: any, StudentName: any) {
        return this.http.get(this.accessPointUrl + '' +'?ClientId=' + ClientId + '&StudentName=' + StudentName, { headers: this.headers });
    }

    getModules(){
        return this.http.get(this.accessPointUrl+'Module',{headers:this.headers});
    }

    getCommonQueries(moduleName:any){
        return this.http.get(this.accessPointUrl + '' + '?moduleName=' +moduleName , {headers:this.headers});
    }
}
