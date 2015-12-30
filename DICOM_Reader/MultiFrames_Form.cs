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
    public unsafe partial class MultiFrames_Form : Form
    {
        List<DataSet> dataSet_MultiFrames = new List<DataSet>();
        List<Rule> rules = new List<Rule>();

        int width = 0, height = 0;
        int[] original_colors_MultiFrames;

        List<string> specialCase = new List<string> { "OB", "OW", "OF", "UN", "UT" };

        public MultiFrames_Form()
        {
            InitializeComponent();
        }

        private void MultiFrames_Form_Load(object sender, EventArgs e)
        {
            DataTable dataTable_MultiFrames = new DataTable("DICOM_MultiFrames");

            dataTable_MultiFrames.Columns.Add(new DataColumn("Tag"));
            dataTable_MultiFrames.Columns.Add(new DataColumn("Description"));
            dataTable_MultiFrames.Columns.Add(new DataColumn("Value"));

            ruleGenerator();

            dataSetGenerator();

            for (int i = 0; i < dataSet_MultiFrames.Count - 1; i++)
            {
                var record = dataSet_MultiFrames[i];
                dataTable_MultiFrames.Rows.Add("(" + record.GroupTag + "," + record.ElementTag + ")", getDescription(record.GroupTag, record.ElementTag), interpreter(record.DataType, record.Content).ToString());
            }

            dataGridView_MultiFrames.DataSource = dataTable_MultiFrames;

            trackBar_MultiFrames_Center.Minimum = 5;
            trackBar_MultiFrames_Width.Minimum = 10;

            trackBar_MultiFrames_FrameToDisplay.Minimum = 0;
            trackBar_MultiFrames_FrameToDisplay.Value = 0;

            pixelDataProcessor();

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

        private void dataSetGenerator()
        {
            BinaryReader inFile = new BinaryReader(File.Open("BR3DFSE.dcm", FileMode.Open));

            //Ignore the first 132 bytes (File Preamble & "DICM")
            inFile.BaseStream.Position = 132;

            readHeader(inFile);
        }

        bool cont = true;
        private void readHeader(BinaryReader bR)
        {
            while (cont == true)
            {
                if (bR.BaseStream.Position == bR.BaseStream.Length)
                {
                    cont = false;
                    break;
                }

                string groupTag = "", elementTag = "";
                UInt16 ValueLength_16 = 0;
                UInt32 ValueLength_32 = 0;
                string dataType = "";

                try
                {
                    groupTag = bR.ReadUInt16().ToString("X4");
                    elementTag = bR.ReadUInt16().ToString("X4");

                    if (groupTag.Equals("FFFE") && (elementTag.Equals("E00D") || elementTag.Equals("E0DD") || elementTag.Equals("E000")))
                    {
                        bR.ReadBytes(4);
                    }
                    else
                    {
                        dataType = System.Text.Encoding.UTF8.GetString(bR.ReadBytes(2));
                    }

                    if (dataType.Equals(""))
                    {
                        continue;
                    }
                    else if (specialCase.Contains(dataType))
                    {
                        bR.ReadBytes(2);
                        ValueLength_32 = bR.ReadUInt32();
                        dataSet_MultiFrames.Add(new DataSet(groupTag, elementTag, dataType, bR.ReadBytes(Convert.ToInt32(ValueLength_32))));
                    }
                    else if (dataType.Equals("SQ"))
                    {
                        bR.ReadBytes(2);
                        ValueLength_32 = bR.ReadUInt32();

                        if (ValueLength_32.ToString("X4").Equals("FFFFFFFF"))
                        {
                            string itemTag = bR.ReadUInt16().ToString("X4") + "," + bR.ReadUInt16().ToString("X4");
                            UInt32 itemLength = bR.ReadUInt32();

                            if (itemLength.ToString("X4").Equals("FFFFFFFF"))
                            {
                                if (!(groupTag.Equals("FFFE") && elementTag.Equals("E00D")))
                                {
                                    dataSet_MultiFrames.Add(new DataSet(groupTag, elementTag, dataType, null));
                                    continue;
                                }
                            }

                            if (!(groupTag.Equals("FFFE") && elementTag.Equals("E0DD")))
                            {
                                continue;
                            }
                        }
                        else
                        {
                            dataSet_MultiFrames.Add(new DataSet(groupTag, elementTag, dataType, bR.ReadBytes(Convert.ToInt32(ValueLength_32))));
                        }
                    }
                    else
                    {
                        ValueLength_16 = bR.ReadUInt16();
                        dataSet_MultiFrames.Add(new DataSet(groupTag, elementTag, dataType, bR.ReadBytes(Convert.ToInt16(ValueLength_16))));
                        continue;
                    }

                }
                catch (EndOfStreamException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
        }

        private void pixelDataProcessor()
        {
            int numberOfFramesIndex = dataSet_MultiFrames.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0008"));
            int numberOfFrames = Convert.ToInt32(interpreter(dataSet_MultiFrames[numberOfFramesIndex].DataType, dataSet_MultiFrames[numberOfFramesIndex].Content));

            int index_height = dataSet_MultiFrames.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0010"));
            int index_width = dataSet_MultiFrames.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0011"));

            width = Convert.ToInt32(interpreter(dataSet_MultiFrames[index_width].DataType, dataSet_MultiFrames[index_width].Content));
            height = Convert.ToInt32(interpreter(dataSet_MultiFrames[index_height].DataType, dataSet_MultiFrames[index_height].Content));

            int index_bitStored = dataSet_MultiFrames.FindIndex(d => (d.GroupTag == "0028" && d.ElementTag == "0101"));
            int bitStored = Convert.ToInt32(interpreter(dataSet_MultiFrames[index_bitStored].DataType, dataSet_MultiFrames[index_bitStored].Content));

            //Processing pixel data
            byte[] pixelData = dataSet_MultiFrames[dataSet_MultiFrames.Count - 1].Content;

            int maxColorValue = 1;

            for (int i = 0; i < bitStored; i++)
            {
                maxColorValue *= 2;
            }

            original_colors_MultiFrames = new int[width * height * numberOfFrames];

            for (int i = 0; i < original_colors_MultiFrames.Length; i++)
            {

                original_colors_MultiFrames[i] = (Int32)(pixelData[i * 2] << 8 | pixelData[(i * 2) + 1]);
            }

            setPixelValue();

            trackBar_MultiFrames_Width.Maximum = maxColorValue;
            trackBar_MultiFrames_Width.Value = maxColorValue;

            trackBar_MultiFrames_Center.Maximum = maxColorValue;
            trackBar_MultiFrames_Center.Value = maxColorValue / 2;

            trackBar_MultiFrames_FrameToDisplay.Maximum = numberOfFrames - 1;
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
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);

            int currentIndex = trackBar_MultiFrames_FrameToDisplay.Value;
            int functionCenter = trackBar_MultiFrames_Center.Value;
            int functionWidth = trackBar_MultiFrames_Width.Value;

            Rectangle rec = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            UInt32* ptr = (UInt32*)bmpData.Scan0;

            double m = (double)255 / (double)functionWidth;

            double n = m * (-1.00) * ((double)functionCenter - (double)functionWidth / 2.00);

            for (int i = 0; i < height * width; i++)
            {
                UInt32 col = calculateColor(original_colors_MultiFrames[i + currentIndex * height * width], m, n);
                UInt32 pixel = 0xff000000 | col << 16 | col << 8 | col;

                *(ptr + i) = pixel;
            }

            bitmap.UnlockBits(bmpData);
            pictureBox_MultiFrames.Image = bitmap;
        }

        private void trackBar_MultiFrames_FrameToDisplay_ValueChanged(object sender, System.EventArgs e)
        {
            setPixelValue();
        }

        private void trackBar_MultiFrames_Center_ValueChanged(object sender, System.EventArgs e)
        {
            setPixelValue();
        }

        private void trackBar_MultiFrames_Width_ValueChanged(object sender, System.EventArgs e)
        {
            setPixelValue();
        }
    }
}
