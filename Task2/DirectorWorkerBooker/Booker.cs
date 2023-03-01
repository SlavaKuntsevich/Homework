using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorWorkerBooker
{
    class Booker
    {
        string job { get; set; } = "Бухгалтер";
        public void ShowJobTile()
        {
            Console.WriteLine($"Должность сотрудника : {job}");
        }
    }
}

