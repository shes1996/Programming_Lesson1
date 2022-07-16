/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*Console.WriteLine("Введите два числа через Enter ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine("max="+ a);
else Console.WriteLine("max="+ b);
*/

/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Введите три числа через Enter ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a > b && a > c) 
{
    Console.WriteLine("max="+ a);
}
else if (b > c) 
{
    Console.WriteLine("max="+ b);
}
else Console.WriteLine("max="+ c);
*/



/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0) 
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
*/


/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число больше 1");
int N = int.Parse(Console.ReadLine());
if (N<0)
{
    Console.WriteLine("Введенное число не удовлетворяет условиям");
}
else
{
for (int i = 2; i<=(N-2); i+=2)
{
    Console.Write(i+ ", ");
}   
if (N % 2 == 0)
{
    Console.Write(N);
}
else Console.Write(N-1);
}