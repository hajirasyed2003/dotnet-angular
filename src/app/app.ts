
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  template: `
    <h1>User Registration Case Study</h1>
    <nav>
      <a routerLink="/template-form">Template Form</a> |
      <a routerLink="/reactive-form">Reactive Form</a>
    </nav>
    <router-outlet></router-outlet>
  `,
})
export class App {}
