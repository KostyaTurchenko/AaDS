using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Students_1._3._13_
{
    public class SortOfStudents
    {
        public Student[] Students { get; set; }

        public SortOfStudents(Student[] students)
        {
            Students = students;
        }

        public IList<Student> StudetsWithMaxMark()
        {
            List<Student> students = new List<Student>();

            var q = Students.GroupBy(s => s.Course).GroupBy(f => f.Where(d => d.AverageRating == f.Max(l => l.AverageRating)));

            foreach (var i in q)
            {
                students.Add(i.Key.Last());
            }

            return students;
        }
    }
}
