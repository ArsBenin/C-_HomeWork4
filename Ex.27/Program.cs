/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не натурально число. Введите корректное число");
        }
    }

    return result;
}

int GetSumm(int number)
{
int result = 0;
while(number>0)
{
    result=result+(number%10);
    number=number/10;
}
return result;
}

int number = GetNumber();
int result = GetSumm(number);

Console.WriteLine($"Сумма цифр числа {number} = {result}");