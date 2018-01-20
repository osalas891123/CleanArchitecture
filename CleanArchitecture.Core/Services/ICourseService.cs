using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Services
{
    public interface ICourseService
    {
        void Add(Course course);
        List<Course> GetAllCourses();
    }
}
