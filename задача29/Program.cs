void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    collection[index] = Convert.ToInt32(Console.ReadLine());
    while (index < length)
    {
       collection[index] = // new Random().Next(); по идее где-то в этом месте нужно заставить систему считать данные, введенные пользователем, вместо Random
       index++; 
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
      Console.WriteLine(coll[position]);
      position++;  
    }
}
int[] array = new int[8];

FillArray(array);
PrintArray(array);