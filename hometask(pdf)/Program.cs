using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_pdf_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("task1");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(number, 2));

            Console.WriteLine("task2");
            double exp = Math.Round((Math.E), 1);
            Console.WriteLine(exp);

            Console.WriteLine("task3");
            Console.WriteLine("Введите число");
            string inputnumber = (Console.ReadLine());
            Console.WriteLine("Вы ввели число: " + inputnumber);

            Console.WriteLine("task4");
            Console.WriteLine("Введите число");
            inputnumber = (Console.ReadLine());
            Console.WriteLine(inputnumber + "-вот какое число вы ввели!");

            Console.WriteLine("task5");
            int a, b, c;
            a = 1;
            b = 13;
            c = 49;
            Console.WriteLine($"{a} {b} {c}");

            Console.WriteLine("task6");
            Console.WriteLine("7  15  100");

            Console.WriteLine("task7");
            Random r = new Random();
            Console.WriteLine(r.Next() + "  " + r.Next() + "  " + r.Next());

            Console.WriteLine("task8");
            Console.WriteLine(r.Next() + " " + r.Next() + " " + r.Next() + " " + r.Next());

            Console.WriteLine("task9");
            a = 50;
            b = 10;
            Console.WriteLine($"{a}\n{b}");

            Console.WriteLine("task10");
            a = 5;
            b = 10;
            c = 21;
            Console.WriteLine($"{a}\n{b}\n{c}");

            Console.WriteLine("task11");
            Console.WriteLine(r.Next() + "\n" + r.Next() + "\n" + r.Next() + "\n" + r.Next());

            Console.WriteLine("task12");
            Console.WriteLine("5 10\n7 см");

            Console.WriteLine("task13");
            Console.WriteLine("2 кг\n13 17");

            Console.WriteLine("task1a");
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = 7 * x * x + 3 * x + 6;
            Console.WriteLine(y);

            Console.WriteLine("task1b");
            double a1 = double.Parse(Console.ReadLine());
            x = 12 * a1 * a1 + 7 * a1 + 12;
            Console.WriteLine(x);

            Console.WriteLine("task2");
            double side = double.Parse(Console.ReadLine());
            double perimeter = 4 * side;
            Console.WriteLine(perimeter);

            Console.WriteLine("task3");
            double radius = double.Parse(Console.ReadLine());
            double diameter = radius * 2;
            Console.WriteLine(diameter);

            Console.WriteLine("task4");
            double height = double.Parse(Console.ReadLine());
            radius = 6350;
            double way = Math.Sqrt((radius + height) * (radius + height) - radius * radius);
            Console.WriteLine(way);

            Console.WriteLine("task5");
            double cubeedge = double.Parse(Console.ReadLine());
            double v = Math.Pow(cubeedge, 3);
            Console.WriteLine(v);
            Console.WriteLine(4 * cubeedge * cubeedge);

            Console.WriteLine("task6");
            radius = double.Parse(Console.ReadLine());
            double length = 2 * Math.PI * radius;
            Console.WriteLine(length);
            double s = Math.PI * radius * radius;
            Console.WriteLine(s);

            Console.WriteLine("task7");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            double result = (double)(a + b) / 2;
            Console.WriteLine(result);
            result = Math.Sqrt(a * b);
            Console.WriteLine(result);

            Console.WriteLine("task8");
            double massa = double.Parse(Console.ReadLine());
            v = double.Parse(Console.ReadLine());
            double p = massa / v;
            Console.WriteLine(p);

            Console.WriteLine("task9");
            int people = int.Parse(Console.ReadLine());
            s = double.Parse(Console.ReadLine());
            p = people / s;
            Console.WriteLine(p);

            Console.WriteLine("task10");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a != 0)
            {
                x = (double)-b / a;
                Console.WriteLine(x);

            }
            Console.WriteLine("task11");
            double cathet1 = double.Parse(Console.ReadLine());
            double cathet2 = double.Parse(Console.ReadLine());
            double hypotenuse = Math.Sqrt(cathet1 * cathet1) + (cathet2 * cathet2);
            Console.WriteLine(hypotenuse);

            Console.WriteLine("task12");
            double outradius = double.Parse(Console.ReadLine());
            double inradius = double.Parse(Console.ReadLine());
            double ring = Math.PI * (outradius * outradius - inradius * inradius);
            Console.WriteLine(ring);

            Console.WriteLine("task13");
            double thefirstcathet = double.Parse(Console.ReadLine());
            double thesecondcathet = double.Parse(Console.ReadLine());
            double p3 = Math.Sqrt(thefirstcathet * thefirstcathet + thesecondcathet * thesecondcathet) + thefirstcathet + thesecondcathet;
            Console.WriteLine(p3);

            Console.WriteLine("task14");
            double down, up, h, d, between, res;
            Console.WriteLine("введите размер нижнего основания (в см)");
            down = double.Parse(Console.ReadLine());
            Console.WriteLine("введите размер верхнего основания (в см)");
            up = double.Parse(Console.ReadLine());
            Console.WriteLine("введите размер высоты (в см)");
            h = double.Parse(Console.ReadLine());
            d = Math.Abs(down - up) / 2;
            between = Math.Sqrt(h * h + d * d);
            res = 2 * between + down + up;
            Console.WriteLine("Периметр трапеции равен:" + res);

            Console.WriteLine("task14a");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double sumofthesides = (side1 + side2) * 2;
            double diagonal = Math.Sign(side1 * side1 + side2 * side2);
            Console.WriteLine("Периметр прямоугольника:" + sumofthesides);
            Console.WriteLine("Длина диагонали данного прямоугольника:" + diagonal);

            Console.WriteLine("task15");
            Console.WriteLine("Введите первое число");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double number2 = double.Parse(Console.ReadLine());
            double plus = number1 + number2;
            double minus = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;
            Console.WriteLine("Результат сложения:" + plus);
            Console.WriteLine("Результат вычитания:" + minus);
            Console.WriteLine("Результат умножения:" + multiplication);
            Console.WriteLine("Результат деления" + division);

            Console.WriteLine("task16");
            double f, g, q, volume, pov;
            f = double.Parse(Console.ReadLine());
            g = double.Parse(Console.ReadLine());
            q = double.Parse(Console.ReadLine());
            volume = f * g * q;
            pov = q * (2 * (f + g));
            Console.WriteLine("Объем фигуры:" + volume);
            Console.WriteLine("Площадь боковой поверхности фигуры:");

            Console.WriteLine("task18");
            double n, m, l, o, bet, resultat;
            Console.WriteLine("введите размер нижнего основания (в см)");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("введите размер верхнего основания (в см)");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("введите размер высоты (в см)");
            l = double.Parse(Console.ReadLine());
            o = Math.Abs(n - m) / 2;
            bet = Math.Sqrt(l * l + o * o);
            resultat = 2 * bet + n + m;
            Console.WriteLine("Периметр трапеции равен:" + resultat);

            Console.WriteLine("task19");
            Console.Write("Введите 1-ое основание трапеции: ");
            double base_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ое основание трапеции: ");
            double base_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите угол в градусах при большем основании: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь равнобедренной трапеции: {0}",
                Math.Abs(base_2 * base_2 - base_1 * base_1) * Math.Tan(angle * Math.PI / 180) / 4);

            Console.WriteLine("task22");
            int candies_price = random.Next(100, 200);
            int biscuits_price = random.Next(100, 200);
            int apples_price = random.Next(50, 100);
            Console.WriteLine("Стоимость конфет - {0}$ за киллограм\nСтоимость печенья - {1}$ за киллограм\nСтоимость яблок - {2}$ за киллограм\n",
                candies_price, biscuits_price, apples_price);
            Console.Write("Введите массу конфет в кг: ");
            double candies_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите массу печенья в кг: ");
            double biscuits_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите массу яблок в кг: ");
            double apples_weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость вашей покупки: {0}",
                candies_price * candies_weight + biscuits_price * biscuits_weight + apples_price * apples_weight);

            Console.WriteLine("task23");
            int keyboard_price, monitor_price, mouse_price, sysunit_price;
            keyboard_price = random.Next(100, 200);
            monitor_price = random.Next(400, 500);
            mouse_price = random.Next(50, 100);
            sysunit_price = random.Next(1500, 3000);
            Console.WriteLine("Прайс-лист:\n  Клавиатура = {0}\n  Монитор = {1}\n  Мышь = {2}\n  Системный блок = {3}\n 3 компьютера = {4} ",
                keyboard_price, monitor_price, mouse_price, sysunit_price, 3 * (keyboard_price + mouse_price + mouse_price + sysunit_price));
            Console.Write("Введите количество компьютеров которое вы хотите купить: ");
            int num_computer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость вашей покупки: {0}",
               (keyboard_price + mouse_price + mouse_price + sysunit_price) * num_computer);

            Console.WriteLine("task24");
            Console.Write("Введите возраст Тани: ");
            int age_tanya = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите возраст Мити: ");
            int age_mitya = Convert.ToInt32(Console.ReadLine());
            float average = (age_mitya + age_tanya) / 2;
            Console.WriteLine("Средний возраст Мити и Тани: {0}", average);
            Console.WriteLine("Возраст Мити отличается от среднего на {0} лет(год)", Math.Abs(average - age_mitya));
            Console.WriteLine("Возраст Тани отличается от среднего на {0} лет(год)", Math.Abs(average - age_tanya));

            Console.WriteLine("task25");
            Console.Write("Введите скорость 1-ого автомобиля в км/ч: ");
            double speed_1, speed_2, distance_1, speed_3, speed_4, distance_2;
            speed_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость 2-ого автомобиля в км/ч: ");
            speed_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояния между автомобилями в км: ");
            distance_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Автомобили встретятся через {0} час(а)", distance_1 / (speed_1 + speed_2));

            Console.WriteLine("task26");
            Console.Write("Введите скорость 1-ого автомобиля в км/ч: ");
            speed_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость 2-ого автомобиля в км/ч: ");
            speed_4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояния, на которое первый автомобиль опрередил второй в км: ");
            distance_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Через 30 минут после того, как первый автомобиль опередил второй на {0}км, расстояние между ними будет {1}км",
               distance_2, distance_2 + 0.5 * (speed_3 - speed_4));

            Console.WriteLine("task27");
            double temperature = random.Next(1000) - 273.15;
            Console.WriteLine("Значение температуры t по шкале Цельсия: {0}", temperature);
            Console.WriteLine("t  = {0} фаренгейтов", temperature * 1.8 + 32);
            Console.WriteLine("t  = {0} кельвинов", temperature + 273.15);

            Console.WriteLine("task28");
            Console.WriteLine("450 градусов по Фаренгейту есть {0} градусов по шкале Цельсия",
                (450 - 32) / 1.8);

            Console.WriteLine("task1");
            Console.Write("Введите значение a: ");
            double a_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("После обмена значениями: a = {0}; b = {1}.", a_1, b_1);

            Console.WriteLine("task2");
            Console.Write("Введите значение a: ");
            double a_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("После обмена значениями 1: a = {0}; b = {1}; c = {2}.", a_2, b_2, c_2);
            Console.WriteLine("После обмена значениями 2: a = {0}; b = {1}; c = {2}.", a_2, b_2, c_2);

            Console.WriteLine("task3");
            Console.WriteLine("Введите значение а: ");
            double a_3 = Convert.ToDouble(Console.ReadLine());
            double a2_3 = a_3 * a_3;
            double a4_3 = a2_3 * a2_3;
            double a6_3 = a2_3 * a2_3 * a2_3; // + a2_3 = a_3 * a_3(a)
            double a7_3 = a6_3 * a_3;// a6_3 получаем за три операции из (б)
            double a8_3 = a4_3 * a4_3;// a4_3 получаем за две операции из (а)
            double a9_3 = a8_3 * a_3; // a8_3 получаем за три операции из (г)
            double a10_3 = a8_3 * a2_3; // a8_3  и а2_3 получаем за три операции из (а) и (г)
            Console.WriteLine("a4 = {0}\na6 = {1}\na7 = {2}\na8 = {3}\na9 = {4}\na10 = {5}",
                a4_3, a6_3, a7_3, a8_3, a9_3, a10_3);

            Console.WriteLine("task4");
            Console.WriteLine("Введите значение а: ");
            double a_4 = Convert.ToDouble(Console.ReadLine());
            double a2_4 = a_4 * a_4;
            double a3_4 = a2_4 * a_4;
            double a5_4 = a3_4 * a2_4;
            double a10_4 = a5_4 * a5_4;

            double a4_4 = a2_4 * a2_4;
            double a8_4 = a4_4 * a4_4;
            double a16_4 = a8_4 * a8_4;
            double a20_4 = a16_4 * a4_4;

            double a13_4 = a10_4 * a3_4;

            double a19_4 = a10_4 * a5_4 * a4_4;

            double a17_4 = a10_4 * a5_4 * a2_4;
            double a12_4 = (a4_4 * a4_4) * a4_4;
            double a28_4 = a12_4 * a12_4 * a4_4;
            Console.WriteLine("a3 = {0} a10 = {1}\na4 = {2} a20 = {3}\na5 = {4} a13 = {5}\n" +
                " a5 = {6} a19 = {7}\n a2 = {8} a5 = {9} a17 = {10}\n a4 = {11} a12 = {12} a28 = {13}",
             a3_4, a10_4, a4_4, a20_4, a5_4, a13_4, a5_4, a19_4, a2_4, a5_4, a17_4, a4_4, a12_4, a28_4);

            Console.WriteLine("task5");
            int a_5 = 10;
            int a2_5 = a_5 * a_5;
            int a4_5 = a2_5 * a2_5;
            long a8_5 = a4_5 * a4_5;
            long a10_5 = a8_5 * a2_5;
            Console.WriteLine("10 в степени 10 можно получить за 4 операции умножения: a10 = {0} ", a10_5);

            Console.ReadKey();
        }
    }
}
