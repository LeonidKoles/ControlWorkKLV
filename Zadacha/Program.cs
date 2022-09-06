void Zadacha()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] arrayStart = new string[n];
    Console.WriteLine("Заполните массив через ENTER.");
    for (int i = 0; i < n; i++)
    {
        arrayStart[i] = Console.ReadLine();
    }
    for (int i = 0; i < n; i++)
    {
        Console.Write(arrayStart[i] + "\t");
    }
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            count += 1;
        }

    }
    string[] arrayFinish = new string[count];
    int ind = 0;
    for (int i = 0; i < n; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            arrayFinish[ind] = arrayStart[i];
            ind++;
        }

    }
    Console.WriteLine();
    for (int i = 0; i < count; i++)
    {
        Console.Write(arrayFinish[i] + "\t");
    }
}
Zadacha();determining the size of the final array, its creation and filling