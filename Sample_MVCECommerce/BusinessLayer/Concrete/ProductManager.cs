using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal productDal;
        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public int AddProduct(Product product)
        {
            return productDal.Add(product);
        }

        public int DeleteProduct(Product product)
        {
            return productDal.Delete(product);
        }

        public List<Product> GetAllProduct()
        {
            return productDal.GetAll();
        }

        public Product GetProductById(int id)
        {
            return productDal.getByID(id);
        }

        public int UpdateProduct(Product product)
        {
            return productDal.Update(product);
        }
    }
}
