using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Interfaces
{
    public interface IBaseUnitOfWork<TDbContext> : IDisposable
        where TDbContext: IDisposable, IObjectContextAdapter
    {
        TDbContext Context { get; }

        int Complete();
        void BeginTransaction();
        void RollBackTransaction();
        void CommitTransaction();
    }
}
