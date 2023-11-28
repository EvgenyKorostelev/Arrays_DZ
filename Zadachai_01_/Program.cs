// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90]. 

int [] CreateArrey(int min, int max, int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArrey(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Func(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 20 & arr[i] <= 90)
         {
            count++;
         }
    }
    Console.WriteLine($"Количество элементов массива в отрезке [20,90]: {count}");
}

Console.WriteLine("Enter array size");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int mx = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArrey(mn, mx, s);
PrintArrey(array);
Func(array);