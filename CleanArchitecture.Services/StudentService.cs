using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<Student> studentRepository;
        public StudentService(IRepository<Student> studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            //var list = new List<Student>();
            //list.Add(new Student() { Name = "Jose", LastName = "Perez" });
            //return list;
            return studentRepository.GetBy(x => x.Id == 1);
        }
    }
}
