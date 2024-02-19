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
    public class CourseManager : ICourseManager
    {
        private readonly ICourseManager _courseManager;

        public CourseManager(ICourseManager courseManager)
        {
            _courseManager = courseManager;
        }

        public void Add(Course course)
        {
            _courseManager.Add(course);
        }


        public void Delete(int id)
        {
            _courseManager.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _courseManager.GetAll(); 
        }

        public void Update(Course course)
        {
            _courseManager.Update(course);
        }

        List<Course> ICourseManager.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
