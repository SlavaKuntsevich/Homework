using System.IO;

namespace DirectorWorkerBooker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director AlexandrVladimiroch = new Director();
            Booker VladimirAlexandrovich = new Booker();
            Worker Borisych = new Worker();
            AlexandrVladimiroch.ShowJobTile();
            VladimirAlexandrovich.ShowJobTile();
            Borisych.ShowJobTile();
        }
    }
}