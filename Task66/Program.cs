/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int m = ReadNumber("Введите m: ");
int n = ReadNumber("Введите n: ");
int temp = m;

// Защита, на тот случай если диапозон зададут от большего к меньшему
if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
