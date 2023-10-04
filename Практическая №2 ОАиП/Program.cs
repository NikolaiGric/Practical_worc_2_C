namespace Практическая__2_ОАиП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите программу, которую вы хотите запустить:");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход из программы");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 4) { break; }
                if (i == 1) { One(); }
                if (i == 2) { Two(); }
                if (i == 3) { Three(); }
            }
        }
        static void One()
        {
            Console.WriteLine("Угадай число от 1 до 100!");
            Random random = new Random();
            int value_1 = Convert.ToInt32(Console.ReadLine());
            int value = random.Next(1, 100);
            while (true)
            {
                if (value_1 == value) { Console.WriteLine("Угадал!"); break; }
                if (value_1 > value) { Console.WriteLine("Надо меньше"); value_1 = Convert.ToInt32(Console.ReadLine()); }
                if (value_1 < value) { Console.WriteLine("Надо больше"); value_1 = Convert.ToInt32(Console.ReadLine()); }
            }
        }

        static void Two()
        {
            int[,] multMatr;
            multMatr = new int[10, 10];
            for (int b = 1; b <= 9; b++)
                for (int j = 1; j <= 9; j++)
                    multMatr[b, j] = b * j;
            for (int b = 1; b <= 9; b++)
            {
                for (int j = 1; j <= 9; j++)
                { Console.Write(multMatr[b, j] + "\t"); }
                Console.WriteLine();
            }
        }

        static void Three()
        {
            Double i_1 = Convert.ToDouble(Console.ReadLine());
            for (Double i_2 = 0; i_2 <= i_1; i_2++)
            {
                if (i_1 % i_2 == 0) { Console.Write("  " + i_2); }
                else { continue; }
                }Console.WriteLine();
            }
        }   
            
    }