import {Department} from "./Department-enum";

export interface Employee
{
    name: string,
    age: number,
    department: Department,
    baseSalary: number
}