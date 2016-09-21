using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace DAO
{
   public class LoginUser
    {
       //Variables for login

        private String userName;
        private String password;
        public LoginDal dal = new LoginDal();

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
       

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public DataTable getUser(LoginUser obj)
        {
           DataTable Dt = dal.getLogin(obj.userName ,obj.password);
           if (Dt.Rows.Count > 0)
               return Dt;
           else
               return Dt;
        }
    }
}
