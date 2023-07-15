// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа. 
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трёхзначное число ");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 1000)
{
    Console.WriteLine("вы ввели не трёхзначное число, повторите"); 
}

int GetSecondDigit(int number)
{
    return (number / 10)%10;
}
void PrintNumber(int num2)
{
Console.Write(num2);
}
int secondDigit = GetSecondDigit(num);
PrintNumber(secondDigit);