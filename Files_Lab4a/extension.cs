using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Extension : IEnumerable<string>
    {
        public Dictionary<string, Property> extensions = new Dictionary<string, Property>();

        public Extension()
        {
            extensions.Add("jpg", new Property());
            extensions.Add("png", new Property());
            extensions.Add("gif", new Property());
            extensions.Add("doc", new Property());
            extensions.Add("txt", new Property());
            extensions.Add("mp3", new Property());
            extensions.Add("[other]", new Property());
        }

        public void add(string ext, long leng)
        {
            if (ext == ".jpg")
            {
                this.extensions["jpg"].Add(leng);
            }
            else if (ext == ".png")
            {
                this.extensions["png"].Add(leng);
            }
            else if (ext == ".gif")
            {
                this.extensions["gif"].Add(leng);
            }
            else if (ext == ".doc" || ext == ".xls" || ext == ".docx")
            {
                this.extensions["doc"].Add(leng);
            }
            else if (ext == ".txt")
            {
                this.extensions["txt"].Add(leng);
            }
            else if (ext == ".mp3")
            {
                this.extensions["mp3"].Add(leng);
            }
            else
            {
                this.extensions["[other]"].Add(leng);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in extensions)
            {
                yield return string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}", item.Key, item.Value.count, Property.ToMb(item.Value.totalSize), Property.ToMb(item.Value.avgSize), Property.ToMb(item.Value.maxSize), Property.ToMb(item.Value.minSize));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return extensions.Values.GetEnumerator();
        }
    }
}