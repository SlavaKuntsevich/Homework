using static lesson11.Comparable;

namespace lesson11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxNumber<int>.MaxNumb(457, 874, 980));
            
            var array = new GenericArray<int>();
            array.AddElements(95);
            array.AddElements(434);
            array.AddElements(921);
            array.AddElements(840);
            array.AddElements(27);
            array.AddElements(2016);
            array.AddElements(1902);
            array.AddElements(808);
            array.AddElements(3);
            array.AddElements(7530501);            
            Console.WriteLine(array.GetElement(5));
            array.CountElements();
            

        }
    }
}