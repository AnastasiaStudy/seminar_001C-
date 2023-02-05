/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Random rnd = new Random();
    int result =  rnd.Next(100, 1000);
    return result;
}

int DeliteFirstandThirdNumber (int number)

{
    int firstDigit = number / 10;
    int secondDigit = firstDigit % 10;
    return secondDigit;
}
int number = GetNumber();
int result = DeliteFirstandThirdNumber(number);

Console.WriteLine($"Второе число из {number} = {result}");