using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Core.Services;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork unit;
        public StudentService(IUnitOfWork unit)
        {
            this.unit = unit;
        }        

        public async Task AddAsync(Student student)
        {            
            await unit.Student.AddAsync(student);
            await unit.CommitAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            var student = await unit.Student.GetByIdAsync(id);
            return student;
        }        
    }
}
