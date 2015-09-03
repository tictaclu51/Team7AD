using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;

namespace ClassLibraryBL.controller
{
    public class loginController
    {
        loginFacade lf;
        public loginController()
        {
            lf = new loginFacade();
        }
        public bool Authentication(string email, string password)
        {
           return lf.loginvalidate(email, password);
        }


    }
}
