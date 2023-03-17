﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int m = Input("Введите m: ");
int n = Input("Введите n: ");
int FunctionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {FunctionAkkerman} ");
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
int Input(string text) 
{
  Console.Write(text);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
