using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning  a string and mulitplying the parameter. So it will have two outputs but only returns the string.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable.
        public static string TimesFive(ref int x)
        {
            //This will change the initial valus
            x = x * 5;
            return $"Your answer is {x}";
        }
        public static string TimesThree(int y)
        {
            //This will not change the initial value
            y = y * 3;
            return $"Your answer is {y}";
        }
        public static void DivisibleByThree(int x, out int y)
        {
            y = x / 3;
            if (x % 3 == 0)
            {
                Console.WriteLine($"{x} is divisble by three.");
            }
            else
            {
                Console.WriteLine($"{x} is not divisble by three.");
            }
        }
        //TODO create method that uses the out keyword. Call the method in the main.
  
        static void Main(string[] args)
        {
            //This will change the initial value
            int myNumber = 5;
            var response = TimesFive(ref myNumber);
            Console.WriteLine(response);
            Console.WriteLine($"Value of input variable now: {myNumber}");



            //This will not change the initial value
            int myNumber2 = 5;
            var response2 = TimesThree(myNumber2);
            Console.WriteLine(response2);
            Console.WriteLine($"Value of input variable now: {myNumber2}");


            //This will give value to an empty variable
            int myNumber3 = 3;
            int answer;
            DivisibleByThree(myNumber3, out answer);
            Console.WriteLine($"Because {myNumber3} divided by 3 is {answer}");
            



            



        }

    }
}
