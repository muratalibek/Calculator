using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true){

                double firstNum, secondNum;
                string action;

                try
                {
                    Console.WriteLine("Введите 1. число");
                    firstNum = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите 2. число");
                    secondNum = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Не корректный ввод!!!");
                    Console.ReadLine();
                    continue;
                }

            Console.WriteLine("Введите операцию: '+' '-' '*' '/'");
            action = Console.ReadLine();    

            switch (action)
            {
                case "+": 
                    Console.WriteLine(firstNum+secondNum);
                    break;
                case "-":
                    Console.WriteLine(firstNum-secondNum);
                    break;
                case "*":
                    Console.WriteLine(firstNum*secondNum);
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(firstNum / secondNum);
                    }
                    break;
                default:
                    Console.WriteLine("Вы не ввели операцию");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
