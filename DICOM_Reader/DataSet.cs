using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOM_Reader
{
    class DataSet
    {
        private String groupTag;
        private String elementTag;
        private String dataType;
        //int groupTag;
        //int elementTag;
        private byte[] content;

        public DataSet(String gt, String et, String dt, byte[] con)
        {
            this.groupTag = gt;
            this.elementTag = et;
            this.content = con;
            this.dataType = dt;
        }

        public String GroupTag
        {
            get { return groupTag; }
            set { groupTag = value; }
        }

        public String ElementTag
        {
            get { return elementTag; }
            set { elementTag = value; }
        }

        public String DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }

        public byte[] Content
        {
            get { return content; }
            set { content = value; }
        }
    }


}
