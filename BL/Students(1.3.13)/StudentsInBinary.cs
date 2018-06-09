using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BL.Students_1._3._13_
{
    public class StudentsInBinary
    {
        string Path { get; set; }

        public StudentsInBinary(string path)
        {
            Path = path;
        }

        public void Write(Student[] students)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }

        public Student[] Read()
        {
            Student[] students;
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                students = (Student[])formatter.Deserialize(fs);
            }

            return students;
        }

        public static void WriteOfStudents(Student[] students, string path)
        {
            FileStream sr = new FileStream(path, FileMode.OpenOrCreate);

            using (BinaryWriter writer = new BinaryWriter(sr))
            {
                for (int i = 0; i < students.Length; i++)
                {
                    writer.Write(students[i].FIO);
                    writer.Write(students[i].Year.ToBinary());
                    writer.Write(students[i].MedB.Length);

                    double[] medB = students[i].MedB;
                    for (int j = 0; j < medB.Length; j++)
                    {
                        writer.Write(medB[j]);
                    }

                    writer.Write(students[i].Course);
                    writer.Write(students[i].Group);
                }
            }
        }

                public static List<Student> ReadOfStudents(string path)
        {
            List<Student> students = new List<Student>();

            if (File.Exists(path))
            {
                FileStream streamer = new FileStream(path, FileMode.Open);

                using (BinaryReader reader = new BinaryReader(streamer))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string fio = reader.ReadString();
                        DateTime year = new DateTime(reader.ReadInt64());
                        int amount = reader.ReadInt32();

                        double[] medB = new double[amount];
                        for (int j = 0; j < amount; j++)
                        {
                            medB[j] = reader.ReadDouble();
                        }

                        byte course = reader.ReadByte();
                        byte group = reader.ReadByte();

                        students.Add(new Student(fio, year, medB, course, group));
                    }
                }
            }

            return students;
        }
    }
}
