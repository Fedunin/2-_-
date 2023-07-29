// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int n1 = number % 100;
int n2 = n1 / 10;
Console.Write(n2);


