/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int enteredNumber = NumberRequest("Введите число: ");



if (enteredNumber % 2 == 0 )
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}