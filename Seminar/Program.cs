// Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// Console.WriteLine("Введите трёхзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// if((n < 100) | (n > 999))  
//     {
//         Console.WriteLine("Не верно написано число");
//         return;
//     }
    
// int n1 = n/100;
// int n2 = n - n1*100;
// int n3 = n2 % 10;
// int n4 = n2 - n3;
// int n5 = n4 / 10;
// Console.WriteLine($"Вторая цифра {n5}");


//     Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if(n < 100) 
//     {
//        Console.WriteLine("Нет третьего числа");
//        return;
//     }
//  Console.WriteLine(n.ToString()[2]);





//        Задача 15
//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да  7 -> да   1 -> нет
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if((n >= 8) | (n <= 0))
//     {
//        Console.WriteLine("Нет такого дня в неделе");
//        return;
//     }
// if((n >= 1) & (n <=5))
//     {
//        Console.WriteLine("Нет, сегодня не выходной день");
//        return;
//     }    
// if((n >= 6) | (n <=7))
//     {
//        Console.WriteLine("Да, сегодня выходной день");
//        return;
//     }






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
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);

// if ((a%7 != 0) || (a%23 != 0))
// {
//     Console.WriteLine("Не делится");
// }
// else
// {
//     Console.WriteLine("Введёное число делится на 7 и на 23");
// }
