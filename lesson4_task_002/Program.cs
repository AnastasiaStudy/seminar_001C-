﻿/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


int GetNumber(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}


int GetSumOfDigits(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = GetNumber("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {number} = {GetSumOfDigits(number)}");






