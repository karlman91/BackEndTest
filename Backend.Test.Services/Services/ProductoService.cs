using Backend.Test.Model.Domain;
using Backend.Test.Persistance.Repositories;
using Backend.Test.Services.Contracts;
using Backend.Test.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Services.Services
{
    public class ProductoService : IProductoService
    {
        private IProductoRepository _context;
        public ProductoService(IProductoRepository context) { 
            _context = context;
        }
        public ProductoDomain FindById(int id)
        {
            return _context.FindById(id).toProductoDomain();
        }

        public IList<ProductoDomain> GetAll()
        {
            return _context.GetAll().MapToProductoDomainList();
        }

        public bool Remove(int id)
        {
            return _context.Remove(id);
        }

        public bool Save(ProductoDomain entity)
        {
            return _context.Save(entity.toProducto());
        }
    }
}
