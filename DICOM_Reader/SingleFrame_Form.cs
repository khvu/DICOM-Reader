using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DICOM_Reader
{
    public unsafe partial class SingleFrame_Form : Form
    {
        List<DataSet> dataSet_SingleFrame = new List<DataSet>();
        List<Rule> rules = new List<Rule>();

        int width = 0, height = 0;
        int[] original_colors;

        public SingleFrame_Form()
        {
            InitializeComponent();
        }

        private void SingleFrame_Form_Load(object sender, EventArgs e)
        {
            DataTable dataTable_SingleFrame = new DataTable("DataTable_SingleFrame");

            dataTable_SingleFrame.Columns.Add(new DataColumn("Tag"));
            dataTable_SingleFrame.Columns.Add(new DataColumn("Description"));
            dataTable_SingleFrame.Columns.Add(new DataColumn("Value"));

            ruleGenerator();

            dataSetGenerator();

            for (int i = 0; i < dataSet_SingleFrame.Count - 1; i++)
            {
                var record = dataSet_SingleFrame[i];
                dataTable_SingleFrame.Rows.Add("(" + record.GroupTag + "," + record.ElementTag + ")", getDescription(record.GroupTag, record.ElementTag), interpreter(record.DataType, record.Content).ToString());
            }

            pixelDataProcessor();

            dataGridView_SingleFrame.DataSource = dataTable_SingleFrame;

            trackBar_SingleFrame_Center.Minimum = 5;
            trackBar_SingleFrame_Width.Minimum = 10;
            
            this.MinimumSize = new Size(width * 2, height + (int)height / 2);
        }

        //How to interpret VRs as corresponding data types in C#
        public static object interpreter(string type, byte[] byteArray)
        {
            if (byteArray != null)
                switch (type)
                {
                    //String
                    case "AE":
                    case "AS":
                    case "CS":
                    case "DA":
                    case "DS":
                    case "DT":
                    case "IS":
                    case "LO":
                    case "LT":
                    case "PN":
                    case "SH":
                    case "ST":
                    case "TM":
                    case "UI":
                    case "UN":
                    case "UT":
                    case "OF":
                    case "OW":
                    case "OB":
                    default:
                        return System.Text.Encoding.UTF8.GetString(byteArray);
                    //Long Integer
                    case "AT":
                    case "SL":
                        return BitConverter.ToInt32(byteArray, 0);
                    //Float
                    case "FL":
                        return BitConverter.ToSingle(byteArray, 0);
                    //Double
                    case "FD":
                        return BitConverter.ToDouble(byteArray, 0);
                    case "SS":
                        return BitConverter.ToInt16(byteArray, 0);
                    //Unsigned Long Integer
                    case "UL":
                        return BitConverter.ToUInt32(byteArray, 0);
                    //Unsigned Short Integer
                    case "US":
                        return BitConverter.ToUInt16(byteArray, 0);
                }
            else
                return "";
        }

        //Read from DICOM file and save all header information in a DataSet
        private void dataSetGenerator()
        {
            BinaryReader inFile = new BinaryReader(File.Open("CR-MONO1-10-chest.dcm", FileMode.Open));

            try
            {
                while (inFile.BaseStream.Position != inFile.BaseStream.Length)
                {
                    string groupTag = inFile.ReadUInt16().ToString("X4");
                    string elementTag = inFile.ReadUInt16().ToString("X4");
                    UInt32 length = inFile.ReadUInt32();
                    byte[] content = inFile.ReadBytes(Convert.ToInt32(length));
                    string VR = getVR(groupTag, elementTag);

                    if (!VR.Equals(""))
                    {
                        dataSet_SingleFrame.Add(new DataSet(groupTag, elementTag, getVR(groupTag, elementTag), content));
                    }

                }
            }
            catch
            {
                MessageBox.Show("Failure! File cannot be read!");
            }
        }

        //Read the rules from file and save them in a list
        private void ruleGenerator()
        {
            string line;

            StreamReader file = new StreamReader("DICOM Tags.csv");
            file.ReadLine();//ignore the first line
            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Replace("\"", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Split('|');

                string group = words[0].Split(',')[0];
                string element = words[0].Split(',')[1];
                string name = words[1];
                string keyword = words[2];
                string vr = words[3];

                rules.Add(new Rule(group, element, name, keyword, vr));
            }
        }

        private String getDescription(String gt, String et)
        {
            int m = rules.FindIndex(r => (r.GroupTag == gt && (r.ElementTag == et)));
            if (m != -1)
                return rules[m].Name;
            else
                return "";
        }

        private String getVR(String gt, String et)
        {
            int m = rules.FindIndex(r => (r.GroupTag == gt && (r.ElementTag == et)));
            if (m != -1)
                return rules[m].Vr;
            else
                return "";
        }

        //Process pixel data to display on GUI
        private void pixelDataProcessor()
        {
            int index_height = dataSet_SingleFrame.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0010"));
            int index_width = dataSet_SingleFrame.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0011"));

            width = Convert.ToInt32(interpreter(dataSet_SingleFrame[index_width].DataType, dataSet_SingleFrame[index_width].Content));
            height = Convert.ToInt32(interpreter(dataSet_SingleFrame[index_height].DataType, dataSet_SingleFrame[index_height].Content));

            int index_bitStored = dataSet_SingleFrame.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0101"));
            int bitStored = Convert.ToInt32(interpreter(dataSet_SingleFrame[index_bitStored].DataType, dataSet_SingleFrame[index_bitStored].Content));

            //Processing pixel data
            byte[] pixelData = dataSet_SingleFrame[dataSet_SingleFrame.Count - 1].Content;

            int maxColorValue = 1;

            for (int i = 0; i < bitStored; i++)
            {
                maxColorValue *= 2;
            }
            
            original_colors = new int[width * height];

            for (int i = 0; i < original_colors.Length; i++)
            {
                original_colors[i] = maxColorValue - (int)(pixelData[i * 2 + 1] << 8 | pixelData[i * 2]);
            }

            setPixelValue();

            trackBar_SingleFrame_Width.Maximum = maxColorValue;
            trackBar_SingleFrame_Width.Value = maxColorValue;

            trackBar_SingleFrame_Center.Maximum = maxColorValue;
            trackBar_SingleFrame_Center.Value = maxColorValue / 2;
        }

        private UInt32 calculateColor(int col, double m, double n)
        {
            double newcol = ((double)col * m + n);

            if (newcol > 255)
                newcol = 255;
            else if (newcol < 0)
                newcol = 0;

            return (UInt32)newcol;

        }

        private void setPixelValue()
        {
            int functionCenter = trackBar_SingleFrame_Center.Value;
            int functionWidth = trackBar_SingleFrame_Width.Value;

            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);

            Rectangle rec = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            UInt32* ptr = (UInt32*)bmpData.Scan0;

            double m = (double)255 / (double)functionWidth;

            double n = m * (-1.00) * ((double)functionCenter - (double)functionWidth / 2.00);

            for (int i = 0; i < original_colors.Length; i++)
            {
                UInt32 col = calculateColor(original_colors[i], m, n);
                UInt32 pixel = 0xff000000 | col << 16 | col << 8 | col;

                *(ptr + i) = pixel;
            }

            bitmap.UnlockBits(bmpData);
            pictureBox_SingleFrame.Image = bitmap;
        }

        private void trackBar_SingleFrame_Center_ValueChanged(object sender, System.EventArgs e)
        {   
            setPixelValue();
        }

        private void trackBar_SingleFrame_Width_ValueChanged(object sender, System.EventArgs e)
        {
            setPixelValue();
        }
    }
}
