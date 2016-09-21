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
    public class CatDal: DataAccess
    {


        DataTable dt;
        

     
        public DataTable GetMainCategory(int id)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT  TypeID,Type FROM CIA_Type where  InteractionTypeID = '" + id + "'";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetCategory(int id)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT    CatID ,Category FROM         CIA_Category where TypeID = '" + id + "'";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetSubCategoryByCategory(int id)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT SubCatID, CatID, SubCategory, Description, IsActive, CreatedUser, CreatedDate, AssignedGroup FROM         CIA_SubCategory where CatID = '" + id + "'";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetAllMainCategory()
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = " SELECT     CIA_InteractionType.InteractionType, CIA_Type.Type " +
                        "FROM         CIA_Type INNER JOIN " +
                       "CIA_InteractionType ON CIA_Type.InteractionTypeID = CIA_InteractionType.InteractionTypeID";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable GetAllMainCategoryByName(String mainCat)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT   *  FROM  CIA_Type WHERE  Type ='" + mainCat + "' ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetAllDataForCategory()
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     CIA_InteractionType.InteractionType, CIA_Type.Type, CIA_Type.TypeID, CIA_Category.Category ,CIA_Category.Description" +
                        " FROM         CIA_Type INNER JOIN "+
                      "CIA_InteractionType ON CIA_Type.InteractionTypeID = CIA_InteractionType.InteractionTypeID INNER JOIN "+
                      "CIA_Category ON CIA_Type.TypeID = CIA_Category.TypeID ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Boolean insertMainCat(Int32 IntractionTypeID,String mainType,String desc ,int status)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@IntractionTypeID", IntractionTypeID);
                param[1] = new SqlParameter("@MainType", mainType);
                param[2] = new SqlParameter("@Desc", desc);
                param[3] = new SqlParameter("@Status", status);
                callSp("Sp_InsertMainCategory",param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public Boolean inserCat(int maincatID ,String category, String desc, int status)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@MainTypeID", maincatID);
                param[1] = new SqlParameter("@Catgegory", category);
                param[2] = new SqlParameter("@Desc", desc);
                param[3] = new SqlParameter("@Status", status);
                callSp("Sp_InsertCategory", param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetCategoryByName(String Cat)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT   * FROM         CIA_Category where Category ='" + Cat + "' ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public DataTable GetSubCategoryByName(String sCat)
            {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT   *   FROM  CIA_SubCategory  where SubCategory  ='" + sCat + "' ";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Boolean inserSubCat(int catID, String category, String desc, int status,int uGroup,String User)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@CatID", catID);
                param[1] = new SqlParameter("@SubCat", category);
                param[2] = new SqlParameter("@Description", desc);
                param[3] = new SqlParameter("@CreatedUser", User);
                param[4] = new SqlParameter("@Status", status);
                param[5] = new SqlParameter("@AssignedGroup", uGroup);
               
                callSp("Sp_InsertSubCategory", param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetAllDataForSubCategory(int catId)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT     CIA_InteractionType.InteractionType, CIA_Type.Type, CIA_Type.TypeID, CIA_Category.Category, CIA_Category.Description, CIA_SubCategory.SubCategory, " +
                      "CIA_SubCategory.Description AS Expr1 FROM         CIA_Type INNER JOIN" +
                     " CIA_InteractionType ON CIA_Type.InteractionTypeID = CIA_InteractionType.InteractionTypeID INNER JOIN " +
                     " CIA_Category ON CIA_Type.TypeID = CIA_Category.TypeID INNER JOIN " +
                      "CIA_SubCategory ON CIA_Category.CatID = CIA_SubCategory.CatID where CIA_SubCategory.CatID ='" + catId + "'";
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
