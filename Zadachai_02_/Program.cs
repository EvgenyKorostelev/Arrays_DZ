//Задайте массив на 10 целых чисел. Напишите программу,
//которая определяет количество чётных чисел в массиве.

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
        if (arr[i] % 2 == 0)
         {
            count++;
         }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
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
