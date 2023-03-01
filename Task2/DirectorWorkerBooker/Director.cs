using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorWorkerBooker
{
    class Director : JobTitle
    {
        string job { get; set; } = "Директор";      
        public void ShowJobTile()
        {
            Console.WriteLine($"Должность сотрудника : {job}");
        }
    }
}
