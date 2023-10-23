namespace _3_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add2(10, 20));

            Console.WriteLine(Multiply(10, 20));

            Console.WriteLine(Multiply(10, 20, 30));

            Console.WriteLine(Add3(1, 2, 3, 4, 5, 6));
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2)
        {
            // virgülden sonraki parametreler için default değerler tanımlanabilir. number2 = 20
            // ref keyword'ü kullanılırsa o parametre için ne tanımlanırsa tanımlansın metodun içerisindeki değer atanır
            // out keyword'ü ref key gibi çalışır ancak parametre dışında değer atanmamışsa out keyword'ü problem çıkarmaz
            int result = number1 + number2;
            return result;
        }

        static int Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }

        // eğer aynı adla tanımlanan metoda fazladan bir parametre daha eklenirse problem çıkmayacaktır ve buna method overloading denir
        static int Multiply(int number1, int number2, int number3)
        {
            int result = number1 * number2 * number3;
            return result;
        }

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
