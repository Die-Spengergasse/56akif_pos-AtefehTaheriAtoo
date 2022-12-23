using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CollevtionExercise.App
{
    public abstract class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"fullName: {LastName} {FirstName}";
            }
        }
        public Person() { }

        public Person (int id)
        { Id = id; }

        public virtual string GetAllInfo()
        {
           return $"Id: {Id} | FullName: {FullName} | FirstName: {FirstName}| FirstName: {FirstName}";
        }
        public abstract string GetArriveType();

    }
}

