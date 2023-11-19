// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// int size = 5;
// int count = 0;
// Console.WriteLine($"Введите заданное количество чисел ({size}): ");
// int[] numbers = new int[size];
// for (int i = 0; i < size; i++)
// {
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
//     if (numbers[i] > 0) count++;
// }
// Console.WriteLine();
// Console.WriteLine($"{String.Join("; ", numbers)} -> {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.WriteLine($"Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

//     double x = (b2-b1) / (k1-k2);
//     double y = k1 * x + b1;

// Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");