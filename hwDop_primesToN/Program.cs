                                                        //Программа выводит на экран таблицу простых чисел от 1 до заданного числа N

bool IsPrime(int num)
{
    int count;
    bool check;

    count = 2;
    check = false ;

    while (count <= num)
    {
        if (count == num)
        {
            check = true;
            break;
        }
        else if (num % count == 0)
        {
            break;
        }
        else 
        {
            count++;
        }
    }
    return check;
}

void PrimesToN(int numN)
{
    int iterator;

    iterator = 2;

    while (iterator <= numN)
    {
        if (IsPrime(iterator) == true)
        {
            System.Console.Write($"| {iterator} |");
        }
        iterator++;        
    }
    
}

int numN;

Console.Write("Введите число: ");
numN = int.Parse(Console.ReadLine()!);

PrimesToN(numN);