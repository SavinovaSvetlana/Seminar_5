// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
}

int[] array = GetArray(5, 0, 4);

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("[ ");
PrintArray(array);
Console.Write("]");

int i = 0;
int count = 0;
while (i < array.Length)
{
    if (a == array[i])
    {
        count++;
    }
    i++;
}
if (count == 0)
{
    Console.Write(" Нет");
}
else
{
    Console.Write(" Да");
}




