// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int M = 1;
int N = 10; 
        
PrintNumbers(M, N);
    

    void PrintNumbers(int current, int end)
    {
        if (current > end)
        {
            return;
        }
        
        Console.WriteLine(current);
        PrintNumbers(current + 1, end);
    }

/////////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 2;
int n = 3;
        
int result = Ackermann(m, n);
Console.WriteLine($"Ackermann ({m}, {n}) = {result}");
    

    int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

//////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 1, 2, 3, 4, 5 };

PrintArrayReverse(array, array.Length - 1);
    

    void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
