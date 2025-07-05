import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Student } from './models/student.model';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent {
  students: Student[] = [
    { name: 'Alice', marks: 85, isActive: true },
    { name: 'Bob', marks: 45, isActive: false },
    { name: 'Charlie', marks: 60, isActive: true },
    { name: 'David', marks: 30, isActive: false }
  ];
}
