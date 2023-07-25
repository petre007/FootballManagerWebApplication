import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { Router } from '@angular/router';

const baseUrl = "http://localhost:5237/user"


@Injectable({
    providedIn: 'root'
})
export class UserService{


    constructor(private router: Router ,private http: HttpClient) { }

    goToDashboard(): void{
        const navigationDetails: string[] = ['/dashboard']
        this.router.navigate(navigationDetails);
      }

    getUser(user: User) {
        return this.http.post<User>(baseUrl, user).subscribe(
            data=>{
                if (data.context != "MANAGER") {
                    alert("Access denied!")
                } else {
                    this.goToDashboard()
                }
                console.log(data)
            }
        );
    }

    putUser(user: User) {
        this.http.put(baseUrl, user).subscribe(response=>{
            console.log(response);
          },
          error => {
            console.log(error);
            
          });
    }

}


export interface User {

    username: string

    password: string

    context: string

}

