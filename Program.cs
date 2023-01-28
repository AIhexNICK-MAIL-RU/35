/* Задача 35: Задайте одномерный массив из 123 
случайных чисел.
Найдите количество элементов массива, значения 
которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5  */

int[] array = new int[15];
FillArray(array);
//Console.Write()
int count = CountNumberRange(array);
PrintArray(array);
Console.WriteLine(count);
int CountNumberRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 & array[i] >= 10)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
}