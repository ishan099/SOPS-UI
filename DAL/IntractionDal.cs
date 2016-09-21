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
    public  class IntractionDal : DataAccess
    {

        public Boolean UpdateIntraction(Int32 intractionID, int type, int mainCat, int cat, int subCat, String agentRemarks,  String status, String modifiedUser, int assignGrp, int reassign)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("@IntractionID", intractionID);
                param[1] = new SqlParameter("@MainCat", mainCat);
                param[2] = new SqlParameter("@Cat", cat);
                param[3] = new SqlParameter("@SubCat", subCat);
                param[4] = new SqlParameter("@AgentRemarks", agentRemarks);
                param[5] = new SqlParameter("@Status", status);
                param[6] = new SqlParameter("@ModifiedUser", modifiedUser);
                param[7] = new SqlParameter("@AssignedGroup", assignGrp);
                param[8] = new SqlParameter("@Reassign", reassign);
                param[9] = new SqlParameter("@Type", type);
                
                callSp("Sp_UpdateIntraction", param);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
