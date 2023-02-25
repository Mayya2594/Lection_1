void FillArray(int[] collection) // метод для создания массива из 10 случайных чисел
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        // присвоить элементу случайное значение от 1 до 10 (НЕ вклачая 10, т.е. фактически от 1 до 9)
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) // метод для распечатывания массива

// void - ключевое слово для обозначения метода, который ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int [] array = new int [10]; // команда "создай новый массив из 10 элементов", по умолчанию все элементы = 0

FillArray(array);
PrintArray(array);