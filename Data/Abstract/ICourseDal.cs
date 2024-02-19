using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
    }
}
