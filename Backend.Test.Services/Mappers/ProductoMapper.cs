using Backend.Test.Model.Data;
using Backend.Test.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Test.Services.Mappers
{
    public static class ProductoMapper
    {
        public static ProductoDomain toProductoDomain(this Producto obj)
        {
            return new ProductoDomain()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,
                Precio = $"${obj.Precio:N2}",
                Categoria = obj.Categoria,
                CategoriaId = obj.CategoriaId
            };
        }

        public static Producto toProducto(this ProductoDomain obj)
        {
            return new Producto()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,
                Precio = Convert.ToDecimal(obj.Precio),
                Categoria = obj.Categoria,
                CategoriaId = obj.CategoriaId
            };
        }

        public static IList<ProductoDomain> MapToProductoDomainList(this IList<Producto> productos)
        {
            if (productos == null || productos.Count == 0)
                return new List<ProductoDomain>();

            return productos.Select(producto => new ProductoDomain
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = $"${producto.Precio:N2}"
            }).ToList();
        }
    }
}
