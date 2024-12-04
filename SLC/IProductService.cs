using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLC
{
    public interface IProductService
    {
        Products CreateProducts(Products products);
        Products RetrieveById(int id);
        bool Update(Products product);
        bool Delete(int id);
        List<Products> Filter(string filterName);
    }
}
