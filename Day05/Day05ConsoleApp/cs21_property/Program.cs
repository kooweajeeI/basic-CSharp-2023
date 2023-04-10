using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    class Boiler
    {
        private int temp;       // 멤버변수
        public int Temp         // 프로퍼티(속성)
        {
            get { return temp; }
            set
            {
                if (value <= 10 || value >= 70)
                {
                    temp = 10;      // 제일 낮은 온도로 변경설정
                }
                else
                {
                    temp = value;
                }
            }
        }
        // 위의 get; set;과 비교 // 아래의 Get메서드와 Set메서드는 Java에서만 사용
        public void SetTemp(int temp)
        {
            if (temp <= 10 || temp >= 70)
            {
                // Console.WriteLine("수온설정 값이 너무 낮거나 높습니다. 10~70도 사이로 지정해주세요.");
                // return;
                this.temp = 10;
            }
            else
            {
                this.temp = temp;
            }
        }

        public int GetTemp()
        {
            return this.temp;
        }

        class Car
        {
            string name;
            string color;
            int year;
            string fuelType;
            int door;
            string tireType;
            string company;
            int price;
            string carIdNumber;
            string carPlateNumber;

            public string Name { get; set; }    // 필터링이 필요없으면 멤버변수 없이 프로퍼티로 대체
            public string Color { get; set; }

            // 들어오는 데이터를 필터링 할 때는 private 멤버변수와 public 프로퍼티를 둘 다 사용
            public int Year
            {
                get { return year; }
                set
                {
                    if (value <= 1990 || value >= 2023)
                    {
                        value = 2023;
                    }
                    year = value;
                }
            }
            public string FuelType
            {
                get => fuelType;
                set
                {
                    if (value != "휘발유" || value != "경유")
                    {
                        value = "휘발유";
                    }
                    fuelType = value;
                }
            }

            public int Door { get => door; set => door = value; }
            public string TireType { get; set; }
            public string Company { get; set; } = "현대자동차";
            public int Price { get => price; set => price = value; }
            public string CarIdNumber { get; set; }
            public string CarPlateNumber { get; set; }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Boiler kitturami = new Boiler();
                // kitturami.temp = 60;/
                // kitturami.temp = 300000;    // 물 수온이 30만도?

                kitturami.SetTemp(50);
                Console.WriteLine(kitturami.GetTemp());

                Boiler navien = new Boiler();
                navien.Temp = 5000;
                Console.WriteLine(navien.Temp);

                Car ionic = new Car();
                ionic.Name = "아이오닉";
                Console.WriteLine(ionic.Name);

                // 생성할 때 프로퍼티로 초기화
                Car genesis = new Car()
                {
                    Name = "제네시스",
                    FuelType = "휘발유",
                    Color = "흰색",
                    Door = 4,
                    TireType = "광폭타이어",
                    Year = 0,
                };

                Console.WriteLine("자동차 제조회사는 {0}", genesis.Company);
                Console.WriteLine("자동차 제조년도는 {0}년", genesis.Year);
            }
        }
    }
}
