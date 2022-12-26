                                        //Программа для проверки является ли число палиндромом.
                                        //сделана для обшего случая и прекрасно работает до достижения 9 значных чисел,
                                        //затем идёт переполнение где-то, как Я понял,
                                        //замена `int` значений на `long` не решила проблему
void Palindrom(int number)
{
    int n, count, check, frntDigit, backDigit;
    
    n = (int)Math.Log10(number) + 1;
    count = 1;
    check = 0;                          

    while (count <= n)
    {
        frntDigit = Convert.ToInt32(number / (Math.Pow(10, n-count)) % 10);                         // Взятие цифры в прямом порядке
        backDigit = Convert.ToInt32(number % (Math.Pow(10, count)) / ((Math.Pow(10, count-1))));    // Взятие цифры в обратном порядке
        if (frntDigit == backDigit)
        {
            check = 1;
            count++;        
        }
        else 
        {
            check = -1;
            break;
        }
    }
        
    if (check > 0)
    {
        Console.WriteLine("Данное число - палиндром");
    }
    else Console.WriteLine("Данное число - не является палиндромом");
}

int num;

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine()!);

Palindrom(num);