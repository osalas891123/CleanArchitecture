using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Core.Services;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork unit;
        public StudentService(IUnitOfWork unit)
        {
            this.unit = unit;
        }        

        public void Add(Student student)
        {            
            unit.Student.Add(student);
            unit.Commit();
        }

        public Student GetById(int id)
        {
            return unit.Student.GetById(id);
        }        
    }
}
