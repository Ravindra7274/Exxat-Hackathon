import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class WorkoutService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'http://localhost:53877/api/workouts';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
  }

get(ClientId:any,StudentName:any){
    return this.http.get(this.accessPointUrl +'?ClientId=' + ClientId + '&StudentName=' + StudentName ,{headers:this.headers})
}
}
