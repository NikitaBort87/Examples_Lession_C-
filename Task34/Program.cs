// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftrange, int rightrange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 999);
    }
    return array;
}
void PrintArray(int[] array) //Функция вывода нашего массива
{
    System.Console.WriteLine($"[" + string.Join(", ", array) + "]" ); 
}
void PositiveNum(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
           Array[i] = count;
           count++;
                   }
    } return ;

}


int[] array = GenerateArray(4, 100, 999);
PrintArray(array);
PositiveNum(array);




//     int count = 0 ;
//     for (int i = 0; i < size; i++)
//            if (array[i] %2 == 0 )
//            {
//            (count = array[i]);
//            }
//             System.Console.WriteLine(count);