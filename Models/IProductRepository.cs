using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        void Add(ProductModel product);
        void Edit(ProductModel product);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValues(string values);
        IEnumerable<ProductModel> GetByCategory(int categoryId);
        IEnumerable<ProductModel> GetByProvider(int providerId);
        IEnumerable<ProductModel> Search(string searchTerm);
    }
}
