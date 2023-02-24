// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 100)
{
       System.Console.WriteLine("Третьей цифры нет");
}
if (num1 > 9999)
{
    num1 /= 100;
    System.Console.WriteLine(num1 % 10);
}
System.Console.WriteLine(num1 % 10);