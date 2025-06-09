using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using case_study_testing.StudentDAL.Domain;
using case_study_testing.StudentDAL.Repository;

namespace case_study_testing.StudentDAL.Business_Logic
{
    public class StudentService

    {

        private readonly IStudentRepository<Student> _repo;

        public StudentService(IStudentRepository<Student> repo)

        {

            this._repo = repo;

        }

        public void AddStudent(Student student)
        {
            if (student!=null)
            {
                _repo.Add(student);
            }

        }

        public void UpdateStudent(Student student)
        {
            if (student != null)
            {
                _repo.Update(student);
            }
        }

        public void Delete(int r)
        {
            if (r != 0)
            {
                _repo.Delete(r);
            }
            
        }

        public List<Student> GetAllStudent()
        {
            return _repo.GetAll();
        }

        public Student GetStudentID(int r)
        {
            if(r!=0)
            {
                var result = _repo.GetByRollNo(r);
                return result;
            }
            else
            {
                return null;
            }
        }

        public Student GetStudentName(string n)
        {
            if (n != null)
            {
                var result = _repo.GetByName(n);
                return result;
            }
            else
            {
                return null;
            }
        }

        //Rest of code will go here 

    }
}
