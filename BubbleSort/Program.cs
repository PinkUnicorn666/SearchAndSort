using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сортировка пузырьком
            //Объявление
            int[] numsArray = new int[10];
            Random rand = new Random();
            int tempNum;
            //Заполнение массива
            for (int i = 0; i < numsArray.Length; i++)
                numsArray[i] = rand.Next(-100, 100);

             Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < numsArray.Length; i++)
                    Console.Write(numsArray[i] + "  ");
                    Console.WriteLine();
            //Сортировка
            for (int i = 0; i < numsArray.Length - 1; i++)
                for (int j = numsArray.Length-1; j > i; j--)
                    if (numsArray[i] > numsArray[j])
                    {
                        tempNum = numsArray[i];
                        numsArray[i] = numsArray[j];
                        numsArray[j] = tempNum;
                    }

                    Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < numsArray.Length; i++)
                Console.Write(numsArray[i] + "  ");
            Console.WriteLine();
        }
    }
}
