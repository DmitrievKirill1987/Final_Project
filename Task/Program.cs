string[] ReadArrStr(string text)
{
    Console.Write(text);
    return Console.ReadLine().Split(", ");
}

void PrintArr(string[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void PrintArr3Chars(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($" {array[i]},");
        }
    }
    Console.WriteLine("]");
}

string[] str = ReadArrStr("Введите массив строк через запятую: ");
PrintArr(str);
PrintArr3Chars(str);