﻿namespace FEFTwiddler.Extensions
{
    public static class ByteExtensions
    {
        public static bool GetFlag(this byte thisByte, byte mask)
        {
            return (thisByte & mask) == mask;
        }

        public static byte SetFlag(this byte thisByte, byte mask, bool value)
        {
            if (value) return thisByte.FlagOn(mask);
            else return thisByte.FlagOff(mask);
        }

        public static byte FlagOn(this byte thisByte, byte mask)
        {
            return (byte)(thisByte | mask);
        }

        public static byte FlagOff(this byte thisByte, byte mask)
        {
            return (byte)(thisByte & ~mask);
        }
    }
}
