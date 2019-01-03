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

namespace midi_parser
{
    public partial class Midi : Form
    {
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
            
            File.Text = filePath.Text.Split('\\').Last();

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
                }
            }
            Console.Write(text);
            midiText.AppendText(text);
        }
    }
}
