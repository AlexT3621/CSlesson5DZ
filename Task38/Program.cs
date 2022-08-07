/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.WriteLine("Enter the massive size");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];


int max = massive[0];
int dif = 0;


for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(2, 10);

    // if (massive[i] < min) min = massive[i];
    // if (massive[i] > max) max = massive[i];


}
int min = massive[0];
for (int i = 1; i < massive.Length; i++)
{
    if (massive[i] < min) min = massive[i];
    if (massive[i] > max) max = massive[i];
}


Console.WriteLine("Max=" + max);
Console.WriteLine("Min=" + min);

dif = max - min;

PrintArray(massive);
Console.WriteLine();
Console.Write("разница между max и min элементами = " + dif);

