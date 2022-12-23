using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        public int Lesson { get; set; }
        public DateTime? Date { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }

        // Grade
        private int grade;
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value >= 1 && value <= 5
                    ? value
                    : throw new ArgumentOutOfRangeException("Grade muss zwischen 1 und 5 liegen!");
            }
        }

    
        public Exam(int lession, DateTime date, DateTime created, Guid guid, int grade)
        {
            Lesson = lession;
            Date = Date;
            Created = created;
            Guid = guid;
            Grade = grade;
        }
    }
}