// Author: SIHAN
// Email: sihan830@gmail.com
// GitHub: github.com/sihan830

namespace midi_parser
{
    public class Header:Chunk
    {
        public int Format
        {
            get { return StaticFunc.ConvertHostorderS(Data, 0); }
        }

        public int TrackCount
        {
            get { return StaticFunc.ConvertHostorderS(Data, 2); }
        }

        public int Division
        {
            get { return StaticFunc.ConvertHostorderS(Data, 4); }
        }
        
        public Header(int ctype, int length, byte[] buffer) : base(ctype, length, buffer)
        {
        }
    }
}