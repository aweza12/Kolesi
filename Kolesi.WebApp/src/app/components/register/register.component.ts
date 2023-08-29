import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserRegistrationDto } from 'src/app/models/UserRegistrationDto';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  registerForm : FormGroup = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required]),
    confirm: new FormControl('')
  });

  constructor(
    private _router: Router,
    private authService: AuthService
  ) { }

  ngOnInit(): void {
  }

  public validateControl = (controlName: string) => {
    return this.registerForm.get(controlName)!.invalid && this.registerForm.get(controlName)!.touched
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.registerForm.get(controlName)!.hasError(errorName)
  }

  onSubmit() {
    // if(this.registerForm.valid) {
    //   this.isLoginInProces$.next(true);
    //   this.authService.login(this.loginForm.value).subscribe(()=>{},() => {
    //     this.isLoginInProces$.next(false);
    //   })
    // }
    //const formValues = { ...registerFormValue };

    const user: UserRegistrationDto = {
      firstName: this.registerForm.value.firstName,
      lastName: this.registerForm.value.lastName,
      email: this.registerForm.value.email,
      password: this.registerForm.value.password,
      confirmPassword: this.registerForm.value.confirm
    };

    this.authService.register(user).subscribe(()=>{},() => {
      //this.isLoginInProces$.next(false);
    })
  }

}
