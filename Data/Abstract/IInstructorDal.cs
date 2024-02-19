using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor ınstructor);
        void Delete(int id);
        void Update(Instructor ınstructor);
    }
}
