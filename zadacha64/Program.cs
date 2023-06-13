// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NatureNumNToOne(int start, int end = 1){
     if (start == end)
        Console.Write($"{start} ");
    else
    {
        NatureNumNToOne(start, end + 1);
        Console.Write($"{end} ");
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
NatureNumNToOne(num1);