using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Ebook_Project.Models
{
    public class Account
    {
        private string email;
        private string password;
        private string nameUser;
        private string sdt;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public Account(string email, string password, string nameUser = null, string sdt = null)
        {
            this.email = email;
            this.password = password;
            this.nameUser = nameUser;
            this.sdt = sdt;
        }

    }
}