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
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course { CourseId=1,CourseName="C# Course"},
                new Course { CourseId=1,CourseName="Javascript Course"}
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }


        public void Delete(int id)
        {
            
            Console.WriteLine("Category Delete");
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses) 
            {
                Console.WriteLine("Course Name: "+(course.CourseName));
            }
            return _courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Category Update");
        }
    }
}
