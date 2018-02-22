using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Services;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.Test
{
  public class StudentServiceTest
    {
        private Mock<IRepositoryAsync<Student>> studentRepository;
        private Mock<IUnitOfWork> unitOfWork;
        private StudentService studentService;
        //private readonly IUnitOfWork unit;
        public StudentServiceTest()
        {
            studentRepository = new Mock<IRepositoryAsync<Student>>();
            unitOfWork = new Mock<IUnitOfWork>();
        }

        [Fact]
        public void Get_All_Students()
        {
            var studentList = new List<Student>();
            studentList.Add(new Student() { Id = 1 });
            studentList.Add(new Student() { Id = 2 });
            studentList.Add(new Student() { Id = 3 });
        
            //Arrange
            //studentRepository.Setup(x => x.GetAllAsync()).ReturnsAsync(studentList);
            unitOfWork.Setup(x => x.Student.GetAllAsync()).ReturnsAsync(studentList);

            //Act
            var studentService = new StudentService(unitOfWork.Object);
            var students = studentService.GetAllAsync();

            //Assert
            Assert.NotNull(students);
            Assert.Equal(students.Result.Count, studentList.Count);
            unitOfWork.Verify(x => x.Student.GetAllAsync(), Times.Once());  
        }

        [Fact]
        public void Get_All_Students_With_EmptyList()
        {
          var studentList = new List<Student>();

          //Arrange
          unitOfWork.Setup(x => x.Student.GetAllAsync()).ReturnsAsync(studentList);

          //Act
          var studentService = new StudentService(unitOfWork.Object);
          var students = studentService.GetAllAsync();

          //Assert
          Assert.NotNull(students);
          Assert.Equal(students.Result.Count, studentList.Count);
          unitOfWork.Verify(x => x.Student.GetAllAsync(), Times.Once());
        }

        [Fact]
        public void Get_By_Id_Existing()
        {
            var repo = studentRepository.Object;
            var alumno = new Student() { Id = 1 };
            //Arrange
            //studentRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(alumno);
            unitOfWork.Setup(x => x.Student.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(alumno);
            //Act
            studentService = new StudentService(unitOfWork.Object);
            var result = studentService.GetByIdAsync(1);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.Result.Id, alumno.Id);
            unitOfWork.Verify(x => x.Student.GetByIdAsync(It.IsAny<int>()), Times.Once());
        }
  }
}
