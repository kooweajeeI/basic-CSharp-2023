using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delegatechain
{
    delegate void ThereIsAFire(string location); // 불났을 때 대신해주는 대리자

    delegate int Calc(int a, int b);  // 대리자로 좀 더 간단하게

    delegate string Concatenate(string[] args);


    class Sample
    {
        public int valueA;  // 멤버변수 - 외부에서 접근불가

        private int ValueA  // 프로퍼티
        {
            //get { return valueA; }
            //set { valueA = value; }
            get => valueA;
            set => valueA = value;
        }
        internal class Program
        {
            #region < 축소 >
            static void Call119(string location)
            {
                Console.WriteLine("소방서죠? {0}에 불났어요!!", location);
            }
            static void Shoutout(string location)
            {
                Console.WriteLine("여기 {0}에 불났어요!", location);
            }

            static void Escape(string location)
            {
                Console.WriteLine("{0}에서 탈출합니다.", location);
            }
            #endregion
            static string ProcConcate(string[] args)
            {
                string result = string.Empty;  // == "";
                foreach (string s in args)
                {
                    result += s + "/";
                }

                return result;
            }
            static void Main(string[] args)
            {
                #region < 대리자 체인 영역 >
                var loc = "우리집";
                Call119(loc);
                Shoutout(loc);
                Escape(loc);

                // 불이 날 수도 있으니까 미리 준비
                var otherloc = "경찰서";
                ThereIsAFire fire = new ThereIsAFire(Call119);
                fire += new ThereIsAFire(Shoutout);
                fire += new ThereIsAFire(Escape);  // 대리자에 메서드 추가

                fire(otherloc);  // 불이 나면 위에 준비해 놓은 것 실행

                fire -= new ThereIsAFire(Shoutout);  // 대리자에서 메세드를 삭제

                fire("다른집");

                // 익명함수
                Calc plus = delegate (int a, int b)
                {
                    return a + b;
                };

                Console.WriteLine(plus(6, 7));

                //Calc minus = delegate (int a, int b)
                //{
                //    return a - b;
                //};

                Calc minus = (a, b) => { return a - b; };

                Console.WriteLine(minus(67, 9));

                Calc simpleMinus = (a, b) => a - b;  // 람다식
                #endregion

                Concatenate concat = new Concatenate(ProcConcate);
                var result = concat(args);

                Console.WriteLine(result);

                Console.WriteLine("람다식으로");
                Concatenate concat2 = (arr) =>
                {
                    string res = string.Empty; // == "";
                    foreach (string s in args)
                    {
                        res += s + "/";
                    }

                    return res;
                };

                Console.WriteLine(concat2(args));
            }
        }
    }
}
