using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDal : DataAccess
    {

        public Boolean InserUserDetails(String uname, String password, String email, int status, String mode)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@UserName", uname);
                param[1] = new SqlParameter("@Password", password);
                param[2] = new SqlParameter("@EmailAdd", email);
                param[3] = new SqlParameter("@Status", status);
                param[4] = new SqlParameter("@UserMode", mode);
                callSp("Sp_InsertUser", param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public DataTable GetAllDataForUser(String userMode)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     *  FROM         CIA_User WHERE UserMode =  '" + userMode + "'";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public DataTable GetUserByName(String Uname)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     UserID, Username, Password, Email, IsActive, CreatedDate, Login, UserMode FROM CIA_User where Username= '" + Uname + "'  ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public DataTable GetAllusers()
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     UserID, Username, Password, Email, IsActive, CreatedDate, Login, UserMode FROM CIA_User  ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Boolean InserUserGroupDetails(String uGroupname, String desc, int status, String distribution)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@UserGroupName", uGroupname);
                param[1] = new SqlParameter("@Desc", desc);
                param[2] = new SqlParameter("@Status", status);
                param[3] = new SqlParameter("@Distribution", distribution);

                callSp("Sp_InsertUserGroups", param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Boolean InserUserGroupDetailsWithUsers(String uGroupname, String @User)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Group", uGroupname);
                param[1] = new SqlParameter("@User", @User);


                callSp("Sp_InsertUserGroupsToUsers", param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetAllusersAndGroups()
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     CIA_User.Username, CIA_UserGroups.GroupID, CIA_Group.GroupName, CIA_Group.Description, CIA_Group.IsActive FROM CIA_User INNER JOIN "+
                      " CIA_UserGroups ON CIA_User.UserID = CIA_UserGroups.UserID RIGHT OUTER JOIN "+
                      " CIA_Group ON CIA_UserGroups.GroupID = CIA_Group.GroupID" ;
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetAllusersAndGroupsBySubCat(int Subcat)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     CIA_SubCategory.SubCatID, CIA_Group.GroupName ,CIA_Group.GroupName,CIA_Group.GroupID FROM  CIA_SubCategory INNER JOIN  " +
                      " CIA_Group ON CIA_SubCategory.AssignedGroup = CIA_Group.GroupID where SubCatID ='" + Subcat + "'";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public DataTable GetDetailsByName(String groupName)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT GroupID, GroupName, Description, RegionID, AccessID, IsActive, CreatedDate, Distribution, MaxInteraction, MinInteraction FROM CIA_Group where GroupName ='" + groupName + "' ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
