using System;

class Program
{
    static void Main()
    {
        Console.Write("Число Массива=");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.Next(1, 121);
        }
        Console.WriteLine("Массив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        int max = array[0];
        int min = array[0];
        int maxIndex = 0;
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Минимальный элемент: " + min);
        int temp = array[maxIndex];
        array[maxIndex] = array[minIndex];
        array[minIndex] = temp;
        Console.WriteLine("Измененный массив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
