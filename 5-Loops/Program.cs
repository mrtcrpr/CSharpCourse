namespace _5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* For Döngüsü 

for (Sayacımız; Koşulumuz; Değerin artışı) 
{
Console.WriteLine(i);
}


for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");

*/

            /* While Döngüsü
             
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);

            */


            /* Do - While Döngüsü
             
            int number = 0;
            do {
                Console.WriteLine(number);  
                number++;
            } while (number <= 100);

            */

            /* ForEach Döngüsü
             
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            */

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                {
                    Console.WriteLine("This is not a prime number");
                }
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
