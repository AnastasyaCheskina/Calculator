using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForTesting
{
    internal class Calculator
    {
        public static void Start()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Доступные операции:");
                Console.WriteLine("1 - сложение; 2 - вычитание; 3 - умножение; 4 - деление; 5 - возведение в степень; 6 - корень; 7 - процент от числа; 8 - log; 9 - sin; 10 - ctg");
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());
                double result = 0;
                switch (number)
                {
                    case 1:
                        result = GetAnswerTwoVariables(number);
                        break;
                    case 2:
                        result = GetAnswerTwoVariables(number);
                        break;
                    case 3:
                        result = GetAnswerTwoVariables(number);
                        break;
                    case 4:
                        result = GetAnswerTwoVariables(number);
                        break;
                    case 5:
                        result = GetAnswerTwoVariables(number);
                        break;
                    case 6:
                        result = GetAnswerOneVariable(number);
                        break;
                    case 7:
                        result = GetAnswerTwoVariables(number);
                        break;
                    case 8:
                        result = GetAnswerOneVariable(number);
                        break;
                    case 9:
                        result = GetAnswerOneVariable(number);
                        break;
                    case 10:
                        result = GetAnswerOneVariable(number);
                        break;
                    default:
                        Console.WriteLine("Такого номера задачи не существует");
                        break;
                }
                Console.WriteLine("Ответ: " + result);
                Console.Write("Вы желаете продолжить работу программы? 0 - да, 1 - нет: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1) flag = false;
            }
            
        }
        private static double GetAnswerTwoVariables(int number)
        {
            Console.Write("Введите первую переменную/основание степени/число от которого берется процент: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую переменную/показатель степени/процент: ");
            double y = double.Parse(Console.ReadLine());
            switch(number)
            {
                case 1: return x + y;
                case 2: return x - y;
                case 3: return x * y;
                case 4: return x / y;
                case 5: return Math.Pow(x, y);
                case 7: return (x * 100) / y;
                default: return 0;   
            }
        }
        private static double GetAnswerOneVariable(int number)
        {
            Console.Write("Введите число: ");
            double x = double.Parse(Console.ReadLine());
            switch(number)
            {
                case 6: return Math.Sqrt(x);
                case 8: return Math.Log(x);
                case 9: return Math.Sin(x);
                case 10: return Math.Cos(x) / Math.Sin(x);
                default: return 0;
            }
        }
    }
}
