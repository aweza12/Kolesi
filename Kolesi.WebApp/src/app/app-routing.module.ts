import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { AuthGuard } from './services/guards/auth.guard';
import { AdminComponent } from './components/admin/admin.component';
import { AdminGuard } from './services/guards/admin.guard';
import { CreateBikeComponent } from './components/bikes/create-bike/create-bike.component';
import { ReadyBikesComponent } from './components/bikes/ready-bikes/ready-bikes.component';
import { MyBikesComponent } from './components/bikes/my-bikes/my-bikes.component';
import { AddPartComponent } from './components/parts/add-part/add-part.component';
import { PartsComponent } from './components/parts/parts/parts.component';
import { UserComponent } from './components/user/user.component';

const routes: Routes = [
  { path: '', component: HomeComponent, data: { title: 'Kolesi' } },
  { path: 'register', component: RegisterComponent, data: { title: 'Register' } },
  { path: 'login', component: LoginComponent, data: { title: 'Login' } },

  { path: 'create-bike', component: CreateBikeComponent, data: { title: 'Create Bike' }  },
  { path: 'my-bikes', component: MyBikesComponent, data: { title: 'My Bikes' }, canActivate: [AuthGuard]  },
  { path: 'ready-bikes', component: ReadyBikesComponent, data: { title: 'Ready Bikes' }  },

  { path: 'add-part', component: AddPartComponent, data: { title: 'Add Part' }  },
  { path: 'ready-parts', component: PartsComponent, data: { title: 'Ready Parts' }  },

  { path: 'user', component: UserComponent, data: { title: 'My Page' }, canActivate: [AuthGuard]  },
  { path: 'admin', component: AdminComponent, data: { title: 'Admin' }, canActivate: [AuthGuard, AdminGuard]  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
