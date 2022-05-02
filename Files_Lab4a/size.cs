using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Size : IEnumerable<string>
    {
        public Dictionary<string, Property> sizes = new Dictionary<string, Property>();

        public Size()
        {
            sizes.Add("< 1KB", new Property()); //1000
            sizes.Add("1KB < . <= 1MB", new Property()); //1000000
            sizes.Add("1MB < . <= 1GB", new Property()); //1000000000
            sizes.Add("1GB <", new Property());
        }

        public void add(long a)
        {
            if (a < 1000)
            {
                this.sizes["< 1KB"].Add(a);
            }
            else if (a > 1000 && a <= 1000000)
            {
                this.sizes["1KB < . <= 1MB"].Add(a);
            }
            else if (a > 1000000 && a <= 1000000000)
            {
                this.sizes["1MB < . <= 1GB"].Add(a);
            }
            else if (a > 1000000000)
            {
                this.sizes["1GB <"].Add(a);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in sizes)
            {
                yield return string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}", item.Key, item.Value.count, Property.ToMb(item.Value.totalSize), Property.ToMb(item.Value.avgSize), Property.ToMb(item.Value.maxSize), Property.ToMb(item.Value.minSize));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return sizes.Values.GetEnumerator();
        }
    }
}