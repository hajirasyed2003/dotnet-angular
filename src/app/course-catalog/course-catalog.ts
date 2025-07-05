import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Course } from '../model/course';

@Component({
  selector: 'app-course-catalog',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-catalog.html',
})
export class CourseCatalogComponent {
  courses: Course[] = [
    {
      id: 1,
      title: 'Angular Fundamentals',
      instructor: 'John Doe',
      startDate: new Date('2025-07-10'),
      price: 499.99,
      description: 'Learn Angular from scratch with hands-on examples and projects.',
    },
    {
      id: 2,
      title: 'Advanced TypeScript',
      instructor: 'Jane Smith',
      startDate: new Date('2025-08-01'),
      price: 599.49,
      description: 'Master advanced TypeScript techniques and design patterns.',
    }
   
  ];
}
