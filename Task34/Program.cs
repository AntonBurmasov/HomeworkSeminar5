// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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


int EvenNumbersInArray(int[] arr)
{
   int count = 0;
  for(int i =0; i < arr.Length; i++)
  {
    if(arr[i] % 2 == 0)
    {
        count++;
    }
   

  }

return count;
}


int[] array = GetArray(10, 100, 999);

Console.WriteLine(string.Join(", ", array));

int ShowCountofEvenNumbered = EvenNumbersInArray(array);

Console.WriteLine($"Количество четных элементов в массиве = {ShowCountofEvenNumbered}.");

