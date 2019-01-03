using System;
using System.IO;
using System.Net;
using SF = midi_parser.StaticFunc;

namespace midi_parser
{
    class Chunk
    {
        public Chunk(int ctype, int length, byte[] buffer)
        {
            CT = ctype;
            Length = length;
            Data = buffer;
        }


        public int CT //청크 유형
        {
            get;
            private set;
        }

        public int Length //청크 길이
        {
            get;
            private set;
        }

        public byte[] Data //데이터
        {
            get;
            private set;
        }

        public string CTString //청크 유형(문자열)
        {
            get { return SF.GetString(CT); }
        }


        public static Chunk Parse(Stream stream)
        {
            try
            {
                BinaryReader br = new BinaryReader(stream);
                int ctype = br.ReadInt32();
                int length = br.ReadInt32();

                length = SF.ConvertHostorder(length);
                byte[] buffer = br.ReadBytes(length);

                return new Chunk(ctype, length, buffer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}