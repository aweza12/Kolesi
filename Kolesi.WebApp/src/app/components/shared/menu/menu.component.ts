import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
  public isUserAuthenticated: boolean = false;

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit(): void {
    this.isUserAuthenticated = this.authService.isUserAuthenticated();

    // this.authService.authChanged
    // .subscribe(res => {
    //   this.isUserAuthenticated = res;
    // })
  }

  public logout = () => {
    this.authService.logout();
    this.router.navigate(["/"]);
  }
}
