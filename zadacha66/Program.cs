// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int SumNaturalNumbersInInterval(int start, int end)
{
    if (start == end)
        return start;
    else
    {
        return start + SumNaturalNumbersInInterval(start + 1, end);
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.Write("Введите число N: ");
int num2 = InputNumber();
if(num1 > num2) (num1, num2) = (num2, num1);
Console.WriteLine(SumNaturalNumbersInInterval(num1, num2));;
