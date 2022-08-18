/* Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

class Program
{
    static int[]CreateArray(int number)
    {
        int[] array = new int[number];
        Console.Write("Введите максимальное значение: ");        
        int Max = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите минимальное значение: ");
        int Min = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(Min, Max);
        }
        return array;
    }
    
    static void WriteArray(int[] array)
    {
        for(int i = 0; i<array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void Main (string[] args)
    {
        Console.Write("Введите размер массива: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] array = CreateArray(N);
        WriteArray(array);
        Console.Write(" -> ");
        Console.Write("[");
        WriteArray(array);
        Console.Write("]");
    }
}
