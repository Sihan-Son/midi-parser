using System;
using System.IO;
using System.Net;
using SF = midi_parser.StaticFunc;

namespace midi_parser
{
    class Chunk
    {
        public int CT // 청크 유형
        {
            get => CT;
            private set => CT = value;
        }

        public int Length //청크 길이
        {
            get => Length;
            private set => Length = value;
        }

        public byte[] Data // 데이터
        {
            get => Data;
            private set => Data = value;
        }

        public string CTString // 청크 유형 문자열
        {
            get => CTString;
            private set => CTString = value;
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

        public Chunk(int ctype, int length, byte[] buffer)
        {
            CT = ctype;
            Length = length;
            Data = buffer;
        }
    }
}