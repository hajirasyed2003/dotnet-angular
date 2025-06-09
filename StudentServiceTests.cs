using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using case_study_testing.StudentDAL.Domain;
using case_study_testing.StudentDAL.Repository;
using case_study_testing.StudentDAL.Business_Logic;
using Moq;
using NUnit.Framework;

namespace case_study_testing.StudentTests
{
    [TestFixture]
    internal class StudentServiceTests
    {
        private Mock<IStudentRepository<Student>> _mockRepo;
        private StudentService _studentService;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IStudentRepository<Student>>();
            _studentService = new StudentService(_mockRepo.Object);
        }

        [Test]
        public void AddStudent_ShouldAllStudent()
        {
            Student student = new Student
            {
                RollNo=1, Name="Hajira", Email="hajirasyed2003@gmail.com"
            };

            _studentService.AddStudent(student);
            _mockRepo.Verify(r => r.Add(It.Is<Student>(s => s.Name == "Hajira")), Times.Once());
        }

        [Test]
        public void UpdateStudent_ShouldUpdateStudent()
        {
            Student student = new Student
            {
                RollNo = 1,
                Name = "Priya",
                Email = "priya@gmail.com"
            };

            _studentService.UpdateStudent(student);
            _mockRepo.Verify(r => r.Update(It.Is<Student>(s => s.RollNo == 1 && s.Name == "Priya")));
        }

        [Test]
        
        public void DeleteStudent_ShouldDeleteStudent()
        {
            int rollno = 1;
            _studentService.Delete(rollno);
            _mockRepo.Verify(r => r.Delete(rollno), Times.Once());
        }

        [Test]
        [TestCase(1)]
        public void GetStudentID_shouldReturnStudent(int rollno)
        {
            var student = new Student { RollNo = 1, Name = "Hajira", Email = "hajirasyed2003@gmail.com" };
            _mockRepo.Setup(r => r.GetByRollNo(rollno)).Returns(student);
            var result = _studentService.GetStudentID(rollno);
            Assert.That(result.RollNo, Is.EqualTo(rollno));
            _mockRepo.Verify(r => r.GetByRollNo(rollno), Times.Once());
        }


        [Test]
        [TestCase("Hajira")]
        public void GetStudentName_shouldReturnStudent(string name)
        {
            var student = new Student { RollNo = 1, Name = "Hajira", Email = "hajirasyed2003@gmail.com" };
            _mockRepo.Setup(r => r.GetByName(name)).Returns(student);
            var result = _studentService.GetStudentName(name);
            Assert.That(result.Name ,Is.EqualTo(name));
            _mockRepo.Verify(r => r.GetByName(name), Times.Once());
        }

        [Test]
        public void GetStudents_ShouldReturnAllStudents()
        {
            var students = new List<Student>
            {
                new Student { RollNo = 1, Name = "Hajira", Email = "hajira@example.com" },
                new Student { RollNo = 2, Name = "Priya", Email = "priya@example.com" }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(students);

            var result = _studentService.GetAllStudent();

            Assert.That(2, Is.EqualTo(students.Count));
            _mockRepo.Verify(r => r.GetAll(), Times.Once);
        }
    }
}
