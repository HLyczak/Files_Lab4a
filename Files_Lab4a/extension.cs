using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Extension : IEnumerable
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void add(string ext, long leng)
        {
            if (ext == "jpg")
            {
                this.extensions["jpg"].Add(leng);
            }
            else if (ext == "png")
            {
                this.extensions["png"].Add(leng);
            }
            else if (ext == "gif")
            {
                this.extensions["gif"].Add(leng);
            }
            else if (ext == "doc")
            {
                this.extensions["doc"].Add(leng);
            }
            else if (ext == "mp3")
            {
                this.extensions["mp3"].Add(leng);
            }
            else
            {
                this.extensions["[other]"].Add(leng);
            }
        }
    }
}