using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("All hats are 50% off!");
                    break;

                case Season.Summer:
                    Console.WriteLine("Now you have to pay double for hats!");
                    break;

                case Season.Spring:
                case Season.Winter: 
                    Console.WriteLine("All hats are normally priced.");
                    break;
            }
        }
    }
}
