/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не натурально число";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}


int numberA = GetNumber("Введите число A");
int numberB = GetNumber("Введите число B");
int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine($"{numberA} в степени {numberB} = {result}");
