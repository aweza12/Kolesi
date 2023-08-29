import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
//import { EnvironmentUrlService } from './environment-url.service';
import { environment } from 'src/environments/environment';
import { RegistrationResponseDto } from '../models/RegistrationResponseDto';
import { UserRegistrationDto } from '../models/UserRegistrationDto';
import { tap, catchError, throwError } from 'rxjs';
import { ErrorHandlerService } from './helpers/error-handler.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient, private errorHandler: ErrorHandlerService) { }
  // public registerUser = (route: string, body: UserRegistrationDto) => {
  //   return this.http.post<RegistrationResponseDto> (this.createCompleteRoute(route, `${environment.apiUrl}Auth/register`), body);
  // }
  // private createCompleteRoute = (route: string, envAddress: string) => {
  //   return `${envAddress}/${route}`;
  // }

  register(body: UserRegistrationDto) {
    return this.http
        .post<RegistrationResponseDto>(`${environment.apiUrl}accounts/Registration`, body)
        .pipe(
            tap(response => {}),

            catchError((error: HttpErrorResponse) => {
                this.errorHandler.handleError(error);

                return throwError(error);
            })
        );
}
}
