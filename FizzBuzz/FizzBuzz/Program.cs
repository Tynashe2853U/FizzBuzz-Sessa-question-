namespace FizzBuzz
{
    internal class Program
    {
        public static void FizzBuzz()
        {
            int num = 1;
            while (num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0 ) {

                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
                num++;

            }
        }
        static void Main(string[] args)
        {
            FizzBuzz();
        }
    }
}
