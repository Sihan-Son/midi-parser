// Author: SIHAN
// Email: sihan830@gmail.com
// GitHub: github.com/sihan830

using System;
using System.Net;
using System.Text;

namespace midi_parser
{
    public static class StaticFunc
    {
        public static string GetString(int magic)
        {
            byte[] data = BitConverter.GetBytes(magic);
            ASCIIEncoding en = new ASCIIEncoding();
            return en.GetString(data);
        }

      
        public static short ShortConvertHostorder(byte[] data, int offset)
        {
            return (short) ConvertHostorder(BitConverter.ToInt16(data, offset));
        }
        
        public static int ConvertHostorder(int data)
        {
            return IPAddress.NetworkToHostOrder(data);
        }

        
        public static int ConvertHostorder(short data)
        {
            return IPAddress.NetworkToHostOrder(data);
        }
        
        
        public static string HexaString(byte[] buffer)
        {
            string str = "";

            foreach (byte d in buffer)
            {
                str += string.Format("{0:X2} ", d);
            }

            return str;
        }

        public static string[] NoteToHexa(string notes)
        {
            string[] Hexa = notes.Split(' '); 

            return Hexa;
        }
        
        
    }
}