// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());
// if (M<N)
//     Console.WriteLine(PrintNumbers(M, N));

// else
//     System.Console.WriteLine("Введите другие входные данные");

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start + 1, end));
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m=int.Parse(Console.ReadLine());
// int n=int.Parse(Console.ReadLine());
// if (m<n)
//     System.Console.WriteLine(SumNumber(m,n));
// else
//     System.Console.WriteLine("Введите другие входные данные");
// int SumNumber(int firstNumber, int secondNumber){
//     if(firstNumber==secondNumber) return secondNumber;
//     return (firstNumber+SumNumber(firstNumber+1,secondNumber));
// }    



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int m=int.Parse(Console.ReadLine());
int n=int.Parse(Console.ReadLine());

System.Console.WriteLine(FunctionAkkerman(m,n)); 

int FunctionAkkerman(int firstNumber,int secondNumber){
    if(firstNumber==0) 
        return secondNumber+1;
    if(firstNumber>0 && secondNumber==0) 
        return FunctionAkkerman(firstNumber-1,1);
    // if(firstNumber>0 && secondNumber>0) 
    return FunctionAkkerman(firstNumber-1,FunctionAkkerman(firstNumber,secondNumber-1));
}

