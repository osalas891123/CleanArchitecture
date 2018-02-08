using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>, IRepositoryAsync<Course>
    {
    }
}
