namespace LoginPassword
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool registrationDone = CreateAccount.CreatingAccount("qwerty123", "123qwerty", "123qwerty");
                if (registrationDone) Console.WriteLine("Регистрация завершена успешно");
            }
            catch (WrongLoginException ex) { Console.WriteLine(ex.Message); }

            catch (WrongPasswordException ex) { Console.WriteLine(ex.Message); }

        }
    }
}