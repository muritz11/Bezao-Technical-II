
namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Today;
            int currentYear = Int32.Parse(now.ToString("yyyy"));
            Console.WriteLine("These are the leap years for the next 20 years:");
            /*********************************
             * Two conditions make a leap year:
             * * it's evenly divisible by 4
             * * Years that are divisible by 
             * 100 cannot be leap year unless 
             * they're also divisible by 400
             * ******************************/


            int leapIteration = 0;
            while (leapIteration < 20)
            {
                if (currentYear%4 == 0)
                {
                    if(currentYear%100 == 0 && currentYear%400 != 0)
                    {
                        currentYear++;
                        continue;
                    }
                    Console.WriteLine(currentYear);
                    leapIteration++;
                }
                currentYear++;
            }
        }
    }
}