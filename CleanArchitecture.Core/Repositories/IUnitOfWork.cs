using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Repositories
{
    public interface IUnitOfWork
    {
        IStudentRepository Student { get; }
        ICourseRepository Curse { get; }
        void Commit();
        void RejectChanges();
        void Dispose();
    }
}
