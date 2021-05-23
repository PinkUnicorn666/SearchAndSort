using System;

namespace ShakerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сортировка перемешиванием
            //Объявление
            int[] numArray = new int[11];
            Random rand = new Random();
            int left, right, tempNum;
            //Инициализация
            left = 0;
            right = numArray.Length - 1; 
            for (int i = 0; i < numArray.Length; i++)
                numArray[i] = rand.Next(-100,100);

            Console.WriteLine("Неотсортированный массив:");
            for (int i =0;i<numArray.Length;i++)
            Console.Write(numArray[i] + "  ");
            Console.WriteLine();

            //Сортировка
            while (left < right)
            {
                for (int i =left; i<right;i++)
                 if (numArray[i] > numArray[i + 1])
                    {
                        tempNum = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = tempNum;
                    }
                
                right--;
                for (int i = right; i > left; i--)
                    if (numArray[i] < numArray[i - 1])
                    {
                        tempNum = numArray[i];
                        numArray[i] = numArray[i - 1];
                        numArray[i - 1] = tempNum;
                    }
                left++;
                

            }

            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < numArray.Length; i++) 
            Console.Write(numArray[i] + "  ");
            Console.WriteLine();

        }
    }
}
