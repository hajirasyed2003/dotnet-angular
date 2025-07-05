
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterModule],
  template: `
    <nav style="padding: 1rem; background: #f5f5f5;">
      <a routerLink="/" style="margin-right: 15px;">Home</a>
      <a routerLink="/books">Book List</a>
    </nav>
    <router-outlet></router-outlet>
  `
})
export class App {}
