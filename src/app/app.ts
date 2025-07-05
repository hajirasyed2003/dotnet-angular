import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CourseCatalogComponent } from './course-catalog/course-catalog';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CourseCatalogComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'myapp2';
}
