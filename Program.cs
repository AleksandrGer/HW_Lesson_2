// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень:");
// int pow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {number} в степени {pow} = {GetPow(number, pow)}");
// int GetPow (int n, int p)
// { 
//   int res = 0;
//   for (int i = 1; i < p; i++)
//   { 
//     res = n * n;
//   }
//   return res;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {number} = {GetSum(number)}");
// int GetSum (int num)
// {
//     int sum = 0;
//     while(num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] result = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join("; ", result)}]");
// int [] GetBinaryArray(int size)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(99, 1000);
//     }
//     return array;
// }