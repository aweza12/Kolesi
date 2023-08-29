import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators  } from "@angular/forms";
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm : FormGroup = new FormGroup({
    email: new FormControl("", [Validators.required, Validators.email]),
    password: new FormControl("", Validators.required)
  });

  constructor(
    private _router: Router,
    //private authService: AuthService
  ) { }

  ngOnInit(): void {
  }

  onSubmit() {
    //if(this.loginForm.valid) {
      //this.isLoginInProces$.next(true);
      //this.authService.login(this.loginForm.value).subscribe(()=>{},() => {
        //this.isLoginInProces$.next(false);
      //})
    //}
    //this.authService.login(this.loginForm.value).subscribe(()=>{},() => {
      //this.isLoginInProces$.next(false);
    //})
  }
}
