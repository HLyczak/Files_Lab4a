using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Class1
    {
        public static void Search(string path)
        {
            try
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    //Console.WriteLine(directory);
                    Search(directory);
                }
                foreach (var file in Directory.GetFiles(path))
                {
                    var fileInfo = new FileInfo(file);
                    var a = fileInfo.Length;
                    Console.WriteLine(a);
                }
            }
            catch (System.Exception except)
            {
                Console.WriteLine(except.Message);
            }
        }
    }
}