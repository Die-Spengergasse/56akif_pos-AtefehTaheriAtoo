using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Parsable.Demo
{
    public class Person
    {
        public string FisrtName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; private set; }


        public static Person Parse(String? s, IFormatProvider? provider) { throw new NotImplementedException(); }
        public Person(string fisrtName, string lastName, DateTime birthDate)
        {
            FisrtName = fisrtName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MemberNotNull(false)] out Person)
        { throw new NotImplementedException(); }
    }
}
