namespace Enum_
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                switch (i)
                {
                    case (int)WeekDays.Monday:
                        Console.WriteLine("Сегодня Понедельник");
                        Thread.Sleep(100);
                        break;
                    case (int)WeekDays.Tuesday:
                        Console.WriteLine("Сегодня Вторник");
                        Thread.Sleep(200);
                        break;
                    case (int)WeekDays.Wednesday:
                        Console.WriteLine("Сегодня Среда");
                        Thread.Sleep(300);
                        break;
                    case (int)WeekDays.Thursday:
                        Console.WriteLine("Сегодня Четверг");
                        Thread.Sleep(400);
                        break;
                    case (int)WeekDays.Friday:
                        Console.WriteLine("Сегодня Пятница");
                        Thread.Sleep(500);
                        break;
                    case (int)WeekDays.Saturday:
                        Console.WriteLine("Сегодня Суббота");
                        Thread.Sleep(6000);
                        break;
                    case (int)WeekDays.Sunday:
                        Console.WriteLine("Сегодня Воскресенье");
                        Thread.Sleep(700);
                        break;
                }
            }
        }
    }
}