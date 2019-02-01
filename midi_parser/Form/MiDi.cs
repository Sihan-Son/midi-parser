// Author: SIHAN
// Email: sihan830@gmail.com
// GitHub: github.com/sihan830

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
        Timer timer = new Timer();

        public Midi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
        }

        private void fnBtn_Click(object sender, EventArgs e)
        {
            // 미디 파일을 열기 위한 이벤트 
            // event for open .mid file

            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Midi Files(*.mid) | *.mid"; // get only .mid format
            opd.Title = "Select MIDI FILE"; // file dialog title

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath.Text = opd.FileName; // set file path 
                midiPlayer.URL = filePath.Text; // set wmp's file path
                midiPlayer.close();
            }

            fileName.Text =
                filePath.Text.Split('\\').Last().Split('.').First(); // get only file name without path or format
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(this.filePath.Text, FileMode.Open); // get filestream for parse midi to hexa

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

            fs.Close(); // close stream
        }


        private static string ViewHeader(Header header)
        {
            string contents = "\r\n===Header Chunk===\r\n";
            contents += string.Format(StaticFunc.HexaString(header.Buffer) + "\r\n");
            contents += string.Format("Format: {0}\r\n", header.Format);
            contents += string.Format("Tracks: {0}\r\n", header.TrackCount);
            contents += string.Format("Division: {0}\r\n", header.Division);

            return contents + "\r\n";
        }


        private double currentTime; // current play time
        private int playFlag = 0;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            playFlag = 1;
            midiPlayer.controls.currentPosition = currentTime;
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
            playFlag = 0;
            midiPlayer.controls.stop();
            currentTime = 0;
            midiPlayer.close(); // 파일 점유 해제
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            playFlag = 0;
            currentTime = midiPlayer.controls.currentPosition;
            midiPlayer.controls.pause();
            midiPlayer.close(); // 파일 점유 해제
        }
        
    }
}