using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Files_Lab4a
{
    public class size : IEnumerable
    {
        public Dictionary<string, List<long>> sizes = new Dictionary<string, List<long>>();

        public void Size()
        {
            sizes.Add("<1KB", new List<long>());
            sizes.Add("1KB < . <= 1MB", new List<long>());
            sizes.Add("1MB < . <= 1GB", new List<long>());
            sizes.Add("1GB < ", new List<long>());
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static void add(long a)
        {
        }
    }
}