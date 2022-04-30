using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Property
    {
        public int count;
        public long totalSize;
        public long avgSize;
        public long minSize;
        public long maxSize;

        public Property()
        {
            this.count = 0;
            this.totalSize = 0;
            this.avgSize = 0;
            this.minSize = 0;
            this.maxSize = 0;
        }

        public void Add(long a)
        {
            count += 1;
            totalSize += a;
            avgSize = totalSize / count;

            if (minSize == 0 || a < minSize)
                minSize = a;

            if (a > maxSize)
                maxSize = a;
        }
    }
}