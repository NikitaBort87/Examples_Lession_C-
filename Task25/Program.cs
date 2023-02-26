// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int ex = Convert.ToInt32(Console.ReadLine());
int Pow(int num, int ex)
{
    int num1 =1;
    for(int i = 0; i < ex; i++)
    {
        num1 = num1*num;
    }
    return num1;
}

System.Console.WriteLine(Pow( num,  ex));