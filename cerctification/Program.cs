﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int WorkWithUser(string message)
{
  Console.Write(message);
  int result = int.Parse(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = WorkWithUser("Input N: ");
if (n < 1)
{
  Console.WriteLine("Введите положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));
