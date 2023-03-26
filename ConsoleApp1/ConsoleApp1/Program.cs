using System;

class Program
{
    static void Main()
    {
        //Console.Write("Число Массива=");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //Random rnd = new Random();
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = rnd.Next(1, 121);
        //}
        //Console.WriteLine("Массив:");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(array[i] + " ");
        //}
        //Console.WriteLine();
        //int max = array[0];
        //int min = array[0];
        //int maxIndex = 0;
        //int minIndex = 0;
        //for (int i = 1; i < n; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //        maxIndex = i;
        //    }
        //    if (array[i] < min)
        //    {
        //        min = array[i];
        //        minIndex = i;
        //    }
        //}
        //Console.WriteLine("Максимальный элемент: " + max);
        //Console.WriteLine("Минимальный элемент: " + min);
        //int temp = array[maxIndex];
        //array[maxIndex] = array[minIndex];
        //array[minIndex] = temp;
        //Console.WriteLine("Измененный массив:");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(array[i] + " ");
        //}
        //Console.WriteLine();
        //Console.ReadLine();

        //Zadanie #2 Ввести массив, состоящий из 12 элементов действительного типа.
        //Расположить элементы в порядке убывания. Вычислить сумму максимального и минимального элементов массива
        //double[] arr = new double[12];
        //    for (int i = 0; i < 12; i++)
        //    {
        //        Console.Write(+(i + 1) + "-й элемент массива: ");
        //        arr[i] = double.Parse(Console.ReadLine());
        //    }
        //    Array.Sort(arr);
        //    Array.Reverse(arr);
        //    Console.WriteLine("Массив в в убывания:");
        //    for (int i = 0; i < 12; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine();
        //    double max = arr[0];
        //    double min = arr[11];
        //    Console.WriteLine("Максимальный элемент: " + max);
        //    Console.WriteLine("Минимальный элемент: " + min);
        //    double sum = max + min;
        //    Console.WriteLine("Сумма max и min элемента: " + sum);
        //Console.ReadLine();

        //Zadanie 3 Ввести массив, состоящий из 14 элементов действительного типа.
        //Расположить элементы c 1 по 7 по возрастанию, а с 8 по 14 - в порядке убывания 
        double[] array = new double[14];
        for (int i = 0; i < 14; i++)
        {
            Console.Write(+ (i + 1) + "-й элемент массива: ");
            array[i] = double.Parse(Console.ReadLine());
        }
        Array.Sort(array, 0, 7);
        Array.Sort(array, 7, 7);
        Array.Reverse(array, 7, 7);
        Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < 14; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
