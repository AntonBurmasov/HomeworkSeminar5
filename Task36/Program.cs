// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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


int FindSummOfOddNumbers(int[] arr)
{
int sum = 0;
   for (int i = 0; i < arr.Length; i++)
   {
    if(i % 2 != 0)
    {
      sum = sum + arr[i];
    }
   }
    
return sum;
}


int[] array = GetArray(10, -10, 10);
Console.WriteLine(string.Join(", ", array));

int FindSum = FindSummOfOddNumbers(array);
Console.WriteLine($"Сумма всех элементов массива, расположенных на нечетных позициях = {FindSum}.");
