/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/

Console.Clear();
int m = ReadNumber("Введите m: ");
int n = ReadNumber("Введите n: ");

if (m >= 0 & n >= 0)
{
    int functionAkkerman = Akkerman(m, n);
    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 & n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {functionAkkerman}");
}
else
{
    Console.WriteLine("Введите положительные числа!");
}


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}