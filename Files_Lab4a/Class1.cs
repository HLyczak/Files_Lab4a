using System;
using System.Collections;
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
            Size size = new Size();
            Extension extension = new Extension();
            Typ typ = new Typ();

            Queue<string> newQueue = new Queue<string>();
            newQueue.Enqueue(path);

            while (newQueue.Count > 0)
            {
                path = newQueue.Dequeue();//nadpisanie argumentu
                try
                {
                    foreach (var directory in Directory.GetDirectories(path))
                    {
                        newQueue.Enqueue(directory);
                        Console.WriteLine(directory);
                    }
                    foreach (var file in Directory.GetFiles(path))
                    {
                        var fileInfo = new FileInfo(file);
                        var a = fileInfo.Length;
                        size.add(a);
                        var ext = fileInfo.Extension;
                        extension.add(ext, a);
                        typ.add(ext, a);
                    }
                }
                catch (System.Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }
        }
    }
}