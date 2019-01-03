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

        public static int ConvertHostorder(int data)
        {
            return IPAddress.NetworkToHostOrder(data);
        }
    }
}