import { Course } from "../Models/course";
import { CourseCategory } from "../Models/coursecategory";
import { Student } from "../Models/student";

export class EnrollmentSystem {
    private students: Student[] = [];
  
    
    addStudent(student: Student): void {
      this.students.push(student);
    }
  

    private getCourseCategory(course: Course): CourseCategory {
      switch (course) {
        case Course.Angular:
          return CourseCategory.FrontEnd;
        case Course.NodeJS:
          return CourseCategory.BackEnd;
        case Course.FullStack:
          return CourseCategory.FullStack;
      }
    }
  
    
    private isEligible(student: Student): boolean {
      if (student.age < 18) return false;
  
      if (student.courseName === Course.Angular && !student.knowsHTML) return false;
  
      return true;
    }
  
   
    displaySummary(): void {
      for (const student of this.students) {
        const category = this.getCourseCategory(student.courseName);
        const eligibility = this.isEligible(student) ? "Eligible" : "Not Eligible";
  
        console.log(`Student Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Course: ${student.courseName}`);
        console.log(`Knows HTML: ${student.knowsHTML}`);
        console.log(`Course Category: ${category}`);
        console.log(`Enrollment Status: ${eligibility}`);
        
      }
    }
  }