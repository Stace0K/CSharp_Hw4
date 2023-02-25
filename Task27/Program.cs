// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int Number(string arg)
{
    Console.Write(arg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Sum(int numb)
{
    int result = 0;
    while (numb > 0)
    {
        result += numb % 10;
        numb = numb / 10;
    }
    return result;
}

int n = Number("Введите число: ");
int res = Sum(n);
Console.WriteLine("Сумма цифр равна " + res);