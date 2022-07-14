void Zad34()
{   
    int[] array = new int[8];

    array = FillArray(array);
    PrintArray(array);
    Console.WriteLine($"количество четных чисел в массиве: {FindSum(array)}");
}

int[] FillArray(int[] array)
{
    Random rand = new Random();    
    for(int i = 0; i < array.Length; i++) array[i] = rand.Next(100, 1000);

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for( int i = 0; i<array.Length; i++ )
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}




void Zad36()
{   
    int[] array = new int[8];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine($"Cумма чисел на нечётных позициях: {FindSum(array)}");
}

int[] FillArray(int[] array)
{
    Random rand = new Random();    
    for(int i = 0; i < array.Length; i++) array[i] = rand.Next(0, 10);

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}

int FindSum(int[] array)
{
    int sum = 0;
    for( int i = 0; i<array.Length; i++ )
    {
        if (i%2==0)
        {
            sum+=array[i];
        }
    }
    return sum;
}



void Zad38()
{
Random random = new Random();
double [] array = new double [10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(random.NextDouble()*10, 2);
}

Console.WriteLine("Вывод массива");
for(int i = 0; i < array.Length; i++)
{
Console.Write( array[i] + "\t");
}
Console.WriteLine();

double max = array[0];
double min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] <min) min = array[i];
}

Console.WriteLine("Минимальное знаечение равно" + min);
Console.WriteLine("Максимальное знаечение равно" + max);
Console.WriteLine("Их разница равна " + (max - min));
}

Zad38();