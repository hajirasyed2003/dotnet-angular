import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { Book } from '../model/book';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  template: `
    <h2>Book List</h2>
    <ul>
      <li *ngFor="let book of books">
        {{ book.title }} - 
        <a [routerLink]="['/books', book.id]">View Details</a>
      </li>
    </ul>
  `
})
export class BookList {
  books: Book[] = [
    { id: 1, title: 'Angular Basics', author: 'John Doe', price: 299, description: 'Learn Angular step by step.' },
    { id: 2, title: 'TypeScript Mastery', author: 'Max Programmer', price: 499, description: 'Deep dive into TypeScript and type safety...' },
    { id: 3, title: 'RxJS Deep Dive', author: 'Jane Smith', price: 399, description: 'Advanced concepts of RxJS explained.' },
  ];
}
