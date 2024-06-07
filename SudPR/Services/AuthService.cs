using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using SudPR.IModels;

namespace SudPR.Services
{
    public class AuthService
    {
        private readonly List<IAccount> accounts;

        public AuthService()
        {
            // Здесь вместо списка можно использовать доступ к базе данных.
            accounts = new List<IAccount>();
            // Инициализация списка аккаунтов.
        }

        public IAccount Login(string login, string password)
        {
            var account = accounts.FirstOrDefault(acc => acc.Login == login && acc.Password == password);

            if (account != null)
                return account;
            else
                throw new UnauthorizedAccessException("Login or password is incorrect.");
        }

        public void Register(IAccount newAccount)
        {
            if (accounts.Any(acc => acc.Login == newAccount.Login))
                throw new Exception("Account with such a login already exists.");

            accounts.Add(newAccount);
        }
    }
}
