namespace Homework2
{ 
    internal class Programm
    {
        static void main(string[] args)
        {
            // Задача А Задание 1 
            int[] fibonacci = { 0, 1, 1, 2, 3, 5, 8, 13 };

            // Задание 2 
            string[] months =
            {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };

            // Задание 3
            int[,] matrix =
            {
            { 2, 3, 4 },
            { 4, 9, 16 },
            { 8, 27, 64 }
        };

            // Задание 4
            double[][] jaggedArray =
            {
            new double[] { 1, 2, 3, 4, 5 },
            new double[] { Math.E, Math.PI },
            new double[]

            {
                Math.Log(1, 10),
                Math.Log(10, 10),
                Math.Log(100, 10),
                Math.Log(1000, 10)
            }
        };

            //  Задача Б Задание 5 и 6
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, array2, 3);
            Array.Resize(ref array, array.Length * 2);

        }
    }
}