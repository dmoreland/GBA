using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://github.com/CRogers/GbcEmulator/blob/master/GbcEmulator/Cpu/Z80.Opcodes.cs
/// http://imrannazar.com/Gameboy-Z80-Opcode-Map
/// </summary>
namespace CPU
{
    public class Opcodes
    {
        private readonly IMMU _mmu;

        public Dictionary<byte, Action> _opcodes = new Dictionary<byte, Action>();
        

        public Opcodes(IMMU mmu)
        {
            _mmu = mmu;    
        }

        //TODO Read Next Word From Rom
        private char ReadWord()
        {
            throw new NotImplementedException();
        }

        //TODO Read Next Byte From Rom
        private byte ReadByte()
        {
            throw new NotImplementedException();
        }

        private void InitiateOpcodes()
        {
            _opcodes = new Dictionary<byte, Action> {
                { 0x0, () => { } },    
                { 0x01, () => Registers.bc = ReadWord() },
                { 0x02, () => _mmu.WriteByte(Registers.bc, Registers.a) },
                { 0x03, () => Registers.bc++}
            };
        }
      

    }
}
