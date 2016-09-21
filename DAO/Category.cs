using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DAO
{
    public class Category 
    {
        public CatDal mainCatDal = new CatDal();
        private int typeId;
        private String mainCat;
        private int mainCatID;
        private String category;
        private int catID;
        private int uGrouoId;

        public int UGrouoId
        {
            get { return uGrouoId; }
            set { uGrouoId = value; }
        }

       
        private int subCatID;

        public int SubCatID
        {
            get { return subCatID; }
            set { subCatID = value; }
        }
        private String subCat;

        public String SubCat
        {
            get { return subCat; }
            set { subCat = value; }
        }

        public int CatID
        {
            get { return catID; }
            set { catID = value; }
        }

        public String Category1
        {
            get { return category; }
            set { category = value; }
        }

        public int MainCatID
        {
            get { return mainCatID; }
            set { mainCatID = value; }
        }

        public String MainCat
        {
            get { return mainCat; }
            set { mainCat = value; }
        }
        private String desc;

        public String Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
     


        public int TypeId
        {
          get { return typeId; }
          set { typeId = value; }
        }


       
        //Method for manage main categories
        public Boolean InsertMainCategory(Category obj)
        {
            if (mainCatDal.insertMainCat(obj.typeId, obj.MainCat, obj.desc, obj.status))
                return true;
            else
                return false;

        }
        //Method for manage main categories
        public DataTable GetAllMainCategory()
        {
            DataTable Dt = mainCatDal.GetAllMainCategory();
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

        //Method for manage main categories by category
        public DataTable GetAllMainCategoryByName(String category)
        {
            DataTable Dt = mainCatDal.GetAllMainCategoryByName(category);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

        public DataTable GetMainCat(Category obj)
        {
            DataTable Dt = mainCatDal.GetMainCategory(obj.typeId);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return Dt;

        }

        public DataTable GetCategoryByMaincat(Category obj)
        {
            DataTable Dt = mainCatDal.GetCategory(obj.mainCatID);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return Dt;

        }

        public DataTable GetSubCategoryByCat(Category obj)
        {
            DataTable Dt = mainCatDal.GetSubCategoryByCategory(obj.catID);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return Dt;

        }



        public DataTable GetAllData()
        {
            DataTable Dt = mainCatDal.GetAllDataForCategory();
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

        public DataTable GetAllDataWithSubCat(Category obj)
        {
            DataTable Dt = mainCatDal.GetAllDataForSubCategory(obj.catID);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

       
        public Boolean InsertCategory(Category obj)
        {
            if (mainCatDal.inserCat( obj.mainCatID,obj.category, obj.desc, obj.status))
                return true;
            else
                return false;

        }



        //Method for manage main categories by category
        public DataTable GetCategoryByName(String category)
        {
            DataTable Dt = mainCatDal.GetCategoryByName(category);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return null;

        }

     
        public DataTable GetSubCategoryByName(String subCategory)
        {
            DataTable Dt = mainCatDal.GetSubCategoryByName(subCategory);
            if (Dt.Rows.Count > 0)
                return Dt;
            else
                return Dt;

        }


        //Method for manage sub  categories
        public Boolean InsertSubCategory(Category obj)
        {
            if (mainCatDal.inserSubCat(obj.catID,obj.subCat , obj.desc, obj.status,obj.uGrouoId,"Admin"))
                return true;
            else
                return false;

        }

    }
}
