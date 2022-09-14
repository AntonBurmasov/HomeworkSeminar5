// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Если в массив положить в том числе отрицательные вещественные числа, метод тоже будет работать.

int[] GetArray(int size, int leftRange, int RightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i =0; i < size; i++)
    {
        arr[i] =rand.Next(leftRange, RightRange + 1);

    }
    return arr;
}

int FindDifference(int[] arr)
{
int diff = 0;
int max = arr[0];
int min = arr[0];

for(int i = 0; i < arr.Length; i++)
{

if( max < arr[i])
{
  max = arr[i];  
}
if( min > arr[i])
{
min = arr[i]; 
}
}

diff = max - min;
return diff;
}



int[] array = GetArray(10, 1, 999);   
Console.WriteLine(string.Join(", ", array));

int FindDiff = FindDifference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {FindDiff}.");