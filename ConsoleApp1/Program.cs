using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberToCheck = 21; // Ədədi yoxlamaq istədiyiniz ədəd
            bool isPrime = IsPrime(numberToCheck);

            if (isPrime)
            {
                Console.WriteLine(numberToCheck + " sadədir.");
            }
            else
            {
                Console.WriteLine(numberToCheck + " sadə deyil.");
            }



            int[] examGrades = { 65, 72, 95, 58, 89 };

            double average = CalcAvg(examGrades);

            if (average > 60)
            {
                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }
        }








        static bool IsPrime(int value)
        {
            if (value <= 1)
            {
                return false;
            }
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }



        // Imtahanlar qiyməti siyahısına əsasən ortalama hesablayan metod
        static double CalcAvg(int[] grades)
        {
            if (grades.Length == 0)
            {
                return 0; // Boş siyahi ise  0 qaytar
            }

            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }

            return (double)sum / grades.Length; // Ortalamanı hesabla
        }

    }
    }






    }
}
