using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Kvadrat
    {
        public int l;
        public int h;
        public int R;
        public void koord()
        {
            Console.WriteLine($"{l} {h} {R}");
        }
    }
    class Employee : Kvadrat
    {
        public void S()
        {
            Console.WriteLine($"{3.14 * R * (R * R + h * h) + 3.14 * R * R}");
        }
        public void V()
        {
            Console.WriteLine($"{(3.14 * R * (R * R + h * h) + 3.14 * R * R) / 3 * h}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat tom = new Kvadrat();

            tom.l = 5;
            tom.h = 34;
            tom.R = 15;
            tom.koord();

            Console.ReadKey();
        }
    }
}

