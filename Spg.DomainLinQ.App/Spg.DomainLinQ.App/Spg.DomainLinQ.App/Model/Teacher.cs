using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace Spg.DomainLinQ.App.Model
{
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Guid ClassId { get; set; }
        public Gender Gender { get; set; }
        
        private List<Subject> _subjects = new();

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}

