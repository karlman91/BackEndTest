using Backend.Test.Model.Data;
using Backend.Test.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Services.Mappers
{
    public static class CategoriaMapper
    {
        public static CategoriaDomain toCategoriaDomain(this Categoria obj)
        {
            return new CategoriaDomain()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,
                Productos = obj.Productos
            };
        }

        public static Categoria toCategoriaDomain(this CategoriaDomain obj)
        {
            return new Categoria()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,
                Productos = obj.Productos
            };
        }

        public static IList<CategoriaDomain> MapToCategoriaDomainList(this IList<Categoria> obj)
        {
            if (obj == null || obj.Count == 0)
                return new List<CategoriaDomain>();

            return obj.Select(_obj => new CategoriaDomain
            {
                Id = _obj.Id,
                Nombre = _obj.Nombre,
                Productos = _obj.Productos
            }).ToList();
        }


    }
}
