using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Services;
using Moq;
using Xunit;

namespace CleanArchitecture.Test
{
  public class StudentServiceTest
    {
        private Mock<IRepositoryAsync<Student>> studentRepository;
        private StudentService studentService;
        //private readonly IUnitOfWork unit;
        public StudentServiceTest()
        {
            studentRepository = new Mock<IRepositoryAsync<Student>>();
        }

        [Fact]
        public void Get_By_Id_Existing()
        {
            var repo = studentRepository.Object;
            var alumno = new Student() { Id = 1 };
            var unit = new Mock<IUnitOfWork>();
            //Arrange
            studentRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(alumno);
            unit.Setup(x => x.Student.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(alumno);
            //Act
            studentService = new StudentService(unit.Object);
            var result = studentService.GetByIdAsync(1);

            //Assert
            Assert.NotNull(result);
            unit.Verify(x => x.Student.GetByIdAsync(It.IsAny<int>()), Times.Once());
    }
  }
}
