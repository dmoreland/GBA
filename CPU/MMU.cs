using System;
using System.Collections.Generic;
using System.Text;

namespace CPU
{
    public interface IMMU
    {
        byte ReadByte(int address);
        char ReadWord(int address);

        void WriteByte(int address, byte value);
        void WriteWord(int address, char value);
    }
    
}
