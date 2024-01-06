using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAync();
        void Commit();

    }
}
