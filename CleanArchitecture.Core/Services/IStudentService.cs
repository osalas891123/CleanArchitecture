using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    public interface IStudentService
    {
        Task AddAsync(Student student);
        Task<Student> GetByIdAsync(int id);
        Task<List<Student>> GetAllAsync();
    }
}
