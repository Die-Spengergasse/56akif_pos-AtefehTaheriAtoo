using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CollevtionExercise.App
{
    public abstract class Teacher : Person
    {
        public override string GetArriveType()
        {
            return "Resit meist mit dem Auto ";
        }
        private string _fullName;

        public string FullName
        {
            get { return $"Full Name: {FirstName} - {LastName} (Teacher)"; }
         
        }


    }
}
