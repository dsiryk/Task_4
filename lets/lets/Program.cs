using System;

class Sad
{
    static int vvod()
    {
        Console.WriteLine("Введіть число, де 1 - Ножиці, 2 - Бумага, 3 - Камінь:");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int casino()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }

    static void Main(string[] args)
    {
        int I = vvod();
        int comp = casino();

        // 1 - Ножиці, 2 - Бумага, 3 - Камінь
        string lud = I switch
        {
            1 => "Ножиці",
            2 => "Бумага",
            3 => "Камінь",
            _ => "Невідомо"
        };

        string pk = comp switch
        {
            1 => "Ножиці",
            2 => "Бумага",
            3 => "Камінь",
            _ => "Невідомо"
        };

        Console.WriteLine("tu oбрав: " + lud);
        Console.WriteLine("PC вибрав: " + pk); 


        if (I == 1)
        {
            if (comp == 2)
            {
                Console.WriteLine("ПЕРЕМОГА!!!");
            }
            else if (comp == 3)
            {
                Console.WriteLine("ЛУЗЕР!!!");
            }
            else
            {
                Console.WriteLine("Нiчия!");
            }
        }
        else if (I == 2)
        {
            if (comp == 1)
            {
                Console.WriteLine("ЛУЗЕР!!!");
            }
            else if (comp == 3)
            {
                Console.WriteLine("ПЕРЕМОГА!!!");
            }
            else
            {
                Console.WriteLine("Нiчия!");
            }
        }
        else if (I == 3)
        {
            if (comp == 1)
            {
                Console.WriteLine("ПЕРЕМОГА!!!");
            }
            else if (comp == 2)
            {
                Console.WriteLine("ЛУЗЕР!!!");
            }
            else
            {
                Console.WriteLine("Нiчия!");
            }
        }
    }
}
