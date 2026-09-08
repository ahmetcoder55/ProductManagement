using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.DataAccess.Abstract
{
    public interface IRepositoryManager:IAsyncDisposable
    {
        public IProductRepository Products { get; }

        Task<int> SaveChangesAsync();
    }
}
