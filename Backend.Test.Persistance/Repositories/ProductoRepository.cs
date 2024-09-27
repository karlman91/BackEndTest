using Backend.Test.Model.Data;
using Backend.Test.Persistance.DbContextApi;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Persistance.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApiDbContext _context;

        public ProductoRepository(ApiDbContext context) { 
            _context = context;
        }
        public Producto FindById(int id) => _context.Productos.Find(id);

        public IList<Producto> GetAll()
        {
            return _context.Productos.ToList();
        }
        public bool Remove(int id)
        {
            var producto = _context.Productos.Find(new { id });
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                return (_context.SaveChanges() > 0);
            }
            else
            {
                return false;
            }
        }

        public bool Save(Producto entity)
        {
            _context.Productos.Add(entity);
            return (_context.SaveChanges() > 0);
        }
    }
}
