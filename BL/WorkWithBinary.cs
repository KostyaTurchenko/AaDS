using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class WorkWithBinary
    {
        public static List<int> ReadOfDouble(string path)
        {
            List<int> array = new List<int>();

            if (File.Exists(path))
            {
                FileStream streamer = new FileStream(path, FileMode.Open);

                using (BinaryReader reader = new BinaryReader(streamer))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        array.Add(reader.ReadInt32());
                    }
                }

            }
            return array;
        }

        public static void WriteOfDouble(IList<int> arr, string path)
        {
            FileStream sr = new FileStream(path, FileMode.OpenOrCreate);

            using (BinaryWriter writer = new BinaryWriter(sr))
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    writer.Write(arr[i]);
                }
            }
        }
    }
}
