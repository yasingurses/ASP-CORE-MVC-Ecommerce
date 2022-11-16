using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICategoryService
    {
        int AddCategory(Category category);
        int UpdateCategory(Category category);
        int DeleteCategory(Category category);
        List<Category> GetAllCategory();
        Category GetCategoryById(int id);
    }
}
