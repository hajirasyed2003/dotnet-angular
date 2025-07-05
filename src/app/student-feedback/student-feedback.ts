import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Student } from '../model/studentfeedback';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-student-feedback',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './student-feedback.html',
  styleUrl: './student-feedback.css'
})
export class StudentFeedback {
  feedback: Student = {
    studentName: '',
    courseName: '',
    rating: 1,
    comments: ''
};

courses: string[] = ['Angular', 'React', 'Vue', 'Node.js'];
}