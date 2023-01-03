/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] numbers = new int[4];
FillRandomArray(numbers);
Console.WriteLine("This is your array: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i = i + 2)
{
    sum = sum + numbers[i];
}

Console.WriteLine($"Sum of elements in odd positions is = {sum}");