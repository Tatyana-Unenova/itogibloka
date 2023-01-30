// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];
FillArray(array, N);
Console.WriteLine();
VyborArray(array, N);

void FillArray(string[] array, int N)
{
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку ");
        array[i] = Console.ReadLine();
    }
}

void VyborArray(string[] array, int N)
{
    int a = -1;
    for (int i = 0; i < N; i++)
    {
        if (array[i].Length <= 3)
        {
            a++;
            Console.WriteLine(array[i]);
        }
    }
    if (a == -1)
        Console.WriteLine("Таких строк нет");
}
