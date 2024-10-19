namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int number = Convert.ToInt32(Console.ReadLine());
            //int i = 2;

            //for (i = 2; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        break;
            //    }
            //}

            //if (number == 1)
            //{
            //    Console.WriteLine("Bu eded ne sade, ne de murekkeb ededdir!");
            //}
            //else if (number == i)
            //{
            //    Console.WriteLine("Bu eded sade ededdir!");
            //}
            //else
            //{
            //    Console.WriteLine("Bu eded murekkeb ededdir!");
            //}
            #endregion

            #region Task2
            int number2 =Convert.ToInt32(Console.ReadLine());
            int s = 0;
            if(number2 == 0)
            {
                s = 1;
            }
            while (number2 > 0)
            {
                number2 /= 10;
                s++;
            }
            Console.WriteLine(s);
            #endregion

        }
    }
}
