//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 
Console.Clear();
int number = ReadNumber("Введите N: ");
int count = 2;
Console.Write("N = " + number + " -> ");
PrintNumber(number, count);


void PrintNumber(int number, int count)
{
    if (count > number)
    {   
        return;
    }
    else
    {
        PrintNumber(number, count + 1);
        Console.Write($"{count}, ");
    }
}

if(number >= 1){
    Console.Write(1);
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
