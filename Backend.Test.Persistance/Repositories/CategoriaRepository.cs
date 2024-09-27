using Backend.Test.Model.Data;
using Backend.Test.Persistance.DbContextApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Persistance.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApiDbContext _context;

        public CategoriaRepository(ApiDbContext context)
        {
            _context = context;
        }
        public Categoria FindById(int id) => _context.Categorias.Find(id);

        public IList<Categoria> GetAll()
        {
            return _context.Categorias.ToList();
        }
        public bool Remove(int id)
        {
            var categoria = _context.Categorias.Find(new { id });
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                return (_context.SaveChanges() > 0);
            }
            else
            {
                return false;
            }
        }

        public bool Save(Categoria entity)
        {
            _context.Categorias.Add(entity);
            return (_context.SaveChanges() > 0);
        }
    }
}
