// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] fillArray(int num)
{
    int [] a = new int [num];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 20);
    }
    return a;
}
void printArray(int [] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
}

int [] arr = fillArray(12);
printArray(arr);
int sum = 0;
for (int i = 1; i < arr.Length; i = i + 2)
{
    sum = sum + arr[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");