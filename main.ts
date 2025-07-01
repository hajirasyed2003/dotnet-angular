import { EnrollmentSystem } from "./Service/EnrollmentService";
import { Course } from "./Models/course";

const system = new EnrollmentSystem();

system.addStudent({ name: "Sneha", age: 20, courseName: Course.Angular, knowsHTML: true });
system.addStudent({ name: "Karan", age: 17, courseName: Course.NodeJS, knowsHTML: false });
system.addStudent({ name: "Riya", age: 22, courseName: Course.Angular, knowsHTML: false });
system.addStudent({ name: "Aman", age: 25, courseName: Course.FullStack, knowsHTML: true });

system.displaySummary();