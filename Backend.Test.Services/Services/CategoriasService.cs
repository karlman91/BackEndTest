using Backend.Test.Model.Data;
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
    public class CategoriasService : ICategoriasService
    {
        private ICategoriaRepository _categoriaRepository;
        public CategoriasService(ICategoriaRepository categoriaRepository ) { 
            _categoriaRepository = categoriaRepository;
        }
        public CategoriaDomain FindById(int id)
        {
            return _categoriaRepository.FindById(id).toCategoriaDomain();
        }

        public IList<CategoriaDomain> GetAll()
        {
            return _categoriaRepository.GetAll().MapToCategoriaDomainList();
        }

        public bool Remove(int id)
        {
            return _categoriaRepository.Remove(id);
        }

        public bool Save(CategoriaDomain entity)
        {
            return _categoriaRepository.Save(entity.toCategoriaDomain());
        }
    }
}
