using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public int AddCategory(Category category)
        {
            return categoryDal.Add(category);
        }

        public int DeleteCategory(Category category)
        {
            return categoryDal.Delete(category);
        }

        public List<Category> GetAllCategory()
        {
            return categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return categoryDal.getByID(id);
        }

        public int UpdateCategory(Category category)
        {
            return categoryDal.Update(category);
        }
    }
}
