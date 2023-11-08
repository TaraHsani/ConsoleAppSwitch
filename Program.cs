using System.Diagnostics;

namespace ConsoleAppSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Plece inter yout name");
            //string name = Console.ReadLine().ToLower();

            //Console.WriteLine("place inter your family");
            //string family = Console.ReadLine().ToLower();

            //if (name == "Tara" || family == "hasani")
            //{

            //    Console.WriteLine("Hello Tara *************************");
            //    Console.WriteLine("************************************");

            //}
            //else
            //{

            //    Console.WriteLine("Hello user");

            //}

            //Console.WriteLine("place inter your number");
            //string numberstr = Console.ReadLine();
            //int number = int.Parse(numberstr);

            //if (number > 0 && number % 2 == 0)
            //{

            //    Console.WriteLine("The number is positive even number!");

            //}
            //else if (number < 0 && number % 2 != 0)
            //{

            //    Console.WriteLine("The number is negative!");

            //}
            //else
            //{

            //    Console.WriteLine("Invalid!");

            //} 


            Console.WriteLine("place inter your number");
            string numberstr = Console.ReadLine();
            int numberOfWeek = int.Parse(numberstr);



        
            switch (numberOfWeek)
                {
                    case 1:

                    Console.WriteLine("Shanbe");
                    break;

                    case 2:

                    Console.WriteLine("1shanbe");
                    break;

                    case 3:

                    Console.WriteLine("2shanbe");
                    break;

                    case 4:

                    Console.WriteLine("3shanbe");
                    break;

                    case 5:

                    Console.WriteLine("4shanbe");
                    break;

                    case 6:

                    Console.WriteLine("5shanbe");
                    break;

                    case 7:
                    Console.WriteLine("jomeh");
                    break;

                    default : Console.WriteLine("pleace inter a valid number");
                    break;


                }

        }
    }
}