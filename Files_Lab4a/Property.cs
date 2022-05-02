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

        public Property(int count, long totalsize)
        {
            this.count = count;
            this.totalSize = totalsize;
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

        public static string ToMb(long size)
        {
            if (size > 8000000)
            {
                return $"{((double)size / 8000000).ToString("#.#")}MB";
            }
            if (size > 8000)
            {
                return $"{((double)size / 8000).ToString("#.#")}KB";
            }

            return $"{size}B";
        }
    }
}