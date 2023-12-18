using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            //Random rnd = new Random();
            //int number = rnd.Next(-10, 10);
            //Console.WriteLine(number);
            //switch (number)
            //{
            //    case 1: Console.WriteLine("понедельник"); break;
            //    case 2: Console.WriteLine("vtornik"); break;
            //    case 3: Console.WriteLine("sreda"); break;
            //    case 4: Console.WriteLine("chetverg"); break;
            //    case 5: Console.WriteLine("pyatnica"); break;
            //    case 6: Console.WriteLine("subbota"); break;
            //    case 7: Console.WriteLine("voskresenye"); break;
            //    default: Console.WriteLine("ошибка"); break;
            //}
            //Console.ReadLine();




            //Задача 2. Даны два целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.

            //Console.WriteLine("number 1 = ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("number 2 = ");
            //int number2 = int.Parse(Console.ReadLine());
            //if (number1 % 2 == 0 & number2 % 2 == 0)
            //{
            //    number1 /= 2;
            //    number2 /= 2;
            //}
            //else if (number1 % 2 == 0 | number2 % 2 == 0)
            //{
            //    number1 *= 2;
            //    number2 *= 2;
            //}
            //else
            //{
            //    number1++;
            //    number2++;
            //}
            //Console.WriteLine($"{number1}, {number2}");
            //Console.ReadKey();



            //Задача 3.Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».
            //Console.WriteLine("mark=");
            //int mark = int.Parse(Console.ReadLine());
            //if (mark >= 90 & mark <= 100)
            //{
            //    Console.WriteLine("отлично");
            //}
            //else if (mark >= 70 & mark < 90)
            //{
            //    Console.WriteLine("хорошо");
            //}
            //else if (mark >= 50 & mark < 70)
            //{
            //    Console.WriteLine("удовлитворитеьно");
            //}
            //else if (mark < 50)
            //{
            //    Console.WriteLine("неудовлитворитеьно");
            //}
            //else
            //{
            //    Console.WriteLine("Введите корректное значение");
            //}
            //Console.ReadKey();
        }
    }
}

