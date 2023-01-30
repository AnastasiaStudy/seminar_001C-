/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);

/*if (a > b) 
{
    int a = max;
    Console.WriteLine($"Максимальное число : {max} = {a}");
}
else 
{
   Console.WriteLine($"Максимальное число : {max} = {b}"); 
}
if (b > c)
{
    int b =  max;
    Console.WriteLine($"Максимальное число : {max} = {b}");
}
else 
{
    Console.WriteLine($"Максимальное число : {max} = {c}");
}
if (c > a)
{
    int c = max;
    Console.WriteLine($"Максимальное число : {max} = {c}");
}
else
{
    Console.WriteLine($"Максимальное число : {max} = {a}");
}
*/    



