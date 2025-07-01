import {Department} from "./Models/Department-enum"
import {Employee} from "./Models/Employee"
import { EmployeeManager } from "./Service/service"

const manager=new EmployeeManager();
manager.addEmployee({name: "Hajira",age: 22, department: Department.IT, baseSalary: 50000});
manager.generateReport();