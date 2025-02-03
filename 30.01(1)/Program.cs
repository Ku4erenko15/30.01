using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._01_1_
{
    internal class Program
    {
        class PC
        {
            public string Model;
            public double Cpu;
            public int Ram;
            public int Hdd;

            public PC()
            {
                Model = "Офис";
                Cpu = 1.5;
                Ram = 8;
                Hdd = 500;
            }
            public PC(string model, double cpu, int ram, int hdd)
            {
                Model = model;
                Cpu = cpu;
                Ram = ram;
                Hdd = hdd;
            }
            public void Info()
            {
                Console.WriteLine($"Модель:{Model}");
                Console.WriteLine($"Тактовая частота: {Cpu} Ггц ");
                Console.WriteLine($"Объем ОЗУ: {Ram} Гб");
                Console.WriteLine($"Объем накопителя: {Hdd} Гб ");
            }
            public override string ToString()
            {
                return $"Модель: {Model}, Тактовая частота: {Cpu} ГГц, ОЗУ: {Ram} ГБ, HDD: {Hdd} ГБ";
            }
        }
        static void Main(string[] args)
        {
            PC Candy = new PC("Candy",3.35, 12,1000);
            Candy.Info();
            Console.WriteLine (Candy.ToString());

            PC Office = new PC();
            Office.Info();
            Console.WriteLine (Office.ToString());

            Console.Write("Модель:");
            string Model = Console.ReadLine();   
            Console.Write("Тактовая частота:");
            double Cpu = double.Parse(Console.ReadLine());
            Console.Write("Объем ОЗУ:");
            int Ram = int.Parse(Console.ReadLine());
            Console.Write("Объем накопителя;");
            int Hdd = int.Parse(Console.ReadLine());    
            PC User = new PC();
            User.Info();
            Console.WriteLine(User.ToString());


            Console.ReadLine();
        }
    }
}
