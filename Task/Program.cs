string[] ReadArrStr(string text)
{
    Console.Write(text);
    return Console.ReadLine().Split(' ');
}

void PrintArr(string[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

string[] str = ReadArrStr("Введите массив строк: ");
PrintArr(str);