using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_
{
    public struct UserInfo
    {
        public string name;
        public int age;
        public string address;
        public string surname;
        public string login;
        public string password;

        public UserInfo()
        {
            name = "Michael";
            surname = "Jackson";
            age = 50;
            address = "USA";
            login = "MichaelJackson1234";
            password = "password2009";
        }
        public void ShowUserInfo()
        {
            Console.WriteLine($"Имя  {name}");
            Console.WriteLine($"Фамилия {surname}");
            Console.WriteLine($"Возраст {age}");
            Console.WriteLine($"Адрес  {address}");
            Console.WriteLine($"Логин  {login}");
            Console.WriteLine($"Пароль  {password}");
        }
    }
}
