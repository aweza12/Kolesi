import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit {
  public claims: [] = [];
  constructor(private _adminService: AdminService) { }
  ngOnInit(): void {
    //this.getClaims();
  }
  // public getClaims = () =>{
  //   this._adminService.getClaims('api/companies/privacy')
  //   .subscribe(res => {
  //     this.claims = res as [];
  //   })
  // }
}
