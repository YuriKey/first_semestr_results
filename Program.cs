int CountArray(string[] Array, int Sym)
{
    int res = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= Sym)
        {
            res++;
        }
    }
    return res;
}

string[] ReduceArray(string[] Array, int Sym, int sizeNewArray)
{
    string[] ResultArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= Sym)
        {
            ResultArray[j] = Array[i];
            j++;
        }
    }

    return ResultArray;
}

Console.Clear();
Console.WriteLine("Введите данные через запятую и пробел: ");
string row = Console.ReadLine()!;
Console.Write("Введите искомое количество символов: ");
int N = int.Parse(Console.ReadLine()!);

string[] nums = row.Split(", ", StringSplitOptions.RemoveEmptyEntries);
int size = CountArray(nums, N);

Console.WriteLine();
Console.Write($"Массив с элементами меньше {N} символов: [");
Console.Write(String.Join(", ", ReduceArray(nums, N, size)));
Console.Write("]");