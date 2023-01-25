// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
    
    int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
// Функия вывода массива
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
//функция поиска макс числа
    int MaxNum(int[] array){
      int max = array[0];
      for(int i=0; i < array.Length; i++)
    {
      if (array[i]>max)
      {
       max = array[i];
      }
    }
      return max;
      }

//функция поиска мин числа
    int MinNum(int[] array){
      int min = array[0];
      for(int i=0; i < array.Length; i++)
    {
      if (array[i]<min)
      {
       min = array[i];
      }
    }
      return min;
      }
    
    int[] array = CreateRandomArray (5,0,100);



    int max = MaxNum(array);
    int min = MinNum(array);
    

ShowArray(array);
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max-min);

// цум