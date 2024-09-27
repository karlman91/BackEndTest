using Backend.Test.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Services.Contracts
{
    public interface ICategoriasService
    {
        IList<CategoriaDomain> GetAll();
        CategoriaDomain FindById(int id);
        bool Remove(int id);
        bool Save(CategoriaDomain entity);
    }
}
