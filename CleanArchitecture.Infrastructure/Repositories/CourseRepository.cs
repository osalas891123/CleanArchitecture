using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
          public CourseRepository(Data.Context context) : base(context) {}
    }
}
