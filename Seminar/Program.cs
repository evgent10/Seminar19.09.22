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







Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (b%a == 0)
{
    Console.Write("Кратно");
}
else
{
    int ost = b%a;
    Console.Write($"Не кратно, остаток {ost}");
}