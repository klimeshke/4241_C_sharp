//Заполнение массива элементами(МЕТОД)
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    { 
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//Распечатывание массива(МЕТОД)
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//Персчет индексов, основное решение(МЕТОД)
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Определение массива из 10 элементов
int[] array = new int[10];

// Вызовы методов
FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);