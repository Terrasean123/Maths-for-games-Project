using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MathsClasses
{
    internal class Colour
    {
        public UInt32 colour;
        public Colour(byte r, byte g, byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;

        }

        public byte red
        {
            get { return (byte)((colour >> 24) & 0xff); }
            set { colour = (colour & 0x00ffffff) | (UInt32)value << 24; }
        }
        public byte green
        {
            get { return (byte)((colour >> 16) & 0xff); }
            set { colour = (colour & 0xff00ffff) | (UInt32)value << 16; }
        }
        public byte blue
        {
            get { return (byte)((colour >> 8) & 0xff); }
            set { colour = (colour & 0xffff00ff) | (UInt32)value << 8; }
        }
        public byte alpha
        {
            get { return (byte)((colour >> 0) & 0xff); }
            set { colour = (colour & 0xffffff00) | (UInt32)value << 0; }
        }

        static public string ConvertToBitString(uint number)
        {
            string bits = string.Empty;

            uint mask = 1;

            for (int bytePos = sizeof(uint) - 1; bytePos >= 0; bytePos--)
            {
                int bPos = bytePos;

                for (int i = 7; i >= 0; i--)
                {
                    if((number & (mask << (8* bPos + i))) == 0) 
                    {
                        bits += '0';
                    
                    }
                    else 
                    {
                        bits += '1';
                    }
                }
                bits += ' ';
            }
            return bits;
        }
    }



}
