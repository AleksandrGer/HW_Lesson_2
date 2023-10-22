
// Задача 10.

// int number = new Random() .Next(100, 1000);
// int secondDigit = number % 100 / 10;
// Console.WriteLine($"Число {number}, вторая цифра {secondDigit}");


// Задача 13.

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// int number;
// bool IsNumber = int.TryParse(stringNumber, out number);
// if (IsNumber && stringNumber.Length >= 3)
// {
//   Console.WriteLine("В вашей строчке только цифры и оно имеет третий знак! *Correct*");
//   Console.WriteLine($"Число {stringNumber}, третья цифра {stringNumber[2]}");
// }
// else
// {
//   Console.WriteLine("Введены посторонние символы или нет третьей цифры! *Fix*");
// }


// Задача 15.

// Console.Write("Введите номер дня недели от 1 до 7: ");
// string stringNumber = Console.ReadLine();
// int number;
// bool IsNumber = int.TryParse(stringNumber, out number);
// if (IsNumber && number == 6 || number == 7)
// {
//   Console.WriteLine("Это выходной день!!!");

// }
// if (IsNumber && number < 6 && number > 1)
// {
//   Console.WriteLine("Это будний день...");

// }
// if(IsNumber == false || number > 7 || number < 1)
// {
//   Console.WriteLine("Введены посторонние символы или число вне диапазона!");
// }