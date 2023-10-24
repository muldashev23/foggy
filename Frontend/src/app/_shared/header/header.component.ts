import { Component, HostListener } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '../../_servises/account.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent {
  windowWidth: number;

  constructor(public accountService: AccountService, private router: Router) {
    this.windowWidth = window.innerWidth;
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }
  @HostListener('window:resize', ['$event'])
  onResize(event: Event): void {
    this.windowWidth = window.innerWidth;
  }
}
