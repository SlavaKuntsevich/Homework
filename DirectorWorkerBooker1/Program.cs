using System.IO;

namespace DirectorWorkerBooker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            director.JobT();
            var accountant = new Booker();
            booker.JobT();
            var worker = new Worker();
            worker.JobT();
            Console.ReadKey();
            Console.WriteLine("\n");
        }
    }
}
