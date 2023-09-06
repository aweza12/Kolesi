import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './components/shared/menu/menu.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './components/register/register.component';
import { HttpClientModule } from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt";
import { environment } from 'src/environments/environment';
import { AdminComponent } from './components/admin/admin.component';
import { CreateBikeComponent } from './components/bikes/create-bike/create-bike.component';
import { MyBikesComponent } from './components/bikes/my-bikes/my-bikes.component';
import { ReadyBikesComponent } from './components/bikes/ready-bikes/ready-bikes.component';
import { AddPartComponent } from './components/parts/add-part/add-part.component';
import { PartsComponent } from './components/parts/parts/parts.component';
import { UserComponent } from './components/user/user.component';

export function tokenGetter() {
  return localStorage.getItem("token");
}

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent,
    AdminComponent,
    CreateBikeComponent,
    MyBikesComponent,
    ReadyBikesComponent,
    AddPartComponent,
    PartsComponent,
    UserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: [environment.allowedDomain],
        //disallowedRoutesRoutes: []
      }
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
