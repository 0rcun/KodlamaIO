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
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor {InstructorId=1,FirstName="Engin",LastName="Demiroğ"},
                new Instructor {InstructorId=2,FirstName="Halit Enes",LastName="Kalaycı"}
            };
        } 
        public void Add(Instructor ınstructor)
        {
            _instructors.Add(ınstructor);
        }

        public void Delete(int id)
        {
            Console.WriteLine("Category Delete");
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine("Instructor Name: "+(instructor.FirstName+" "+instructor.LastName));
            }
            return _instructors;
        }

        public void Update(Instructor ınstructor)
        {
            Console.WriteLine("Category Update");
        }

     
    }
}
