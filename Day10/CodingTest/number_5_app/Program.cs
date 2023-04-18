using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        void Eat();
        void Sleep();
        void Sound();
    }
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("강아지 {0}가 먹고 있습니다.", this.Name);
        }

        public void Sleep()
        {
            Console.WriteLine("강아지 {0}가 자고 있습니다.", this.Name);
        }

        public void Sound()
        {
            Console.WriteLine("강아지 {0}가 멍멍 소리를 냅니다.", this.Name);
        }
    }

    class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("고양이 {0}가 먹고 있습니다.", this.Name);
        }

        public void Sleep()
        {
            Console.WriteLine("고양이 {0}가 자고 있습니다.", this.Name);
        }

        public void Sound()
        {
            Console.WriteLine("고양이 {0}가 야옹 소리를 냅니다.", this.Name);
        }
    }

    class Horse : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("말 {0}가 먹고 있습니다.", this.Name);
        }

        public void Sleep()
        {
            Console.WriteLine("말 {0}가 자고 있습니다.", this.Name);
        }

        public void Sound()
        {
            Console.WriteLine("말 {0}가 히이잉 소리를 냅니다.", this.Name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog { Name = "춘식이", Age = 2 };
            IAnimal cat = new Cat { Name = "춘냥이", Age = 1 };
            IAnimal horse = new Horse { Name = "춘말이", Age = 3 };

            dog.Eat();
            dog.Sound();
            dog.Sleep();

            cat.Eat();
            cat.Sound();
            cat.Sleep();

            horse.Eat();
            horse.Sound();
            horse.Sleep();
        }
    }
}
