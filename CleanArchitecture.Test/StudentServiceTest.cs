using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Services;
using Moq;
using Xunit;

namespace CleanArchitecture.Test
{
  public class StudentServiceTest
    {
        private Mock<IRepository<Student>> studentRepository;
        private StudentService studentService;
        //private readonly IUnitOfWork unit;
        public StudentServiceTest()
        {
            studentRepository = new Mock<IRepository<Student>>();
        }

        [Fact]
        public void Get_By_Id_Existing()
        {
            var repo = studentRepository.Object;
            var alumno = new Student() { Id = 1 };
            var unit = new Mock<IUnitOfWork>();
            //Arrange
            studentRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(alumno);
            unit.Setup(x => x.Student.GetById(It.IsAny<int>())).Returns(alumno);
            //Act
            studentService = new StudentService(unit.Object);
            var result = studentService.GetById(1);

            //Assert
            Assert.NotNull(result);
            unit.Verify(x => x.Student.GetById(It.IsAny<int>()), Times.Once());
    }
  }
}
