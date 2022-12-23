using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Department => Name.Substring(0, 3);
        public Guid Guid;

        // EVERY CLASS SHOULD HAVE ONE TEACHER
        public Teacher Teacher { get; set; }

        // EVERY CLASS SHOULD HAVE A LIST OF STUDENTS
        public virtual IReadOnlyList<Student> Subjects => _students;
        private List<Student> _students = new();
        public void AddStudents(List<Student> students)
        {
            _students.AddRange(students);
        }

      
        public SchoolClass(string name, Teacher teacher, Guid guid)
        {
            Name = Name;
            Teacher = teacher;
            Guid = guid;
        }
    }
}