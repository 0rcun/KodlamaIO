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
    public class InstructorManager : IInstructorManager
    {
        private readonly IInstructorManager _ınstructorManager;
        public InstructorManager(IInstructorManager ınstructorManager)
        {
            _ınstructorManager = ınstructorManager;
        }   

        public void Add(Instructor ınstructor)
        {
            _ınstructorManager.Add(ınstructor);
        }

        public void Delete(int id)
        {
            _ınstructorManager.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorManager.GetAll();
        }

        public void Update(Instructor ınstructor)
        {
            _ınstructorManager.Update(ınstructor);
        }

        List<Instructor> IInstructorManager.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
