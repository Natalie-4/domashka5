/*  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите число элементов:");
int N = Convert.ToInt32(Console.ReadLine());
int [] Array = new int[N];

for (int i = 0; i < Array.Length; i ++)
{
    Array[i] = new Random().Next(-100, 101);
}

Console.WriteLine("[" + string.Join(", ", Array) + "]");


int SummaUnevenPositions (int [] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
{
   
    if (i % 2 == 1)
    {
        summa = summa + array[i];
    }
}
return summa;
}

Console.Write("Сумма элементов на нечётных позициях равна: ");
Console.WriteLine(SummaUnevenPositions(Array));

