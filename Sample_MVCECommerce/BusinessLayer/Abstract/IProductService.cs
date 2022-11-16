using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(Product product);
        List<Product> GetAllProduct();
        Product GetProductById(int id);

    }
}
