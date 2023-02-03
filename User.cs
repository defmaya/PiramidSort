using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Пирамидальная_сортировка
{
    internal class User
    {
        string username, password;
        Database database = new Database();
        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }
        // Проверяет правильность введенных данных в форме входа
        public bool CorrectUser()
        {
            if (String.IsNullOrEmpty(username))
                throw new Exception("Поле для имени пользователя пусто.");
            if (String.IsNullOrEmpty(password))
                throw new Exception("Поле для пароля пусто.");
            if (username.Length < 4)
                throw new Exception("Длина имени пользователя меньше 4 символов.");
            if (password.Length < 4)
                throw new Exception("Длина пароля меньше 4 символов.");
            return true;
        }
        //хэширование функции
        private string getHash()
        {
            using (var hmac = new HMACSHA1(Encoding.UTF8.GetBytes("new key")))
            {
                return Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
        //создание пользователя
        public void CreateUser()
        {
            database.Create(username, getHash());
        }

        public bool UsernameExist()
        {

            return database.Exists(username);
        }
        public bool UserValid()
        {
            return database.Valid(username, getHash()); //передается имя и зашифрованный пароль
        }
        //Свойства переменных
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
