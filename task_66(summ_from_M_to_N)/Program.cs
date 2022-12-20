// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int SumFromMToN(int number1, int number2)
{
    int sum = number1;
    if (number1 == number2 - 1)
    {
        return 0;
    }
    else
        sum += SumFromMToN(number1 - 1, number2);
        number1--;
    return sum;
}
SumFromMToN(n, m);
Console.Write(SumFromMToN(n, m));