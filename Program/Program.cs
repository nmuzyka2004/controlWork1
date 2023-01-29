/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна три символа. Первонаальный массив можно ввести с клавиатуры, либо задать на старте 
ввыполнения алгоритма.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["Russia", "Denmark", "Kazan"] -> []
*/
//Метод создания массива строк
string[] InitArray(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine()??"";
    string[] array = str.Split(',');
    return array;
}

//Метод подсчета элементов заданного массива с количеством символов 3 и менее
int GetCountElements(string[] array)
{
    int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}    

//Метод создания нового массива из элементов заданного массива, в которых количество символов 3 и менее
string[] GetNewArray(string[] array, int count)
{
    int j = 0;
    string[]arrayNew = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j++;

        }
            
    }
    return arrayNew;
}

//Метод вывода массива
void PrintArray(string[] array)
{
    if (array.Length == 0)
        Console.WriteLine($"[]");
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}
string[] arr = InitArray("Введите элементы массива через запятую:");
int number = GetCountElements(arr);
string[] arrNew = GetNewArray(arr, number);
PrintArray(arrNew);



