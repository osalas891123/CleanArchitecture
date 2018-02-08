using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(Data.Context context) : base(context) {} 
    }
}
