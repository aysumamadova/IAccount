using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount.Models
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        void ShowInfo();
    }
}
