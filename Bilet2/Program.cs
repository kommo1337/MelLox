using System;
namespace Bilet2
{
    internal class Program
    {
        /*
          Без знака byte ushort uint ulong
          Со знаком  short int long sbyte
          Вещественные float double decimal 

          Convert нужен для перевода из 1 типа данных в другой
         */
        static void Main(string[] args)
        {
            sbyte s = 58;
            int i = 89235;
            float ui64 = 2346523623;

            Convert.ToUInt16(s);
            Convert.ToString(i);
            Convert.ToInt64(ui64);
        }
    }
}
