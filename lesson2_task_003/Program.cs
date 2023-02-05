/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int enteredNumber = NumberRequest("Введите цифру,  обозначающую день недели: ");



if (enteredNumber > 5 && enteredNumber <= 7)
{
    Console.WriteLine("Да, это выходной день!");
}
else
{
    Console.WriteLine("Нет, это рабочий день((");
}