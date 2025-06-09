using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using case_study_testing.StudentDAL.Domain;

namespace case_study_testing.StudentDAL.Repository
{
    public interface IStudentRepository<T>

    {

        public List<Student> GetAll();

        public Student GetByRollNo(int rollNo);

        public Student GetByName(string name);

        public void Add(Student student);

        public void Update(Student student);

        public void Delete(int rollNo);

    }
}
