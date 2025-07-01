import {Department} from "../Models/Department-enum"
import {Employee} from "../Models/Employee"

export class EmployeeManager{
    private employees: Employee[]=[];
    

    addEmployee(employee: Employee): void{
        this.employees.push(employee);
    }

    private calculateBonus(department: Department, baseSalary:number): number{
        switch(department)
        {
            case Department.HR:
                return 0.10*baseSalary;
            case Department.IT:
                return 0.15*baseSalary;
            case Department.Sales:
                return 0.12*baseSalary;
            default:
                return 0;
        }
    }

    private calculateNetSalary(department: Department, baseSalary:number): number {
        const bonus:number=this.calculateBonus(department,baseSalary);
        const netSalary:number=bonus+baseSalary;
        return netSalary;
    }

    private categorizeSalary(netSalary:number):string{
        if (netSalary>=80000) return "High Earner";
        else if (netSalary>=50000) return "Mid Earner";
        else return "Low Earner";
    }

    generateReport():void{
        for(const emp of this.employees){
            const bonus:number=this.calculateBonus(emp.department, emp.baseSalary);
            const netSalary:number=this.calculateNetSalary(emp.department, emp.baseSalary);
            const category:string=this.categorizeSalary(netSalary);
        
        console.log(`Employee Name: ${emp.name}`);
        console.log(`Age: ${emp.age}`);
        console.log(`Department: ${emp.department}`);
        console.log(`Base Salary: ${emp.baseSalary}`);
        console.log(`Net Salary (with bonus): ${netSalary}`);
        console.log(`Category: ${category}`);
        }   
    }
}