
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MultiBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multiBuilding = new MultiBuilding("Москва", 58000, 18000, 16660, 5);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Building()
        {

        }
        public Building(string address, double lenght, double width, double heigth)
        {
            Address = address;
            Lenght = lenght;
            Width = width;
            Height = heigth;
        }
        public void Print()
        {
            Console.WriteLine("{0},{1},{2},{3}", Address, Lenght, Width, Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floors { get; set; }
        public MultiBuilding()
        {

        }
        public MultiBuilding(string address, double lenght, double width, double heigth, int floors)
            : base(address, lenght, width, heigth)
        {
            Floors = floors;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("{0}", Floors);
        }
    }
}
