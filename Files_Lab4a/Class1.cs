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

            Nodes node = new Nodes();

            OrderByName name = new OrderByName();

            while (newQueue.Count > 0)
            {
                path = newQueue.Dequeue();
                long folderSize = 0;

                try
                {
                    foreach (var directory in Directory.GetFiles(path)) ;
                    {
                        foreach (var directory in Directory.GetDirectories(path))
                        {
                            newQueue.Enqueue(directory);
                        }
                        foreach (var file in Directory.GetFiles(path))
                        {
                            var fileInfo = new FileInfo(file);
                            var fileSize = fileInfo.Length;
                            size.add(fileSize);
                            name.Add(fileInfo);

                            folderSize += fileSize;
                            node.AddFile(fileSize);

                            var ext = fileInfo.Extension;
                            extension.add(ext, fileSize);
                            typ.add(ext, fileSize);
                        }
                        node.AddFolder(folderSize);
                    }
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }

            Console.WriteLine("\nOrder By Name:");
            Console.WriteLine("{0,-30}  {1,-15}{2,-70}", "", "[size]", "[path]");
            foreach (FileInfo item in name.OrderBy(i => i.Name))
            {
                Console.WriteLine("{0,-30}  {1,-15}{2,-70}", item.Name.Substring(0, Math.Min(item.Name.Length, 30)), Property.ToMb(item.Length), item.FullName.Substring(0, Math.Min(item.Name.Length, 70)));
            }

            Console.WriteLine("\nOrdered by sizes (from biggest): ");
            Console.WriteLine("{0,-30}  {1,-15}", "", "[size]");
            foreach (FileInfo item in name.OrderByDescending(i => i.Length))
            {
                Console.WriteLine("{0,-30}  {1,-15}", item.Name.Substring(0, Math.Min(item.Name.Length, 30)), Property.ToMb(item.Length));
            }

            Console.WriteLine("\nCount by the first Letter: ");
            foreach (var item in name.GroupBy(i => i.Name.ToUpper().First()).OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}, {item.Count()}");
            }

            Console.WriteLine("Nodes:");
            Console.WriteLine("{0,15}{1,15}{2,15}", "", "[count]", "[total size]");
            foreach (string item in node)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFILES:");
            Console.WriteLine("\nBy Types:");
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}", "", "[count]", "[total size]", "[avg size]", "[min size]", "[max size]");
            foreach (string item in typ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBy Extensions:");
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}", "", "[count]", "[total size]", "[avg size]", "[min size]", "[max size]");
            foreach (string item in extension)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBy sizes:");
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}", "", "[count]", "[total size]", "[avg size]", "[min size]", "[max size]");
            foreach (string item in size)
            {
                Console.WriteLine(item);
            }
        }
    }
}