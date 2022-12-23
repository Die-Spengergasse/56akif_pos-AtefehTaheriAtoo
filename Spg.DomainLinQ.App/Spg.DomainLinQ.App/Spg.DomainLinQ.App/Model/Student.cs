using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        public string RegistrationNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public PhoneNumber PhoneNumber { get; set; } = default!;
        public string AccountNumber => $"{LastName.Substring(0, 5)}{RegistrationNumber}";
        public Genders Gender { get; set; }
        public Guid Guid { get; set; }

      
        public virtual IReadOnlyList<Subject> Subjects => _subjects;
        private List<Subject> _subjects = new();
        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }

        
        public Student(string registrationNumber, string firstName, string lastName,
            string email, Address address, PhoneNumber phoneNumber, Genders gender, Guid guid)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Guid = guid;
        }
    }
}