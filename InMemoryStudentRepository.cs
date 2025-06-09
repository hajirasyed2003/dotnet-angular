using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using case_study_testing.StudentDAL.Domain;

namespace case_study_testing.StudentDAL.Repository
{
    public class InMemoryStudentRepository: IStudentRepository<Student>
    {
        private readonly List<Student> students = new List<Student>
        {
            new Student { RollNo=1, Name="Hajira", Email="hajirasyed2003@gmail.com"},
            new Student { RollNo=2, Name="Priya", Email="priyaselvam@gmail.com" }
        };
         
            
     
        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetByRollNo(int rollNo)
        {
            Student result = students.Where(r => r.RollNo == rollNo).FirstOrDefault();
            return result;
        }

        public Student GetByName(string name)
        {
            Student result = students.Where(r => r.Name == name).FirstOrDefault();
            return result;

        }


        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Update(Student student)
        {
            Student result = students.Where(r => r.RollNo == student.RollNo).FirstOrDefault();
            result.Name = student.Name;
            result.Email = student.Email;
        }

        public void Delete(int rollNo)
        {
            Student result= students.Where(r => r.RollNo == rollNo).FirstOrDefault();
            students.Remove(result);
        }
    }
}
