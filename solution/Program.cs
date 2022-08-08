// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
//равна 3 символа. Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[5] { "cat", "hahaha", ";)", "kitty", "12" }; 
string[] SortedArray = new string[array.Length]; 

void ArraySorting(string[] array, string[] SortedArray) 
{
    int count = 0; 

    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length <= 3) 
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ArraySorting(array, SortedArray);
PrintArray(SortedArray); //вывод отсортированного массива