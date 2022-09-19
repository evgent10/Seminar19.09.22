// int a =new Random().Next(100,1000);
// Console.WriteLine(a);
// int c = 0; // первая цифра в числе
// int b = 0; //последняя цифра в числе

// c = a/100 *10;
//  int c1 = a/100;
// b = a%10;

// int sum = c+b;
// Console.WriteLine($"{c1} {b}");
// Console.WriteLine(sum);




// Программа, которая принимает 2 числа и выводит, является ли второе число кратным первого.
// 34, 5 -> не кратно, остаток 4  ;  4, 16 -> кратно

// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (b%a == 0)
// {
//     Console.Write("Кратно");
// }
// else
// {
//     int ost = b%a;
//     Console.Write($"Не кратно, остаток {ost}");
// }




// Написать программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.  14-> нет   45-> нет  161-> да

// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// if ((a%7 == 0) && (a%23 == 0))
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }

// вариант 2
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

if ((a%7 != 0) || (a%23 != 0))
{
    Console.WriteLine("Не делится");
}
else
{
    Console.WriteLine("Введёное число делится на 7 и на 23");
}