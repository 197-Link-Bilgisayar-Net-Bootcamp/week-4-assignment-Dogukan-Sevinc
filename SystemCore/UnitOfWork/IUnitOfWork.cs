using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace System.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommmitAsync();

        void Commit();
    }
}