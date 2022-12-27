                                        //Программа для проверки является ли число палиндромом.
                                        //сделана для обшего случая и прекрасно работает до достижения 9 значных чисел,
                                        //затем идёт переполнение в Pow
                                        
int ReverseNum (int num)
{
    int temp = num;
    int reverseNum = 0;
    while (temp != 0)
    {
        reverseNum = reverseNum * 10 + temp % 10;
        temp /= 10;
    }
    return reverseNum;
}

void Palindrom(int number)
{
    int reversed;
    reversed = ReverseNum(number);

    if (number == reversed)
    {
        Console.WriteLine("Данное число - палиндром");
    }
    else Console.WriteLine("Данное число - не является палиндромом");
}

int num;

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine()!);

Palindrom(num);


// int IsSimilar(int number)                           // очень громоздкая функция по сравнению каждой цифры с начала и с конца числа
// {
//     int count, check, frntDigit, backDigit, n;

//     n = (int)Math.Log10(number) + 1;
//     count = 1;
//     check = 0;

//      while (count <= n)
//     {
//         frntDigit = Convert.ToInt32(number / (Math.Pow(10, n-count)) % 10);                         // Взятие цифры в прямом порядке
//         backDigit = Convert.ToInt32(number % (Math.Pow(10, count)) / ((Math.Pow(10, count-1))));    // Взятие цифры в обратном порядке
//         if (frntDigit == backDigit)
//         {
//             check = 1;
//             count++;        
//         }
//         else 
//         {
//             check = -1;
//             break;
//         }
//     }

//     return check;
// }