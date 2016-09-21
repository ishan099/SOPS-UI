using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace DAO
{
   public  class UserInfo
    {
       public UserDal userDal = new UserDal();

       private String distribution;

       public String Distribution
       {
           get { return distribution; }
           set { distribution = value; }
       }
        private String userGroupName;

        public String UserGroupName
        {
            get { return userGroupName; }
            set { userGroupName = value; }
        }
        private String userGrouDesc;

        public String UserGrouDesc
        {
            get { return userGrouDesc; }
            set { userGrouDesc = value; }
        }
        private int assignUsers;

        public int AssignUsers
        {
            get { return assignUsers; }
            set { assignUsers = value; }
        }


        private String uName;

        public String UName
        {
            get { return uName; }
            set { uName = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private String userMode;

        public String UserMode
        {
            get { return userMode; }
            set { userMode = value; }
        }
       
        public bool SaveUserDetails(UserInfo objuser)
       {
           
           if (userDal.InserUserDetails(objuser.uName,objuser.password,objuser.email,objuser.status,objuser.userMode))
               return true;
           else
               return false;
       }

        public DataTable GetUserData(UserInfo objuser)
        {
            DataTable Dt = userDal.GetAllDataForUser(objuser.userMode);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }


        public DataTable GetUserByName(String user)
        {
            DataTable Dt = userDal.GetUserByName(user);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

        public DataTable GetAllusers()
        {
            DataTable Dt = userDal.GetAllusers();
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

        public bool SaveUserGroupDetails(UserInfo objuser)
        {

            if (userDal.InserUserGroupDetails(objuser.userGroupName, objuser.userGrouDesc, objuser.status,  objuser.distribution))
                return true;
            else
                return false;
        }


        public DataTable GetAlluserGroups()
        {
            DataTable Dt = userDal.GetAllusersAndGroups();
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return Dt;

        }

        public DataTable GetAlluserGroupsBySubCat(int subCat)
        {
            DataTable Dt = userDal.GetAllusersAndGroupsBySubCat(subCat);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return Dt;

        }

        public DataTable GetUserGroupByName(String user)
        {
            DataTable Dt = userDal.GetDetailsByName(user);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

        public bool SaveUserGroupWithUsers(UserInfo objuser)
        {

            if (userDal.InserUserGroupDetailsWithUsers(objuser.userGroupName,objuser.uName))
                return true;
            else
                return false;
        }


    }
}
