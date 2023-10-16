// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void PrintSequence (int N)
{
if (N==0)
{
    return;
}
Console.Write($"{N}\t");
PrintSequence (N-1);
}

Console.Write ("Введите чило N =");
int N = Convert.ToInt32 (Console.ReadLine());
PrintSequence (N);