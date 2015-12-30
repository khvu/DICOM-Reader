using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICOM_Reader
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.Run(new SingleFrame_Form());
            Application.Run(new MultiFrames_Form());
        }
    }
}
