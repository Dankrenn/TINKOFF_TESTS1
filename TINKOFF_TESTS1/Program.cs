using System;
//Задача
//Четыре человека выстроились в одну ширенгу ,определить стоят ли они по росту
//(неважно в порядке возрастания или убывания)
class Program
{
    public static bool prov(int[] mas)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] >= 0 && mas[i] <= 300)
            {
                if (i == mas.Length - 1)
                {
                    return true;
                }
            }
            if (mas[i] < 0 && mas[i] > 300)
            {
                return false;
            }

        }
        return false;
    }

    public static bool var(int[] mas)
    {
        int count = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (i + 1 <= mas.Length - 1)
            {
                if (mas[i] >= mas[i + 1])
                {
                    count++;
                    if (i + 1 == mas.Length - 1 && count == mas.Length - 1)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public static bool var2(int[] mas)
    {
        int count = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (i + 1 <= mas.Length - 1)
            {
                if (mas[i] <= mas[i + 1])
                {
                    count++;
                    if (i + 1 == mas.Length - 1 && count == mas.Length - 1)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        try
        {
            string str = Console.ReadLine();
            string[] ch = str.Split(' ');
            int[] mas = Array.ConvertAll(ch, s => int.Parse(s));
            if (prov(mas) == true)
            {
                if (var(mas) == false)
                {
                    if (var2(mas) == false)
                    {
                        Console.WriteLine("NO");
                    }
                    else if (var2(mas) == true)
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("Диапозон превышен");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Неверный формат");
        }
    }
}

