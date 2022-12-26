                                                        //Программа выводит на экран таблицу простых чисел от 1 до заданного числа N

void IsPrime(int num)
{
    int count;

    count = 2;

    while (count <= num)
    {
        if (count == num)
        {
            System.Console.Write($"| {num} |");
            break;
        }
        else if (num % count == 0)
        {
            break;
        }
        else count++;
    }
}

void PrimesToN(int N)
{
    int iterator;

    iterator = 2;

    while (iterator <= N)
    {
        IsPrime(iterator);
        iterator++;        
    }
    
}

int N;

Console.Write("Введите число: ");
N = int.Parse(Console.ReadLine()!);

PrimesToN(N);