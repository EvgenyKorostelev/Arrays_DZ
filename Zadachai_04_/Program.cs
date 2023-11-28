// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
// Размер массива должен быть равен количеству цифр.

void Func(int num)
{
  int count = 0;
  int num1 = num;

  while (num1 != 0)
  {
    num1 = num1 / 10;
    count++;
  }
  int[] array = new int[count];

  for (int i = 0; i < count; i++)
  {
    array[i] = num % 10;
    num /= 10;
  }
  for(int j = count - 1; j >= 0; j--)
  {
    Console.Write(array[j] + " ");
  }
}

Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
int numV = Convert.ToInt32(Console.ReadLine());

Func(numV);
