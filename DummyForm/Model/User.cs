using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForm.Modelo
{
    public class User
    {
        private string userName;
        private string password;
        public User() {
            this.UserName = "admin";
            this.Password = "admin";
        } 
        public User(String userName, String password)
        {
            this.UserName=userName;
            this.Password=password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
