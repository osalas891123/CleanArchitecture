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
        private StudentService alumnoService;
        public StudentServiceTest()
        {
            studentRepository = new Mock<IRepository<Student>>();
        }

        [Fact]
        public void Get_By_Id_Existing()
        {
            var repo = studentRepository.Object;
            var alumno = new Student() { Id = 1 };

            //Arrange
            studentRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(alumno);

            //Act
            alumnoService = new StudentService(studentRepository.Object);
            var result = alumnoService.GetById(1);

            //Assert
            Assert.NotNull(result);
            studentRepository.Verify(x => x.GetById(It.IsAny<int>()), Times.Once());
        }
  }
}
