/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

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
int count = 0;


for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(100, 1000);
    if (massive[i] % 2 == 0) count = count + 1;

}

PrintArray(massive);
Console.WriteLine();
Console.Write("Колличестов четных чисел = " + count);