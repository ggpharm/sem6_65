// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int inpuNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNum(int n, int m)
{   
    if (n > m) return 0;
    return m + SumNum(n, --m);
}

int numN = inpuNum("Введите N: ");
int numM = inpuNum("Введите M: ");
int result = SumNum(numN, numM);

Console.WriteLine("");
if (result == 0) 
    Console.WriteLine("Первое число должно быть больше.");
else
    Console.WriteLine("Сумма натуральных элементов в промежутке от N до M: " + result);