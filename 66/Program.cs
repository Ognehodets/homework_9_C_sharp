// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumSequence(int M, int N)
{
    if (N == M - 1)
    {
        return 0;
    }
    return N + SumSequence(M, N - 1);
}

Console.Write("Введите чило M =");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N =");
int N = Convert.ToInt32(Console.ReadLine());
if (N > M)
{
    Console.WriteLine($"Сумма целых чисел от {M} до {N} равна {SumSequence(M, N)}");
}
else
{
    Console.WriteLine($"Сумма целых чисел от {N} до {M} равна {SumSequence(N, M)}");
}

