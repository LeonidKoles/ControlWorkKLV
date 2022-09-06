void Zadacha()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[n];
    Console.WriteLine("Заполните массив через 'пробел'");
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine();
    }
    for (int i = 0; i < n; i++)
    {
        Console.Write(array[i] + "\t");
    }



}
Zadacha();