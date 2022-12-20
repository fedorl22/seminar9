// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

// A(n, m) = {m+1, если n=0; A(n-1,1),если n!=0,m=0; A(n-1,A(n,m-1)),если n>0,m>0.
// A(0, 0) = 1
// A(0, 1) = 2
// A(1, 2) = 4
// A(2, 2) = 7
// A(2,3) = 9

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

int Akerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
    else
      return Akerman(n - 1, Akerman(n, m - 1));
}
Console.Write(Akerman(n,m));

