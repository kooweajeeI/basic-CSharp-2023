using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enum
{
    internal class Program
    {
        enum HomeTown
        {
            SEOUL = 1,
            DAEJEON = 2,
            DAEGU = 4,
            BUSAN = 6,
            JEJU = 9
        };
        static void Main(string[] args)
        {
            HomeTown myHomeTown;

            myHomeTown = HomeTown.BUSAN;

            if (myHomeTown == HomeTown.SEOUL)
            {
                Console.WriteLine("서울 출신이군요!");
            }
            else if (myHomeTown == HomeTown.DAEJEON)
            {
                Console.WriteLine("충청도에유~");
            }
            else if (myHomeTown == HomeTown.DAEGU) {
                Console.WriteLine("대구여~");
            }
            else if (myHomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("부산입니데이~");
            }
        }
    }
}
