using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDL;
using Entities;
using SLC;

namespace BLL
{
    public class ProductLogic: IProductService
    {
        public Products CreateProducts(Products products)
        {
            Products res = null;
            using (var r = RepositoryFactory.CreateRepository())
            {
                Products result = r.Retrieve<Products>(p => p.ProductName == products.ProductName);
                if (result == null)
                {
                    res = r.Create(products);
                }
                else
                {
                    Console.WriteLine("Producto ya existente");
                }
            }
            return res;
        }

        public Products RetrieveById(int id)
        {
            Products res = null;
            using (var r = RepositoryFactory.CreateRepository())
            {
                res = r.Retrieve<Products>(p => p.ProductID == id);
            }
            return res;
        }

        public bool Update(Products productsToUpdate)
        {
            bool res = false;
            using (var r = RepositoryFactory.CreateRepository())
            {
                Products temp = r.Retrieve<Products>(p => p.ProductName == productsToUpdate.ProductName && p.ProductID != productsToUpdate.ProductID);
                if (temp != null)
                {
                    res = r.Update(productsToUpdate);
                }
                else
                {
                    Console.WriteLine("Nombre ya existente");
                }
            }
            return res;
        }

        public bool Delete(int id)
        {
            bool res = false;
            var product = RetrieveById(id);
            if (product != null)
            {
                if (product.UnitsInStock == 0)
                {
                    using (var r = RepositoryFactory.CreateRepository())
                    {
                        res = r.Delete(product);
                    }
                }
                else
                {
                    Console.WriteLine("Producto con stock, no se puede eliminar");
                }
                }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }
            return res;
        }

        public List<Products> Filter(string filterName)
        {
            List<Products> res = null;
            using (var r = RepositoryFactory.CreateRepository())
            {
                res = r.Filter<Products>(p => p.ProductName.Contains(filterName));
            }
            return res;
        }
    }
}
