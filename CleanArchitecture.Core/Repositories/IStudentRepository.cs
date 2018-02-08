using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Repositories
{
    public interface IStudentRepository : IRepository<Student>, IRepositoryAsync<Student>
    {
    }
}
