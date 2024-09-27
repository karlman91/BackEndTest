using Backend.Test.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Services.Contracts
{
    public interface IProductoService
    {
        IList<ProductoDomain> GetAll();
        ProductoDomain FindById(int id);
        bool Remove(int id);
        bool Save(ProductoDomain entity);
    }
}
