//                       Задача 68

//   Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void FunctionAkkerman(int num1, int num2)
{
    Console.Write(Akkerman(num1, num2));
}

int Akkerman(int num1, int num2)
{
    if (num1 == 0) 
    return num2 + 1;

    else if (num2 == 0 && num1 > 0) 
    return Akkerman(num1 - 1, 1);

    else 
    return (Akkerman(num1 - 1, Akkerman(num1, num2 - 1)));
}
FunctionAkkerman(num1, num2);