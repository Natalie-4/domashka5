/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите число элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] Array = new double[N];
for (int i = 0; i < N; i++)
{
    Array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("[" + string.Join("; ", Array) + "]");

double FindMinNumber (double [] array)
{
    double min = array[0];
    
    for (int i = 1; i < N; i++)
    {
        if (array[i] < min)
        min = array [i];
    }
return min;
//Console.WriteLine($"Минимальное значение равно{min}");
}

double FindMaxNumber (double [] array)
{
    double max = array[0];
    
    for (int i = 1; i < N; i++)
    {
        if (array[i] > max)
        max = array [i];
    }
return max;
}

//Console.WriteLine(FindMinNumber(Array));
//Console.WriteLine(FindMaxNumber(Array));

double Delta (double x, double y)
{
    double delta = 0;
    if (x>y)
    delta = x - y;
    else delta = y - x;
    return delta;
}

Console.WriteLine("Разница между максимальным и минимальным элементов массива равна ");
Console.WriteLine(Delta(FindMinNumber(Array),FindMaxNumber(Array)));