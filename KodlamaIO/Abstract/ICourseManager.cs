using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Abstract
{
    public interface ICourseManager
    {
        List<Course> GetAll();
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
    }
}
