using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산
            int firstval = 0b1111;      // 15
            int secondval = firstval << 1;
            Console.WriteLine(firstval);
            Console.WriteLine(secondval);

            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);
            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(firstval ^ secondval);    // XOR
            Console.WriteLine(~secondval);  //  보수

            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null ? 0 : checkval);     // 삼항연산자
            Console.WriteLine(checkval ?? 0);     // null 병합연산자

            checkval = 25;
            Console.WriteLine(checkval.HasValue ? checkval.Value : 0);
            Console.WriteLine(checkval ?? 0);
        }
    }
}
