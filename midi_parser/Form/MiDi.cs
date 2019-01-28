using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace midi_parser
{
    public partial class Midi : Form
    {
        WindowsMediaPlayer midiPlayer = new WindowsMediaPlayer();

        public Midi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void fnBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Midi Files(*.mid) | *.mid";
            opd.Title = "Select MIDI FILE";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath.Text = opd.FileName;
            }
            
            fileName.Text = filePath.Text.Split('\\').Last().Split('.').First();

        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(this.filePath.Text, FileMode.Open);

            var text = "";
            while (fs.Position < fs.Length)
            {
                Chunk chunk = Chunk.Parse(fs);
            
                if (chunk != null)
                {
                    text += string.Format("{0} :{1} bytes \r\n", chunk.CTString, chunk.Length);

                    if (chunk is Header)
                    {
                        var headerContents = ViewHeader(chunk as Header);
                        text += headerContents;
                    }
                }
            }
            Console.Write(text);
            midiText.AppendText(text);
        }


        private static string ViewHeader(Header header)
        {
            string[] content = new string[5]; 
            content[0] = "\r\n===Header Chunk===\r\n";
            content[1] = string.Format(StaticFunc.HexaString(header.Buffer) + "\r\n");
            content[2] = string.Format("Format: {0}\r\n", header.Format);
            content[3] = string.Format("Tracks: {0}\r\n", header.TrackCount);
            content[4] = string.Format("Division: {0}\r\n", header.Division);

            var contents = "";
            
            for (var i = 0; i < 5; i++)
            {
                contents += content[i];
            }
            
            return contents+"\r\n";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            midiPlayer.URL = filePath.Text;
            try
            {
                midiPlayer.controls.play();
            }
            catch (Exception)
            {
                midiText.AppendText("error");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            midiPlayer.controls.stop();
        }
    }
}
