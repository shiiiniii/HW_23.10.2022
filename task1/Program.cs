// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Clear();
Console.Write("Введите число, которое хотите проверить: ");
int number = int.Parse(Console.ReadLine());
int digit1 = number % 10;
int digit2 = (number / 10) % 10;
int digit4 = (number /1000) % 10;
int digit5 = (number /10000) % 10;
if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine($"Число {number} палиндром");
}
else 
{
     Console.WriteLine($"Число {number} не палиндром");
}