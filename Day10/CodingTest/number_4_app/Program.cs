using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> rainbow = new Dictionary<string, string>();
            rainbow.Add("빨간색", "Red");
            rainbow.Add("주황색", "Orange");
            rainbow.Add("노란색", "Yellow");
            rainbow.Add("초록색", "Green");
            rainbow.Add("파란색", "Blue");
            rainbow.Add("남색", "Navy");
            rainbow.Add("보라색", "Purple");

            Console.Write("무지개 색은 ");
            foreach (string color in rainbow.Keys)
            {
                Console.Write(color + ", ");
            }
            Console.WriteLine("입니다. \n");

            string keyToFind = "Purple";
            foreach (KeyValuePair<string, string> entry in rainbow)
            {
                if (entry.Value == keyToFind)
                {
                    Console.WriteLine("Key와 Value 확인");
                    Console.WriteLine("{0}은 {1}입니다.",  entry.Value, entry.Key);
                    break;
                }
            }
        }


    }
}
