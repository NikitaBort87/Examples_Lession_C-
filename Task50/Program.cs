//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
//  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] numbers = new int[4, 3];
void RandArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

RandArray(numbers);
PrintArray(numbers);
int m = ReadInt("Введите индекс строки: ");
int n = ReadInt("Введите индекс столбца: ");

if (m < numbers.GetLength(0) && n < numbers.GetLength(1))
{
    Console.WriteLine(numbers[m, n]);
}
else
{
    Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
}