using System;

namespace wage_for_20_days
{
    public static class Wage_for_20_days
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void Main(string[] args)
        { }

        public static void wage_for_20_days()
        {
            {


                int emphrs = 0;
                int empwage = 0;
                int totalempwage = 0;
                for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
                {
                    Random random = new Random();
                    int empcheck = random.Next(0, 3);
                    switch (empcheck)
                    {
                        case IS_PART_TIME:
                            emphrs = 4;
                            break;
                        case IS_FULL_TIME:
                            emphrs = 8;
                            break;
                        default:
                            emphrs = 0;
                            break;
                    }
                    empwage = emphrs * EMP_RATE_PER_HOUR;
                    totalempwage += empwage;
                    Console.WriteLine("empwage:" + empwage);

                }
                Console.WriteLine("Total empwage:" + totalempwage);
            }
        }
    }
}
