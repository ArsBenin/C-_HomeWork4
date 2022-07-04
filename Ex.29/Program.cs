/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


Random rnd = new Random();
int [] array = new int [8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
}
    Console.Write("[");
for(int i = 0; i < (array.Length-1); i++)
{
    Console.Write($"{array[i]}, ");
}

    Console.Write($"{array[array.Length-1]}]");


/*
int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите колличество элементов массива:");
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

int j = GetNumber();

Random rnd = new Random();
int [] array = new int [j];

for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
}
    Console.Write("[");
for(int i = 0; i < (array.Length-1); i++)
{
    Console.Write($"{array[i]}, ");
}

    Console.Write($"{array[array.Length-1]}]");
*/