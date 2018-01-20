﻿using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Services
{
    public interface IStudentService
    {
        void Add(Student student);
        List<Student> GetAllStudents();
    }
}