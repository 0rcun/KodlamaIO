using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetAll();
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
    }
}
