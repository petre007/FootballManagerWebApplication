import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';


const baseUrl = "http://localhost:5237/player/"

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json',
  })
};

@Injectable({
  providedIn: 'root'
})
export class PlayerServiceService {

  playerData: Player[] = []

  constructor(private http: HttpClient) { }

  getPlayers(): Observable<Player[]> {
    return this.http.get<Player[]>(baseUrl);
  }

  getPlayerById(id:number) {
    return this.http.get<Player>(baseUrl+id);
  }

  putPlayer(player: Player) {
    this.http.put<Player>(baseUrl, player);
  }

  deletePlayer(id: number) {
    return this.http.delete<Player>(baseUrl+id).subscribe(data=>{
    });
  }

}


export interface Player {

  id: number;

  firstName: string;

  lastName: string;

  country: string;

  position: string;

  age: number;

}