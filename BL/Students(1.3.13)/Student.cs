using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Students_1._3._13_
{
    [Serializable]
    public class Student
    {
        public string FIO { get; set; }
        public DateTime Year { get; set; }
        public double[] MedB { get; set; }
        public byte Course { get; set; }
        public byte Group { get; set; }
        public double AverageRating
        {
            get
            {
                return SetAverageRating();
            }
            private set { }
        }

        public Student(string FIO, DateTime Year, double[] MedB, byte Course, byte Group)
        {
            this.FIO = FIO;
            this.Year = Year;
            this.MedB = MedB;
            this.Course = Course;
            this.Group = Group;
            SetAverageRating();
        }

        double SetAverageRating()
        {
            int amount = MedB.Length;
            double value = 0;

            for (int i = 0; i < amount; i++)
            {
                value += MedB[i];
            }

            return Math.Round(value / amount, 2);
        }
    }
}
