namespace _2_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            /* If yapısı
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }

            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else 
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            */

            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            /* Switch Yapısı
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;

                case 20:
                    Console.WriteLine("Number is 20");
                    break;

                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;

            }
            */

            /* Mantıksal Operatörlerin Kullanımı
            if(number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0 and 100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101 and 200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            */
        }
    }
}