import {Course} from "../Models/course"

export interface Student {
    name: string;
    age: number;
    courseName: Course;
    knowsHTML: boolean;
  }