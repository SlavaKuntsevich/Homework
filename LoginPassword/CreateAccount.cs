using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginPassword
{
    public class CreateAccount
    {
        public static bool CreatingAccount(string login, string password, string confirmPassword)
        {
            bool registrationSuccses = true;
            Regex regex = new Regex(@"[0-9]");
            MatchCollection matches = regex.Matches(password);
            if (matches.Count > 0)
            {
                foreach (Match match in matches) { }
            }
            else
            {
                throw new WrongPasswordException("Пароль должен содержать хотя бы 1 цифру");
            }
            if (login.Length >= 20) throw new WrongLoginException("Логин не должен превышать 20 символов");
            if (login.Contains(' ')) throw new WrongLoginException("Логин не должен содержать пробелы");
            if (password.Length >= 20) throw new WrongPasswordException("Пароль не должен превышать 20 символов");
            if (password.Contains(' ')) throw new WrongPasswordException("Пароль не должен содержать пробелы");           
            if (!password.Equals(confirmPassword)) throw new WrongPasswordException("Пароли не совпадают");
            return registrationSuccses;
        }
    }   
}
