// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] fillArray(int num)
{
    int [] a = new int [num];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
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

int [] arr = fillArray (7);
printArray(arr);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Всего {arr.Length} чисел, {count} их них чётные.");