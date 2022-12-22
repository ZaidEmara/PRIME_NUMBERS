namespace PrimeProject
{
    internal class Program
    {
        static void Main(string[] args)   
        {
            int s, divisor, check, start, End;

            Console.WriteLine("Enter starting number of range");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input ending number of range : ");
            End = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : ", start, End);

            for (s = start; s <= End; s++)
            {
                check= 0;

                for (divisor = 2; divisor <= s / 2; divisor++)
                {
                    if (s % divisor == 0)
                    {
                        check++;
                        break;
                    }
                }

                if (check == 0 && s != 1)
                    Console.Write(s + "  ");
            }
           
        }
    }
}
