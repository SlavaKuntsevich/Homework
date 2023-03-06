using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorWorkerBooker
{
    public class Worker : JobTitle
    {
        string job { get; set; } = "Работяга";

        public void JobT()
        {
            Console.WriteLine($"Должность сотрудника : {job}");
        }      
    }
}

