//Напишите программу которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Square(int a, int b )
{
    int result = 1;
    for(int i = 1; i <= b; i++)
        result *= a;
    return result;
}

Console.Write("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(a,b));
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int number)
{
    int result = 0;
    int current = 0;
    while(number > 0)
    {
        current = number % 10;
        result = result + current;
        number = number / 10;
        current++;
    }
    return result;
}

Console.Write("Input number: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.Write(Sum(numb));
*/

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray() 

 {
    Console.Write("Введите количество элементов масива:   ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] myArray = new int[m];
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент масива под индексом {i}:  ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine();    
}
int[] newArray = CreateArray();
ShowArray(newArray);
*/