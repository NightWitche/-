// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine($"Введите количество элементов массива:\t");  
int lengthOfArray = Convert.ToInt32(Console.ReadLine());  
string[] array = CreateStrArray(lengthOfArray);  
 
int maxLenght = 3; 
  
string[] CreateStrArray(int length)  
{  
    string[] arr = new string[length];  
  
    Console.WriteLine($"Введите элементы массива:");  
  
    for (int i = 0; i < length; i++)  
    {  
        arr[i] = Console.ReadLine()!;  
    }  
  
    return arr;  
} 
 
string[] GetShortWordsArray(string[] array) 
{ 
    int length = array.Length; 
    string[] result = new string[length]; 
    int count = 0; 
 
    for (int i = 0; i < length; i++) 
    { 
        if (array[i].Length <= maxLenght) 
        { 
            result[count] = array[i]; 
            count++; 
        } 
    } 
    Array.Resize(ref result, count); 
 
    return result; 
} 
 
void PrintArray(string[] array) 
{ 
    if (array.Length == 0) 
    { 
        Console.WriteLine("Array is empty"); 
    } 
    else 
    { 
        Array.ForEach(array, (str) => Console.Write($"{str} ")); 
        Console.WriteLine(); 
    } 
} 
 
void PrintTask(string[] array) 
{ 
    Console.WriteLine("\nИсходный массив:\n"); 
    PrintArray(array); 
    string[] shortArray = GetShortWordsArray(array); 
    Console.WriteLine($"\nРезультат (элементы длиной менее или равной {maxLenght} символам):\n"); 
    PrintArray(shortArray); 
    Console.WriteLine(); 
} 
 
PrintTask(array);