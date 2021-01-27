using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Abstract
{
    public interface IEntityService<T> 
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
