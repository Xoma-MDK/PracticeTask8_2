using System;

namespace PracticeTask8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во членов ряда: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double Sum = 1;
            if (N > 1)
            {
                for (int i = 1; i <= N; i++)
                {
                    int factorial = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        factorial *= j;
                    }
                    Sum += 1.0f / (double)factorial;

                }
                Console.WriteLine($"Сумма ряда равна: {Sum:F}");
            } else if (N == 1){
                Console.WriteLine($"Сумма ряда равна: {Sum}");
            } else
            {
                Console.WriteLine("Сумма ряда равна не может быть рассчитана");
            }

            
        }
    }
}
