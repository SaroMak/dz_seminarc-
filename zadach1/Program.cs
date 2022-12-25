// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void NumberPlus(int num, int count)
{
    if (count >= 1)
    {
        System.Console.Write(count + " ");
        count--;
        NumberPlus(num, count);
    }
}
int number = AddNumber("Введите число");
int count = number;
NumberPlus(number, count);