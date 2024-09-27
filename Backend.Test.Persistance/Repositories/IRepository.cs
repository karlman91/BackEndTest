using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Persistance.Repositories
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository where TEntity : class
    {
        bool Save(TEntity entity);
        IList<TEntity> GetAll();
        TEntity FindById(int id);
        bool Remove(int id); 
    }
}
