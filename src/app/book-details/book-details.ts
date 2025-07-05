import { Component } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Book } from '../model/book';

@Component({
  selector: 'app-book-details',
  standalone: true,
  imports: [CommonModule, RouterModule],
  template: `
    <h2>Book Details:</h2>
    <div *ngIf="book">
      <p><strong>Title:</strong> {{ book.title }}</p>
      <p><strong>Author:</strong> {{ book.author }}</p>
      <p><strong>Price:</strong> ₹{{ book.price }}.00</p>
      <p><strong>Description:</strong> {{ book.description }}</p>
    </div>
    <div *ngIf="!book">
      <p>Book not found.</p>
    </div>
  `
})
export class BookDetails {
  book: Book | undefined;

  books: Book[] = [
    { id: 1, title: 'Angular Basics', author: 'John Doe', price: 299, description: 'Learn Angular step by step.' },
    { id: 2, title: 'TypeScript Mastery', author: 'Max Programmer', price: 499, description: 'Deep dive into TypeScript and type safety...' },
    { id: 3, title: 'RxJS Deep Dive', author: 'Jane Smith', price: 399, description: 'Advanced concepts of RxJS explained.' },
  ];

  constructor(private route: ActivatedRoute) {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.book = this.books.find(b => b.id === id);
  }
}
