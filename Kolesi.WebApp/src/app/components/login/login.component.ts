import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators  } from "@angular/forms";
import { Router } from '@angular/router';
import { AuthResponseDto } from 'src/app/models/AuthResponseDto';
import { UserAuthDto } from 'src/app/models/UserAuthDto';
import { AuthService } from 'src/app/services/auth.service';

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
    private _authService: AuthService
  ) { }

  ngOnInit(): void {
  }

  onSubmit() {
    if(this.loginForm.valid) {
      //this.isLoginInProces$.next(true);
      this._authService.login(this.loginForm.value).subscribe(()=>{
        //this._authService.sendAuthStateChangeNotification(res.isAuthSuccessful);
      },error => {
        //this.isLoginInProces$.next(false);
      })
    }
  }

  // loginUser = (loginFormValue: any) => {
  //   //this.showError = false;
  //   const login = {... loginFormValue };
  //   const userForAuth: UserAuthDto = {
  //     email: login.username,
  //     password: login.password
  //   }
  //   this._authService.loginUser('api/accounts/login', userForAuth)
  //   .subscribe({
  //     next: (res:AuthResponseDto) => {
  //      localStorage.setItem("token", res.token);
  //      //this.router.navigate([this.returnUrl]);
  //   },
  //   error: (err: HttpErrorResponse) => {
  //     this.errorMessage = err.message;
  //     this.showError = true;
  //   }})
  // }
}
