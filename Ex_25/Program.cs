/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int number(string num)
{
    Console.Write($"Введите число {num}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int A = number("A");
int B = number("B");

int pow = 1;
for(int i = 0; i < B; i++)
{
    pow = pow * A;
}
Console.WriteLine($"{A} ^ {B} = {pow}");
