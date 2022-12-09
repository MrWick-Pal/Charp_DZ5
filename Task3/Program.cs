// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] fillPrintArray(int num)
{
    double[] array = new double[num];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20) + new Random().NextDouble();
        Console.Write(Math.Round(array[i], 1) + "  ");
    }
    return array;
}
double maxMin (double [] arr)
{
    double max = arr [0];
    double min = arr [0];
    foreach (double n in arr)
    {
        if (n > max) max = n;
        if (n < min) min = n;
    }
    double diff = max - min;
    return Math.Round(diff, 1);
}

Console.WriteLine("Введите размер массива... ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = fillPrintArray(size);
Console.WriteLine();
Console.WriteLine($"Разница между макс. и мин. элементом массива = {maxMin(array)}.");