/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }

    return result;
}

int[] array = InitArray(10);
PrintArray(array);
int[] result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result);

PrintArray(result);

/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}


void CheckSide (int a, int b, int c)
{
    if (a+b>c&&a+c>b&&b+c>a)
    {
        Console.WriteLine("Треугольник существует");
    }
    else Console.WriteLine ("Треугольник не существует");
    
}
int a = GetNumber ("Введите первое число: ");
int b = GetNumber ("Введите второе число: ");
int c = GetNumber ("Введите третье число: ");
CheckSide (a,b,c);

/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0 )
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

void NumberTranslate(int number)
{
    string result = string.Empty; 
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2; 
    }

    Console.WriteLine(result);
}

int result = GetNumber("Введите десятичное число: ");
NumberTranslate(result);

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result ) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено неверное число! Повторите ввод!");
        }
    }

    return result;
}

void FibonacciNumber(int number)
{
    int fibNumberOne = 0;
    int fibNumberTwo = 1;
    int SumNumber = 0;

    if (number == 1)
    {
        fibNumberTwo = 0;
        Console.WriteLine(fibNumberTwo);
    }
    else 
    {
        fibNumberTwo = 1;
        Console.Write("0 1 ");
        for (int i = 0; i < number-2; i++)
        {
            SumNumber = fibNumberOne + fibNumberTwo;
            fibNumberOne = fibNumberTwo;
            fibNumberTwo = SumNumber;
            Console.Write($"{SumNumber} ");
        }
    }   


} 

int result = GetNumber("ВВедите положительное число: ");
FibonacciNumber(result);