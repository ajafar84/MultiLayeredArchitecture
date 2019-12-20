using MultilayeredArchitecture.Common.Interfaces;
using MultilayeredArchitecture.DataAccess.Contexts;
using System;
using System.Data.Entity;

namespace Scriptex.EmployeeTask.Common.Repositories
{
    public interface IUnitOfWork : IBaseUnitOfWork<Context>
    {

        #region Repositories
        //IEmployeeRepository Employees { get; }
        //IJobRepository Jobs { get; }
        #endregion

        IRepository<TEntity> BaseRepository<TEntity>() where TEntity : class;
    }
}
