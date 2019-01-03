using System;
using System.IO;
using System.Windows.Forms;




namespace midi_parser
{
    class Program
    {
        /*
         *  테스팅 내용
         */
        //        static string fname = "../../midi/example.mid";
        //
        //        static void Main(string[] args)
        //        {
        //            FileStream fs = new FileStream(fname, FileMode.Open);
        //
        //            while (fs.Position < fs.Length)
        //            {
        //                Chunk chunk = Chunk.Parse(fs);
        //
        //                if (chunk != null)
        //                {
        //                    Console.WriteLine("{0} :{1} bytes", chunk.CTString, chunk.Length);
        //                }
        //            }
    
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Midi());
        }
    }
}