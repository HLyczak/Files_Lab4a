using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Nodes : IEnumerable<string>
    {
        public Dictionary<string, Property> node = new Dictionary<string, Property>();

        public Nodes()
        {
            node.Add("Directories", new Property(0, 0));
            node.Add("Files", new Property(0, 0));
        }

        public void AddFolder(long folderSize)
        {
            this.node["Directories"].Add(folderSize);
        }

        public void AddFile(long fileSize)
        {
            this.node["Files"].Add(fileSize);
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in node)
            {
                yield return string.Format("{0,15}{1,15}{2,15}", item.Key, item.Value.count, Property.ToMb(item.Value.totalSize));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return node.Values.GetEnumerator();
        }
    }
}