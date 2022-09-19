int a =new Random().Next(100,1000);
Console.WriteLine(a);
int c = 0; // первое число
int b = 0; //последнее

c = a/100 *10;
 int c1 = a/100;
b = a%10;

int sum = c+b;
Console.WriteLine($"{c1} {b}");
Console.WriteLine(sum);