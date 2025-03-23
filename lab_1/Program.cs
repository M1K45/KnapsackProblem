namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Problem problem = new Problem(5, 1);
            Console.WriteLine(problem);


         
            Console.WriteLine(problem.Solve(13));

        }
    }
}
