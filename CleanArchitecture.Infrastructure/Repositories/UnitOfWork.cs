using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
  public class UnitOfWork : IUnitOfWork
  {
      private Context context;
      private StudentRepository _student;
      private CourseRepository _course;
      public UnitOfWork(Context context)
      {
          this.context = context;
      }

      
      public IStudentRepository Student
      {
          get
          {
            return _student ?? new StudentRepository(context);
          }
      }

      public ICourseRepository Curse
      {
          get
          {
            return _course ?? new CourseRepository(context);
          }
      }

      public void Commit()
      {
          context.SaveChanges();
      }

      public void Dispose()
      {
        //throw new NotImplementedException();
      }

      public void RejectChanges()
      {
        throw new NotImplementedException();
      }
  }
}
