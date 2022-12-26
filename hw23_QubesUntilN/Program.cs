                                    //Программа выводит таблицу значений от 1 до заданного числа N

void QubesToN(int N)
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

QubesToN(numN);