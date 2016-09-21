using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DAO
{
    public class Tasks
    {
        private String UserName;
        TaskDal taskObj = new TaskDal();
        
        public String UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }


        public DataTable GetTasksUserWise(String userName)
        {
            DataTable Dt = taskObj.GetAllDataForUser(userName);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

    }
}
