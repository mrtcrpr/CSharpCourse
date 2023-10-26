namespace _1_TypesandVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");

            // int değeri -2147483648 ve bunun +2147483647 değeriyle sınırlıdır ve 32 bittir.
            // long değeri -9223372036854775808 ve bunun +9223372036854775807 değeriyle sınırlıdır ve 64 bittir.
            // short değeri -32768 ve bunun +32767 değeriyle sınırlıdır ve 16 bittir.
            // byte değeri 0 ve 255 değeriyle sınırlıdır ve 8 bittir.
            // bool ifadesi true ve false değerlerini tutar.
            // char ifadesi tek bir karakteri barındırır.
            // double veri türü ondalıklı değerleri barındırır.
            // decimal veri türü, double veri türüne göre virgülden sonra daha fazla basamak barındırır.
            // enum kullanarak string ifadeleri defalarca kez yazmaktan kurtulabiliriz.
            // var değerinde eşitliğin diğer tarafına hangi değer yazılırsa var tipi o değerin türüyle eşitlenir.

            int number1 = 10;
            long number2 = -9223372036854775808;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = true;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 20.5m;
            var number7 = 15;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Condition is {0}", condition);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine(Days.Sunday);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Deneme");
            Console.WriteLine("Deneme2");
        }

        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
