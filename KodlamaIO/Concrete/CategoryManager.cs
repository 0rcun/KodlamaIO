using Entities;
using Entities.Concrete;
using KodlamaIO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly CategoryManager _categoryManager;

        public CategoryManager(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public void Add(Category category)
        {
            _categoryManager.Add(category);
        }

        public void Delete(int id)
        {
            _categoryManager.Delete(id);
        }

        public void Update(Category category)
        {
            _categoryManager.Update(category);
        }

        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }

        List<Category> ICategoryManager.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
