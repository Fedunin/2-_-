//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблиись!\nВведите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n == 1)
    Console.WriteLine("нет, будний день");
else if (n == 2)
    Console.WriteLine("нет, будний день");
else if (n == 3)
    Console.WriteLine("нет, будний день");
else if (n == 4)
    Console.WriteLine("нет, будний день");
else if (n == 5)
    Console.WriteLine("нет, будний день");
else if (n == 6)
    Console.WriteLine("Да, выходной день");
else
    Console.WriteLine("Да, выходной день");
