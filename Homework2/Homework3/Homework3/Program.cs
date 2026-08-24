namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);

                int next = a + b;
                a = b;
                b = next;
            }


            // Задание 2

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }


            // Задание 3

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + " ");
                }

                Console.WriteLine();
            }


            // Задание 4

            string password = "qwerty";
            string? input;

            do
            {
                Console.WriteLine("Enter password:");
                input = Console.ReadLine();
            }
            while (input != password);
        }
    }
}