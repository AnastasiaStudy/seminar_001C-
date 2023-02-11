/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = NumberRequest("Введите пятизначное число: ");

int temp = number;
int rev = 0;
while (number > 0)
{
    int dig = number % 10;
    rev = rev * 10 + dig;
    number = number / 10;
}

if (temp == rev)
{
    Console.WriteLine($"Число {temp} это палиндром");
}
else 
{
    Console.WriteLine($"Число {temp} не палиндром" );
}