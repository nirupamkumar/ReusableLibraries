using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerializerLibrary
{
    [Serializable]
    public class ArrayPrimitive
    {
        public int[] intVariable;
        public float[] floatVariable;
        public double[] doubleVariable;
        public decimal[] decimalVariable;
        public char[] charVariable;
        public string[] stringVariable;
        public bool[] boolVariable;
        public short[] shortVariable;
        public long[] longVariable;
        public uint[] uintVariable;
        public ushort[] ushortVariable;
        public ulong[] ulongVariable;
        public byte[] byteVariable;
        public sbyte[] sbyteVariable;
        public DateTime[] DateTimeVariable;
    }
}
