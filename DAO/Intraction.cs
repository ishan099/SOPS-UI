using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DAO
{
   public class Intraction
    {

       IntractionDal objItraction = new IntractionDal();

       private int type;

       public int Type
       {
           get { return type; }
           set { type = value; }
       }

       private int intractionID;

       public int IntractionID
       {
           get { return intractionID; }
           set { intractionID = value; }
       }
       
        private int mainCat;

        public int MainCat
        {
            get { return mainCat; }
            set { mainCat = value; }
        }
        private int category;

        public int Category
        {
            get { return category; }
            set { category = value; }
        }
        private int subCat;

        public int SubCat
        {
            get { return subCat; }
            set { subCat = value; }
        }
        private String agentRemarks;

        public String AgentRemarks
        {
            get { return agentRemarks; }
            set { agentRemarks = value; }
        }
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        private String modifiedUser;

        public String ModifiedUser
        {
            get { return modifiedUser; }
            set { modifiedUser = value; }
        }
        private int assignGrp;

        public int AssignGrp
        {
            get { return assignGrp; }
            set { assignGrp = value; }
        }
            private int reassign;

            public int Reassign
            {
                get { return reassign; }
                set { reassign = value; }
            }

            public Boolean UpdateIntraction(Intraction obj)
        {
            if (objItraction.UpdateIntraction(obj.intractionID, obj.type, obj.mainCat, obj.category, obj.subCat, obj.agentRemarks, obj.status, obj.modifiedUser, obj.assignGrp, obj.reassign))
                return true;
            else
                return false;

        }
    }
}
