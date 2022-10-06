/* Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2 */


for (int i = 0; i < N; i++)
{
    Array[i] = new Random().Next(100,1000);
}


for (int i = 0; i < N; i++)
{
    Console.Write($"{Array[i]} ");
}
 Console.WriteLine();

int SumEvenNumbers (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < N; i++)
{
    if (Array[i] % 2 == 0)
    {
        sum = sum + Array[i];
    }   
}
return sum;
}

Console.WriteLine($"Сумма чётных чисел массива равна {SumEvenNumbers(Array)}");

