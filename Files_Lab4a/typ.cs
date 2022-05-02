using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    public class Typ : IEnumerable<string>
    {
        public Dictionary<string, Property> typ = new Dictionary<string, Property>();

        public Typ()
        {
            typ.Add("image", new Property());
            typ.Add("audio", new Property());
            typ.Add("video", new Property());
            typ.Add("document", new Property());
            typ.Add("[other]", new Property());
        }

        public void add(string ext, long leng)
        {
            if (ext == ".jpg" || ext == ".img")
            {
                this.typ["image"].Add(leng);
            }
            else if (ext == ".mp3")
            {
                this.typ["audio"].Add(leng);
            }
            else if (ext == ".doc" || ext == ".xls" || ext == ".docx")
            {
                this.typ["document"].Add(leng);
            }
            else if (ext == ".mp4")
            {
                this.typ["video"].Add(leng);
            }
            else
            {
                this.typ["[other]"].Add(leng);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in typ)
            {
                yield return string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}", item.Key, item.Value.count, Property.ToMb(item.Value.totalSize), Property.ToMb(item.Value.avgSize), Property.ToMb(item.Value.maxSize), Property.ToMb(item.Value.minSize));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return typ.Values.GetEnumerator();
        }
    }
}