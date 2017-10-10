using System;

/// <summary>
/// https://github.com/Two9A/jsGB/blob/master/js/z80.js
/// </summary>
namespace CPU
{
    public static class Registers
    {
      
        [Flags]
        public enum flags
        {                                  
            carry = 0x10,
            halfcarry = 0x20,
            operation = 0x40,
            zero = 0x80,
        }
        /// <summary>
        /// Standard Regesters
        /// </summary>
        public static byte a { get; set; }
        public static byte b { get; set; }
        public static byte c { get; set; }
        public static byte d { get; set; }
        public static byte e { get; set; }
        public static byte h { get; set; }
        public static byte l { get; set; }

        public static char bc { get; set; }
        public static char de { get; set; }
        public static char hl { get; set; }


        /// <summary>
        /// Flag Register
        /// </summary>
        public static flags f { get; set; }

        /// <summary>
        /// Program Counter
        /// </summary>
        public static char pc { get; set; }

        /// <summary>
        /// Stack Pointer
        /// </summary>
        public static char sp { get; set; }


        public static byte m { get; set; }

        public static byte t { get; set; }

        public static void Reset()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            h = 0;
            l = 0;

            f = 0;
            sp = '\0';
            pc = '\0';
        }


    }
}
