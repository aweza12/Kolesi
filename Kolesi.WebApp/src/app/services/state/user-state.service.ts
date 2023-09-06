import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, map } from 'rxjs';
import { UserDto } from 'src/app/models/UserDto';

@Injectable({
  providedIn: 'root'
})
export class UserStateService {

  constructor() { }

  // currentUserSource = new BehaviorSubject<IExtractedUserFromJWT | null>(null);

  // currentUser$: Observable<UserDto | null> = this.currentUserSource.pipe(
  //   map((jwtUser: IExtractedUserFromJWT | null) => {
  //       if (jwtUser !== null) {

  //         return new User(jwtUser);
  //       }

  //       return null;
  //     }
  //   ));

  // isLoggedIn$ = this.currentUserSource.pipe(map(Boolean));
}
