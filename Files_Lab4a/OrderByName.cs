using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class OrderByName : IEnumerable<FileInfo>
    {
        public List<FileInfo> list = new List<FileInfo>();

        public void Add(FileInfo a)
        {
            list.Add(a);
        }

        public IEnumerator<FileInfo> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}