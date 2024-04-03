// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Каким будет размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(1, 101);
}

void CreateArray(int[] array, int i)
{
    if (i < array.Length)
    {
        Console.Write($"{array[i]} ");
       
        CreateArray(array, i + 1);
    }
    
}

void CreateReversArray(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write($"{array[i]} ");
        CreateReversArray(array, i - 1);
    }
    
}

Console.WriteLine("Изначальный массив: ");
CreateArray(array, 0);

Console.WriteLine();

Console.WriteLine("Обратный массив: ");
CreateReversArray(array, size - 1);