// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Az: ");
double Az = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите By: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2));
Console.WriteLine($"Расстояние между точками = {result}");