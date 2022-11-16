// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// double[] CreateArrayRndInt(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]} | ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine(" ]");
//}

// Console.WriteLine("Введите количество элементов массива");
// int length = Convert.ToInt32(Console.ReadLine());
// int minNum = 100;
// int maxNum = 999;
// //void PrintArray(double[] array)
// CreateArrayRndInt(length, minNum, maxNum);
// //double[] arr = CreateArrayRndDouble(leng, minimum, maximum);
// PrintArray(arr);
// // double result = DifferenceMaxMinNumberArray(arr);
// // double resultDiff = Math.Round(result, 1, MidpointRounding.ToEven);
// // double resultDiff = Math.Round(DifferenceMaxMinNumberArray(arr), 1, MidpointRounding.ToEven);

// Console.WriteLine($"Разница между минимальным и максимальным значениями массива -> {resultDiff}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} | ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ]");
}
double MaxNumArray(double[] array)
{
    double maxNum = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (array[i] > maxNum) maxNum = array[i];
        i++;
    }
    return maxNum;
}
double MinNumArray(double[] array)
{
    double minNum = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (array[i] < minNum) minNum = array[i];
        i++;
    }
    return minNum;
}
double DiffMaxMinNumArray(double[] array)
{
    double difference = MaxNumArray(array) - MinNumArray(array);
    return difference;
}
Console.WriteLine("Введите количество элементов массива");
int leng = Convert.ToInt32(Console.ReadLine());
int minNum = -10;
int maxNum = 11;

double[] arr = CreateArrayRndDouble(leng, minNum, maxNum);
PrintArray(arr);
double result = DiffMaxMinNumArray(arr);
double resultDiff = Math.Round(result, 1, MidpointRounding.ToEven);
double resultDiffer = Math.Round(DiffMaxMinNumArray(arr), 1, MidpointRounding.ToEven);

Console.WriteLine($"Разница между минимальным и максимальным значениями массива равна {resultDiff}");