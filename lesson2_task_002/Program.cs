﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int enteredNumber = NumberRequest("Enter number: ");

while (enteredNumber <= 100); 
  if (enteredNumber >999)
{
    enteredNumber = enteredNumber / 10;
    result = enteredNumber % 10;
    return result;
    {
        Console.WriteLine($"Третья цифра : {result} ");
    }
}

  else
{
    Console.WriteLine("Третьей цифры нет");
}


