using System;
using System.IO;


namespace midi_parser
{
    class Program
    {
        static string fname = "../../midi/example.mid";

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(fname, FileMode.Open);

            while (fs.Position < fs.Length)
            {
                Chunk chunk = Chunk.Parse(fs);

                if (chunk != null)
                {
                    Console.WriteLine("{0} :{1} bytes", chunk.CTString, chunk.Length);
                }
            }
        }
    }
}