namespace _4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tek boyutlu diziler
            string[] students = new string[3];
            students[0] = "Ahmet";
            students[1] = "Murat";
            students[2] = "Ayşe";

            string[] students2 = {"Ahmet", "Murat", "Halit"};

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
            */

            string[,] regions = new string[5, 3]
{
            {"İstanbul","İzmit","Balıkesir"},
            {"Ankara","Konya","Kırıkkale"},
            {"Antalya","Adana","Mersin"},
            {"Rize","Trabzon","Samsun"},
            {"İzmir","Muğla","Manisa"},
};
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
                Console.WriteLine("*********");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}