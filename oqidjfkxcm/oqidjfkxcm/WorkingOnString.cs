using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oqidjfkxcm
{
    internal class WorkingOnString
    {
        public void five()
        {
            char[] alphabet = "abcdrfghijklmnopqrstuvwxyz".ToCharArray();

            Console.WriteLine("\nВведите целое число");
            int N = int.Parse(Console.ReadLine());

            while (N < 1 || N > 26)
            {
                Console.WriteLine("\nЧисло должно быть больше 1 и меньше 26");
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{alphabet[alphabet.Length - 1 - i]}, ");
            }
        }

        public void twantytwo()
        {
            Console.WriteLine("\nВведите целове положительное число");
            string numbers_ = Console.ReadLine();
            int scor = 0;

            int numbers = int.Parse(numbers_);

            while (numbers > 0)
            {
                scor += numbers % 10;
                numbers /= 10;
            }

            Console.WriteLine($"\nСумма всех цифр этого числа = {scor}");
        }

        public void thirtyone()
        {
            Console.WriteLine("\nВведите текстовое значение для двух переменных");
            string S = Console.ReadLine();
            string S1 = Console.ReadLine();

            if (S.Contains(S1))
            {
                Console.WriteLine("\nTrue");
            }
            else { Console.WriteLine("\nFalse");  }
        }

        public void fiftysix()
        {
            Console.WriteLine("\nВведите предложение");
            string manywords = Console.ReadLine();

            string[] words = manywords.Split(' ',',');
            string r = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length <= r.Length)
                {
                    r = words[i];
                }
            }

            Console.WriteLine($"\nСамое короткое слово в предложении {r}");
        }


    }
}
