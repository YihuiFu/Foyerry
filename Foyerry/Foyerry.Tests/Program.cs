using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foyerry.Tools.String;

namespace Foyerry.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin ...");


            var p = Path.GetDirectoryName(@"E:\server.txt");
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }

    public class Animal
    {
        public string name;
        public int id;

        public Animal(string n, int i)
        {
            name = n;
            this.id = i;
        }

        public void Eat()
        {
            Console.WriteLine("父类eat");
        }
    }

    public class Cat : Animal
    {
        public Cat(string n, int i, string ha)
            : base(n, i)
        {
        }

        public void Eat(int num)
        {
            Console.WriteLine("Cat eat");
        }

    }
}
