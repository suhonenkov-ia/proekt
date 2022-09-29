Console.WriteLine("выберете программу которую хотите запустить");
Console.WriteLine("1.Угадай число");
Console.WriteLine("2.Вывод делитей числа");
Console.WriteLine("3.Закрыть программу");
int operathion = Convert.ToInt32(Console.ReadLine());
while (operathion != 3)
{
    if (operathion == 1)
    {
        Random rnd1 = new Random();
        int a = rnd1.Next(100);
        Console.WriteLine("Введите число");
        int b = Convert.ToInt32(Console.ReadLine());
        while (a != b)
        {
            if (a > b)
            {
                Console.WriteLine("добавляй");
            }
            else
            {
                Console.WriteLine("меньше");
            }
            int d = Convert.ToInt32(Console.ReadLine());
            b = d;
        }
        Console.WriteLine("вы угадали число, это число:");
        Console.WriteLine(a);

    }
    if (operathion == 2)
    {
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            if ((a % i) == 0)
                Console.WriteLine(i);
        }

    }
    Console.WriteLine("Выберете программу которую хотите запустить?");
    int operathion_2 = Convert.ToInt32(Console.ReadLine());
    operathion = operathion_2;
}
//третью программу не получилось сделать, потому что не разобрался с матрицей.