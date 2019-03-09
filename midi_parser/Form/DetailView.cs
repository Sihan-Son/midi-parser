using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace midi_parser
{
    public partial class DetailView : Form
    {
        private Midi midi = null;

        public DetailView(Midi midi)
        {
            InitializeComponent();
            this.midi = midi;
        }

        string[] Hexa =
        {
            "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21",
            "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32",
            "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43",
            "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54",
            "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65",
            "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76",
            "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87",
            "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98",
            "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9",
            "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA",
            "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB",
            "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC",
            "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED",
            "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE",
            "FF"
        };

        private void DetailView_Load(object sender, EventArgs e)
        {
            setMidiImg();
            
            string notesBody = "";
            for (var i = 0; i < midi.HexaNotes.Count; i++)
            {
                notesBody += string.Format("{0,3}", midi.HexaNotes[i]);

                if ((i + 1) % 14 == 0)
                {
                    notesBody += "\r\n";
                }
            }

            this.tbDetailBody.AppendText(notesBody);


            chHistogram.Series["Series1"].Points.Clear();
            for (var i = 0; i < midi.histogram.Length; i++)
            {
                if (midi.histogram[i] == 0)
                    continue;
                chHistogram.Series["Series1"].Points.AddXY(Hexa[i], midi.histogram[i]);
            }

            string HistogramDetail = "0 value is skip \r\n";
            for (var i = 0; i < midi.histogram.Length; i++)
            {
                if (midi.histogram[i] == 0)
                    continue;
                HistogramDetail += string.Format("{0}: {1} \r\n", Hexa[i], midi.histogram[i]);
            }

            tbHistoDetail.AppendText(HistogramDetail);
        }

        private void setMidiImg()
        {
            int w = 14;
            int h = Convert.ToInt32(Math.Ceiling(midi.HexaNotes.Count / 14.0));
            Image<Gray, Byte> img = new Image<Gray, byte>(w, h);

            int[] midiToImg = StaticFunc.midiToImage(midi.HexaNotes);
            
            
            int y = 0;
            for (var x = 0; x < midi.HexaNotes.Count; x++)
            {
                
                if ((x + 1) % 14 == 0)
                {
                    y += 1;
                }

                img.Data[y, x % 14, 0] = Convert.ToByte(midiToImg[x]);
            }

            pbImg.Image = img.ToBitmap();

//            CvInvoke.Imshow("test", img);
//            CvInvoke.WaitKey(0);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "다른 이름으로 저장";
            dlg.DefaultExt = "jpg";
            dlg.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif";
            dlg.FilterIndex = 0;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImg.Image.Save(dlg.FileName);
            }

            
        }
    }
}