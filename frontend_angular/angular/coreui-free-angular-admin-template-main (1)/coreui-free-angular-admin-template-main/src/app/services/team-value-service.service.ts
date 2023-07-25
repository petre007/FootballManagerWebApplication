import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

const baseUrl = "http://localhost:5237/teamvalue"

const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
    })
  };

@Injectable({
    providedIn: 'root'
})
export class TeamValueService {

    data: TeamValue[] = []

    constructor(private http: HttpClient) { }

    getTeamValue() : TeamValue[]{
      this.http.get<TeamValue[]>(baseUrl).subscribe(data=>{
        this.data = data;
      });
      return this.data
    }

}


export interface TeamValue {

  id: number | undefined;

  value: number | undefined;

}
