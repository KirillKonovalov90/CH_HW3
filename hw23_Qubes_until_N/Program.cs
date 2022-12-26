void Qubes_to_N(int N)
{
    int count;

    count = 1;
    
    while(count <= N)
    {
        Console.Write($"|  {count*count*count}  |");
        count++;
    }
}

int numN;

Console.Write("Введите число N: ");
numN = int.Parse(Console.ReadLine()!);

Qubes_to_N(numN);