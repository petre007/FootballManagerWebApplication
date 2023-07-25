import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { UserService, User } from 'D:/matlab/AN3 sem2/II/Lab1/frontend_angular/angular/coreui-free-angular-admin-template-main (1)/coreui-free-angular-admin-template-main/src/app/services/user-service.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})


export class LoginComponent {

  user = {
    id: 0,
    username: "",
    password: "",
    context: ""
  }

  username: string = ""
  password: string = ""
  constructor(private userService: UserService) { }


  getUsernameAndPassword(username: string, password: string): User {
    return {
      username: username,
      password: password,
      context: ""
    };
  }

  getLogin(username: string, password: string): void {
    try{
      this.userService.getUser(this.getUsernameAndPassword(username, password))
    } catch (catchError) {
      alert("Username or password incorect")
    }
  }

}
