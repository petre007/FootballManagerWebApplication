import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

const goals_ratio_url = "http://localhost:5237/goalratio"
const budget_url = "http://localhost:5237/budget"
const fans_url = "http://localhost:5237/fans"



@Injectable({
  providedIn: 'root'
})
export class BotService {

  data_goals: GoalRatio[] = []
  data_budget: Budget[] = []
  data_fans: Fans[] = []

  fans_num: number[] = []
  budget_num: number[] = []
  goals_num: number[] = []

  constructor(private http: HttpClient) { }

  getBudget(): number[] {
    this.http.get<Budget[]>(budget_url).subscribe(data=>{
      this.data_budget = data;
      for(let i=0; i<this.data_budget.length; i++){
        this.budget_num.push(this.data_budget[i].money)
      }
    })

    return this.budget_num;
  }

  getFans(): number[] {
    this.http.get<Fans[]>(fans_url).subscribe(data=>{
      this.data_fans = data;
      for(let i=0; i<this.data_fans.length; i++){
        this.fans_num.push(this.data_fans[i].fansNumber)
      }
    })

    return this.fans_num;
  }

  getGoals(): number[] {
    this.http.get<GoalRatio[]>(goals_ratio_url).subscribe(data=>{
      this.data_goals = data;
      for(let i=0; i<this.data_goals.length; i++){
        this.goals_num.push(this.data_goals[i].goals)
      }
    })

    return this.goals_num;
  }
}


export interface Budget {

  id: number;

  money: number;

}

export interface Fans {
  
  id: number;

  fansNumber: number;

}


export interface GoalRatio {

  id: number;

  goals: number;

}