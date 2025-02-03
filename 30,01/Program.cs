using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30_01
{
    internal class Program
    {
        class Build
        {
            public string name;
            public double area;
            public int kvo;
            public int floor;

            public Build()//без параметров
            {
                name = "Строение";
                area = 0;   
                kvo = 0;    
            }

            public Build(string name, double area)//c параметроm
            {
                this.name = name;
                this.area = 600;
                kvo = 0;
            }
            public Build(string name, double area, int kvo, int floor)
            {
                this.name = name;
                this.area = area;
                this.kvo = kvo;
                this.floor = floor;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Название: {name}");
                Console.WriteLine($"Площадь: {area} кв.м");
                Console.WriteLine($"Жильцов: {kvo}");
                Console.WriteLine($"Площадь на одного жильца: {area / kvo} кв.м");
            }
        }
        

        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.name = "Рублевка";
            dom1.area = 170;
            dom1.kvo = 4;
            dom1.ShowInfo();

            Build dom2 = new Build("многоэтажка", 0);
            dom2.kvo = 50;
            dom2.ShowInfo();

            
            Console.Write("название здания: ");
            string name = Console.ReadLine();
            Console.Write("площадь здания: ");
            double area = double.Parse(Console.ReadLine());
            Console.Write("количество жильцов: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("количество этажей: ");
            int floor = int.Parse(Console.ReadLine());
            Build dom3 = new Build(name, area, kvo, floor);
            dom3.ShowInfo();
            Console.ReadKey();

        }
    }
}
