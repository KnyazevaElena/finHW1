//Написать программу, которая их имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа.
//Первоначальный массив можно ввести через клавиатуру, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Clear();
string[] StartArray = new string[4] {"hello", "2", "world", ":-)"};
Console.WriteLine(String.Join(", ", StartArray));
string[] NewArray = new string[StartArray.Length];
void FindSymbol (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}
FindSymbol(StartArray, NewArray);
PrintArray(NewArray);
