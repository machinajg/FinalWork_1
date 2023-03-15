// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(string[] coll, string[] arr)
{
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i].Length <= 3)
            arr[i] = coll[i];
    }
}
void PrintArray(string[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write($"{coll[i]} ");
    }
    Console.WriteLine();
}





string[] collection = { "gig", "brains", "home", "work", "GB", "#@", ";)" };
string[] array = new string[collection.Length];

