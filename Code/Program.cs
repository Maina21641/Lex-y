// Создаем строковый массив из 4-х конкретных элементов
string[] startArray = new string[4] {"hello", "2", "world", ":-)"};
string[] endArray = new string[startArray.Length];
// Создаем цикл, в котором отбираем элементы из массива с тремя и менее символами
void Selection(string[] startArray, string[] endArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
            endArray[count] = startArray[i];
            count++;
        }
    }
}
// Печатаем массив
void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
// Выводим результат в консоль
Selection(startArray, endArray);
Print(endArray);
