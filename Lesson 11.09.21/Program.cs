using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте," + name + "!");

            Console.WriteLine("task2");
            Console.WriteLine("Введите два числа и получите результат деления");
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            if (two != 0)
            {
                Console.WriteLine(one / two + " результат деления");
            }
            else
            {
                Console.WriteLine("Второе число не должно равняться нулю, измените!");
            }

            Console.WriteLine("task3");
            Console.WriteLine("Введите любую букву из русского алфавита");
            char k = Console.ReadKey().KeyChar;
            char letter1 = char.ToLower(k);
            char letter2;
            if (letter1 == 'z')
            {
                letter2 = 'a';
            }
            else
            {
                letter2 = (char)(((int)letter1) + 1);
            }

            Console.WriteLine("task4");
            Console.WriteLine("Введите коэффициент а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент в");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфффициент с");
            double c = double.Parse(Console.ReadLine());
            if (b * b - 4 * a * c >= 0)
            {
                double discriminant = b * b - 4 * a * c;
                Console.WriteLine("Корни данного уравнения-" + ((-b + Math.Sqrt(discriminant)) / (2 * a)).ToString() + ' ' + ((-b - Math.Sqrt(discriminant)) / (2 * a)).ToString());
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            Console.ReadKey();
        }
    }
}
