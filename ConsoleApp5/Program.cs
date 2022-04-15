using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█                     Student Information                    █");
            Console.WriteLine("█                                                            █");
            Console.WriteLine("█      ┌─────────────┐         ┌───────────────┐             █");
            Console.WriteLine("█ Name │             │   family│               │             █");
            Console.WriteLine("█      └─────────────┘         └───────────────┘             █");
            Console.WriteLine("█                                                            █");
            Console.WriteLine("█         ┌──────────────┐            ┌────────────────┐     █");
            Console.WriteLine("█ Birthday│              │   Id Number│                │     █");
            Console.WriteLine("█         └──────────────┘            └────────────────┘     █");
            Console.WriteLine("█                                                            █");
            Console.WriteLine("█        ┌─────────────────────────────────────────────┐     █");
            Console.WriteLine("█ Address│                                             │     █");
            Console.WriteLine("█        │                                             │     █");
            Console.WriteLine("█        └─────────────────────────────────────────────┘     █");
            Console.WriteLine("█                                                            █");
            Console.WriteLine("█    ┌────────────────┐                      ┌─┐ Diploma(D)  █");
            Console.WriteLine("█ Tel│                │    Father's Education│ │ Bachelor(B) █");
            Console.WriteLine("█    └────────────────┘                      └─┘ Master(M)   █");
            Console.WriteLine("█                                                PHD(P)      █");
            Console.WriteLine("█               ┌────────┐                                   █");
            Console.WriteLine("█ Grades Average│        │                                   █");
            Console.WriteLine("█               └────────┘                                   █");
            Console.WriteLine("█                                                            █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");



            Console.SetCursorPosition(8, 5);
            String name = Console.ReadLine();
            Console.SetCursorPosition(32, 5);
            String family = Console.ReadLine();
            Console.SetCursorPosition(11, 9);
            string birthday = Console.ReadLine();
            Console.SetCursorPosition(39, 9);
            string Id = Console.ReadLine();
            Console.SetCursorPosition(10, 13);
            string Address = Console.ReadLine();
            Console.SetCursorPosition(6, 18);
            string Tel = Console.ReadLine();
            Console.SetCursorPosition(46, 18);
            string FatherEDU = Console.ReadLine();
            Console.SetCursorPosition(17, 22);
            string grades = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(name);
            Console.Write(" ");
            Console.Write(family);
            Console.Write(" is registered in bet alhoda high school.");
            Console.ReadKey();

            StreamWriter sw = new StreamWriter($"C:\\Users\\Tara\\Desktop\\Highshool\\{name}-{family}.txt");
            sw.WriteLine($"name: {name}");
            sw.WriteLine($"family: {family}");
            sw.WriteLine($"birthday: {birthday}");
            sw.WriteLine($"ID: {Id}");
            sw.WriteLine($"Address: {Address}");
            sw.WriteLine($"Telphone: {Tel}");
            sw.WriteLine($"Father's Edu: {FatherEDU}");
            sw.WriteLine($"AVG: {grades}");
            sw.Close();

        }
    }
}
