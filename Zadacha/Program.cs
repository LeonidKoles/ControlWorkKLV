void Zadacha()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] arrayStart = new string[n];
    Console.WriteLine("Заполните массив через ENTER.");
    FillArray(arrayStart);
    PrintArray(arrayStart);
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            count ++;
        }
    }
    string[] arrayFinish = new string[count];
    int ind = 0;
    for (int i = 0; i < n; i++)
    {
        if (arrayStart[i].Length <= 3 && arrayStart[i].Length != 0)
        {
            arrayFinish[ind] = arrayStart[i];
            ind++;
        }
    }
    Console.WriteLine();
    PrintArray(arrayFinish);
}
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}
Zadacha();