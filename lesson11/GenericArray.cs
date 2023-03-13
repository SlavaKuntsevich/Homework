using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    public class GenericArray <T>
    {
        T[] array = new T[10];
        int index = 0;

        public T[] Array { get => array; set => array = value; }

        public void AddElements(T element)
        {
            try
            {
                Array.SetValue(element, index);
                index++;
            }
            catch (IndexOutOfRangeException) { Console.WriteLine("Индекс должен быть не больше 10"); }
        }
        public T GetElement(int index)
        {
            return (T)Array.GetValue(index);
        }

        public void CountElements()
        {
            Console.WriteLine($"Элементов в массиве: {index}");
        }

        
    }
}
