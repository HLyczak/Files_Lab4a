using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Lab4a
{
    internal class Typ : IEnumerable
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
            if (ext == "jpg" || ext == "img")
            {
                this.typ["image"].Add(leng);
            }
            else if (ext == "mp3")
            {
                this.typ["audio"].Add(leng);
            }
            else if (ext == "doc" || ext == "xls")
            {
                this.typ["document"].Add(leng);
            }
            else if (ext == "mp4")
            {
                this.typ["video"].Add(leng);
            }
            else
            {
                this.typ["[other]"].Add(leng);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}