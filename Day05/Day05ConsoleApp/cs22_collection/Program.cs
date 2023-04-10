using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs22_collection
{
    class MyList
    {
        int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int length
        {
            get { return array.Length; }
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index+1);
                    Console.WriteLine("MyList Resized : {0}", array.Length);
                }

                array[index] = value;       // 값 할당
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            // Console.Write(array[5]);

            char[] oldString = new char[5]; // 문자열길이를 지정해야하니까 C에서만 사용
            string curString = "";          // 문자열 길이 제한 없음

            // ArrayList
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);    // 위의 배열과 차이점

            // 여러 가지 메서드
            ArrayList list2 = new ArrayList();
            list2.Add(8);
            list2.Add(4);
            list2.Add(15);
            list2.Add(10);
            list2.Add(7);
            list2.Add(2);

            foreach(var item in list2) {
                Console.WriteLine(item);
            }

            // list에서 데이터 삭제
            Console.WriteLine("10 삭제 후 ");
            list2.Remove(10);
           
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("정렬");
            list2.Sort();
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }

            // 새로 만든 MyList
            MyList myList = new MyList();
            for (int i = 1; i<=5; i++)
            {
                myList[i] = i * 5;
            }

            for(int i = 0; i<myList.length; i++) {
                Console.WriteLine(myList[i]);
            }

            // ArrayList
        }
    }
}
