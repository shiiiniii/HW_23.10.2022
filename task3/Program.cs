// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    {
        Console.WriteLine($"{i} x {i} x {i} = {i*i*i}");
    }
    Console.WriteLine();
}