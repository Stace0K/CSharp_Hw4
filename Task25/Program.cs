// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Number(string arg)
{
    Console.Write(arg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Power(int figure, int p)
{
    int power = 1;
    for (int i = 0; i < p; i++)
    {
        power *= figure;
    }
    return power;
}

int number = Number("Введите основание (число): ");
int p = Number("Введите степень числа: ");
int result = Power(number, p);
Console.WriteLine(result);
