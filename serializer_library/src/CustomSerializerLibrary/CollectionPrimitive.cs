using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerializerLibrary
{
    [Serializable]
    public class CollectionPrimitive
    {
        // List collections
        public List<int> intList;
        public List<float> floatList;
        public List<double> doubleList;
        public List<decimal> decimalList;
        public List<char> charList;
        public List<string> stringList;
        public List<bool> boolList;
        public List<short> shortList;
        public List<long> longList;
        public List<uint> uintList;
        public List<ushort> ushortList;
        public List<ulong> ulongList;
        public List<byte> byteList;
        public List<sbyte> sbyteList;
        public List<DateTime> dateTimeList;
    }
}
