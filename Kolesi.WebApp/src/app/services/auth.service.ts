import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
//import { EnvironmentUrlService } from './environment-url.service';
import { environment } from 'src/environments/environment';
import { RegistrationResponseDto } from '../models/RegistrationResponseDto';
import { UserRegistrationDto } from '../models/UserRegistrationDto';
import { tap, catchError, throwError, Subject } from 'rxjs';
import { ErrorHandlerService } from './helpers/error-handler.service';
import { AuthResponseDto } from '../models/AuthResponseDto';
import { UserAuthDto } from '../models/UserAuthDto';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private authChangeSub = new Subject<boolean>()
  public authChanged = this.authChangeSub.asObservable();

  constructor(
    private http: HttpClient,
    private errorHandler: ErrorHandlerService,
    private router: Router,
    ) { }

  // public registerUser = (route: string, body: UserRegistrationDto) => {
  //   return this.http.post<RegistrationResponseDto> (this.createCompleteRoute(route, `${environment.apiUrl}Auth/register`), body);
  // }
  // private createCompleteRoute = (route: string, envAddress: string) => {
  //   return `${envAddress}/${route}`;
  // }
  public sendAuthStateChangeNotification = (isAuthenticated: boolean) => {
    this.authChangeSub.next(isAuthenticated);
  }

  public logout = () => {
    localStorage.removeItem("token");
    this.sendAuthStateChangeNotification(false);
  }

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

  login(body: UserAuthDto) {
		return this.http
			.post<AuthResponseDto>(
				`${environment.apiUrl}Auth/login`,
				body
			)
			.pipe(
				tap(response => {
					localStorage.setItem('jwt', response.token as string);
					//localStorage.setItem("refreshToken", response.refreshToken as string);
					//localStorage.setItem("refreshTokenExpiresIn", String(response.refreshTokenExpiresIn));
          this.sendAuthStateChangeNotification(response.isAuthSuccessful);
					//this.router.navigate(['/']);
				}),
				catchError((error: HttpErrorResponse) => {
					this.errorHandler.handleError(error);

					return throwError(error);
				})
			);
	}

  // public loginUser = (route: string, body: UserAuthDto) => {
  //   return this.http.post<AuthResponseDto>(this.createCompleteRoute(route, this.envUrl.urlAddress), body);
  // }
}
