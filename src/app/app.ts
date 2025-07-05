import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { StudentFeedback } from './student-feedback/student-feedback';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, StudentFeedback],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'myapp2';
}
