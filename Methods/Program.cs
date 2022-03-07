using System;


namespace Methods
{
   
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var number = int.Parse("abc");
            }
            catch(Exception)
            {
                Console.WriteLine("Conversion failed.");
            }
            //int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");

          
        }

        static void UseParams()
        {
            var CalculatorCSharp = new CalculatorCSharp();
            Console.WriteLine(CalculatorCSharp.Add(1, 2));
            Console.WriteLine(CalculatorCSharp.Add(1, 2, 3));
            Console.WriteLine(CalculatorCSharp.Add(1, 2, 3, 4));
            Console.WriteLine(CalculatorCSharp.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine(" An unexpected Error occured.");
            }
        }
    }
}