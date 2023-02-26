// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int Prompt(string message)
{
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
//метод для получения случайных чисел массива 
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[]array = new int [Length];//обьявляем массив
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue +1);//заполняем случайными цифрами из диапазона SatArr до EndArr
    }
    return array;
} 
//Вывод значения масссива 
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); //вывод значения массива 
    }
    System.Console.Write($"{array[array.Length - 1]}"); // вывод значения массива 
    System.Console.Write("]");
}
int length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int [] array = GenerateArray(length, min, max);//Заполнение массива случайными числами
PrintArray(array); //вывод массива