using DummyForm.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForm.Controller
{
    public class UserController
    {
        User user;
        public UserController() {
            this.user = new User();
        }
        public bool loginValidation(string userName, string password)
        {
            return (user.UserName == userName && user.Password == password)? true: false;
        }
    }
}
