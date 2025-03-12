using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра X: ");
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = 3 * Math.Sin(x + 2);
            Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();
            return;
        }
    }
}

