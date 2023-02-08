namespace Deliverable__4____Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;

            for (int i = 0; i < 25; i++)
            {

                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;

                if (i == 0)
                {
                    f1 = 0;
                }

                Console.WriteLine("Fibonacci(" + i + ") = " + f1.ToString());

            }
        }
    }
}