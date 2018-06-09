using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class WorkWithOueue
    {
        public string[] students;
        public WorkWithOueue (string[] str)
        {
            students = str;
        }
        public string[] ReadStudentsFromFile(string path)
        {
            string[] str = File.ReadAllLines(path);
            return str;
        }

        public Queue<string> FormQueue()
        {

            var queue = new Queue<string>();
            foreach (string line in students)
            {
                queue.InQueue(line);
            }

            return queue;
        }

        public Queue<string> AddNewStudent (Queue<string> queue, string name)
        {
            queue.InQueue(name);
            return queue;
        }

        public void SaveFile (string[] str, string path)
        {
            File.WriteAllLines(path, str);
        }
    }
}
