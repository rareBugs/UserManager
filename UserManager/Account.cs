using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserManager
{
    public class Account
    {
        private static List<Account> accountsList = new List<Account>();

        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        
        public Account(string username, string password, string type)
        {
            Username = username;
            Password = password;
            Type = type;
        }

        //public static List<Account> AccountsList { get; private set; }

        public static void AddAccount(Account account)
        {
            accountsList.Add(account);
        }

    }
}
