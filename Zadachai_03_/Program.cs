// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateArrey(int min, int max, int size)
{
    double [] array = new double [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = (new Random().Next(min, max+1) * (new Random().NextDouble()));
    }
    return array;
}

void PrintArrey(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMax(double [] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
         {
            max = arr [i];
         }
    }
    Console.WriteLine($"Максимальный элемент масива: {max}");
    return max;
}
double FindMin(double [] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
         {
            min = arr [i];
         }
    }
    Console.WriteLine($"Минимальный элемент масива: {min}");
    return min;
}


Console.Write("Enter array size: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array min: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array max: ");
int mx = Convert.ToInt32(Console.ReadLine());

double [] array = CreateArrey(mn, mx, s);
Console.WriteLine();
PrintArrey(array);
Console.WriteLine();
Console.WriteLine($"Разницу между максимальным и минимальным: {FindMax(array) - FindMin(array)}");
