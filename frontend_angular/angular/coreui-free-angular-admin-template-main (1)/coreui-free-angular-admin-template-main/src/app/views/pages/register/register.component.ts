import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserService, User } from 'D:/matlab/AN3 sem2/II/Lab1/frontend_angular/angular/coreui-free-angular-admin-template-main (1)/coreui-free-angular-admin-template-main/src/app/services/user-service.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {

  user = {
    id: 0,
    username: "",
    password: "",
  }

  username: string = ""
  password: string = ""
  repeat_password: string = ""


  constructor(private router: Router, private userService: UserService) { }

  
  goToDashboard(): void{
    const navigationDetails: string[] = ['/dashboard']
    this.router.navigate(navigationDetails);
  }

  getRegisterElements(username: string, password: string, repeat_password: string, context: string) {
    if(password === repeat_password) {
      alert("User created succesfully")
      return {
        id: 0,
        username: username,
        password: password,
        context: context
      }
    }else {
      alert("Invalid password confirmation, please insert the same password")
      throw new Error("Invalid password confirmation, please insert the same password")
    }
  }

  addUser(username: string, password: string, repeat_password: string, context: string): void {
    const data_put = this.getRegisterElements(username, password, repeat_password, context)
    console.log(data_put)
    this.userService.putUser(data_put);
  }

  


}
