using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            table.color = "White";
            table.material = "Wooden";
            table.property();

            Seat seat = new Seat();
            seat.color = "Grey";
            seat.fabric = "Latex";
            seat.property();

            Console.ReadLine();
        }
    }
    abstract class Furniture
    {
        public string color { get; set; }
        public abstract void property();
    }
    class Table : Furniture
    {
        public override void property()
        {
            Console.WriteLine("Properties of table:");
            Console.WriteLine("Color:"+" "+color);
            Console.WriteLine("Material:" + " " + material);
        }

        public string material { get; set; }
    }
    class Seat : Furniture
    {
        public override void property()
        {
            Console.WriteLine("Properties of seat:");
            Console.WriteLine("Color:" + " " + color);
            Console.WriteLine("Fabric:" + " " + fabric);
        }

        public string fabric { get; set; }
    }
}
