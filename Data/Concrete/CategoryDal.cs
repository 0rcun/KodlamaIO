using Data.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class CategoryDal : ICategoryDal
    {
       
        private List<Category> _category;

        public CategoryDal()
        {
            _category = new List<Category>
            { 
                new Category{CategoryId=1,CategoryName="C#"},
                new Category{CategoryId=2,CategoryName="Javascript"}
            };

        }
        public void Add(Category category)
        {
            _category.Add(category);
        }

        public void Delete(int id)
        {
            Console.WriteLine("Category Delete");
        }

        public List<Category> GetAll()
        {
            foreach (Category category in _category)
            {
                Console.WriteLine("Category Name: "+(category.CategoryName));
            }
            return _category;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category Update");
        }

  
    }
}
