using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Size : IEnumerable
    {
        public Dictionary<string, Property> sizes = new Dictionary<string, Property>();

        public Size()
        {
            sizes.Add("<1KB", new Property()); //1000
            sizes.Add("1KB < . <= 1MB", new Property()); //1000000
            sizes.Add("1MB < . <= 1GB", new Property()); //1000000000
            sizes.Add("1GB < ", new Property());
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void add(long a)
        {
            if (a < 1000)
            {
                this.sizes["<1KB"].Add(a);
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
                this.sizes["1GB < "].Add(a);
            }
        }
    }
}