using System;

namespace BinSearch
{
    class Program
    {
        static void Main(string[] args)
        {  // Бинарный поиск в массиве из n элементов
            Console.WriteLine("Загадайте число от 1 до 100");
            //Объявление, Инициализация
            bool conditionEq = false;
            bool conditionMore = false;
            int Left, Right, Mid;
            int n;
            n = 100;
            int[] NumArray = new int[n];
            NumArray[0] = 0;
            for (int i = 1; i < NumArray.Length; i++)
                NumArray[i] = NumArray[i - 1] + 1;
            Left = 0;
            Right = NumArray.Length - 1;
            Mid = (Left + Right) / 2;
            Console.WriteLine($" NumArray.Length : { NumArray.Length}");


            //Поиск
            while (conditionEq == false)
            {
                Console.WriteLine($"Это число равно {NumArray[Mid]}? (true or false)");
                conditionEq = bool.Parse(Console.ReadLine());
                if (conditionEq == true)
                {
                    Console.WriteLine($"Загаданное число = {NumArray[Mid]}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Это число больше {NumArray[Mid]}? (true or false)");
                    conditionMore = bool.Parse(Console.ReadLine());
                    if (conditionMore == true)
                        Left = Mid;
                    else
                        Right = Mid;
                    Mid = (Left + Right) / 2;


                }

            }
            

            
        }
    }
}
