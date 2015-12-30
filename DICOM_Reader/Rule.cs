using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOM_Reader
{
    /// <summary>
    /// A Dicom Rule
    /// </summary>
    internal class Rule
    {
        public Rule(string groupTag, string elementTag, string name, string keyword, string vr)
        {
            this.groupTag = groupTag;
            this.elementTag = elementTag;
            this.name = name;
            this.keyword = keyword;
            this.vr = vr;
        }

        private string groupTag;
        private string elementTag;
        private string name;
        private string keyword;
        private string vr;

        public string Vr
        {
            get { return vr; }
            set { vr = value; }
        }

        public string GroupTag
        {
            get { return groupTag; }
            set { groupTag = value; }
        }

        public string ElementTag
        {
            get { return elementTag; }
            set { elementTag = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }


    }
}

