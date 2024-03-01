using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //all variable types
            //sbyte
            sbyte sbytemax = sbyte.MaxValue;
            sbyte sbytemin = sbyte.MinValue;
            //short
            short shortmax = short.MaxValue;
            short shortmin = short.MinValue;
            //int
            int intmax = int.MaxValue;
            int intmin = int.MinValue;
            //long
            long longmax = long.MaxValue;
            long longmin = long.MinValue;
            //byte
            byte bytemax = byte.MaxValue;
            byte bytemin = byte.MinValue;
            //ushort
            ushort ushortmax = ushort.MaxValue;
            ushort ushortmin = ushort.MinValue;
            //uint
            uint uintmax = uint.MaxValue;
            uint uintmin = uint.MinValue;
            //ulong
            ulong ulongmax = ulong.MaxValue;
            ulong ulongmin = ulong.MinValue;
            //char
            char charmax = char.MaxValue;
            char charmin = char.MinValue;
            //float
            float floatmax = float.MaxValue;
            float floatmin = float.MinValue;
            //double
            double doublemax = double.MaxValue;
            double doublemin = double.MinValue;
            //decimal
            decimal decimalmax = decimal.MaxValue;
            decimal decimalmin = decimal.MinValue;

            //print all variable types
            //sbyte
            Console.WriteLine($"sbyte max: {sbytemax}, sbyte min: {sbytemin}");
            //short
            Console.WriteLine($"short max: {shortmax}, short min: {shortmin}");
            //int
            Console.WriteLine($"int max: {intmax}, int min: {intmin}");
            //long
            Console.WriteLine($"long max: {longmax}, long min: {longmin}");
            //byte
            Console.WriteLine($"byte max: {bytemax}, byte min: {bytemin}");
            //ushort
            Console.WriteLine
            ($"ushort max: {ushortmax}, ushort min: {ushortmin}");
            //uint
            Console.WriteLine($"uint max: {uintmax}, uint min: {uintmin}");
            //ulong
            Console.WriteLine($"ulong max: {ulongmax}, ulong min: {ulongmin}");
            //char
            Console.WriteLine($"char max: {charmax}, char min: {charmin}");
            //float
            Console.WriteLine($"float max: {floatmax}, float min: {floatmin}");
            //double
            Console.WriteLine
            ($"double max: {doublemax}, double min: {doublemin}");
            //decimal
            Console.WriteLine
            ($"decimal max: {decimalmax}, decimal min: {decimalmin}");

            //infinite and NaN
            float posinfinite = float.PositiveInfinity;
            float neginfinite = float.NegativeInfinity;
            double notanumber = double.NaN;
            Console.WriteLine
            ($"+infinity: {posinfinite}, -infinity: {neginfinite}");
            Console.WriteLine($"Not a Number: {notanumber}");

            //overflows and underflows
            uint uintmax2 = ushort.MaxValue;
            Console.WriteLine((ushort)(uintmax2+1));
        }
    }
}
