namespace Figure_
{
    public class Program
    {
        public static void Main() 
        {
            var rectangle1 = new Rectangle(24, 45);
            var rectangle2 = new Rectangle(162, 498);
            var triangle = new Triangle(10, 20, 15);
            var circle1 = new Circle(60);
            var circle2 = new Circle(30);
            Figure[] figureArray = new Figure[5];
            figureArray[0] = rectangle1;
            figureArray[1] = rectangle2;
            figureArray[2] = triangle;
            figureArray[3] = circle1;
            figureArray[4] = circle2;
            double Summary = 0;
            for (int i = 0; i < figureArray.Length; i++)
            { Summary += figureArray[i].Perimeter();
            }
            Console.WriteLine($"Сумма периметра всех фигур: {Summary}");
        }
    }
}