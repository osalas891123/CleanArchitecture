using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Repositories
{
    public interface IUnitOfWork
    {
        IStudentRepository Student { get; }
        ICourseRepository Curse { get; }
        void Commit();
        Task CommitAsync();
        void RejectChanges();
        void Dispose();
    }
}
