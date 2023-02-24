// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет
System.Console.WriteLine("Введите число");
int numday = Convert.ToInt32(Console.ReadLine());
if (numday>0 && numday <=5)
{
    System.Console.WriteLine("Рабочий день");
}
else 
{
    System.Console.WriteLine("Выходной");
}
if( numday >= 8)
{
    System.Console.WriteLine("Такого дня недели нет");
}