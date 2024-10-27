using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data; 

namespace CLINIC_USER_2024.classes
{
    internal class clsAPO
    {
        public static long   APO_ID;
        public static long   APO_CODE;
        public static string APO_DATE = "";
        public static string APO_TIME = "";
        public static string APO_NOTE = "";
        public static string APO_NAME = "";
        public static long   CLI_ID;
        public static long   CUST_ID;
        public static long   DOC_ID; 

        public static APO_TBTableAdapter APO_DATATABLE = new APO_TBTableAdapter(); 

        public DataTable APO_LIST()
        {
            DataTable dt = new DataTable();
            dt = APO_DATATABLE.GetData();
            return dt; 
        }

        public DataTable APOI_LIST_BY_DATE_AND_DOCNAME_CUSTNAME(string F_DATE , string S_DATE , string DOC_NAME , string CUST_NAME)
        {
            DataTable dt = new DataTable();
            dt = APO_DATATABLE.APO_LISTbyDATEorDOC_NAMEorCUS_NAME(F_DATE, S_DATE, DOC_NAME, CUST_NAME);
            return dt; 
        }

        public DataTable APOI_LIST_BY_DOCNAME(string CUST_NAME)
        {
            DataTable dt = new DataTable();
            dt = APO_DATATABLE.APO_LIS_BY_CUSTNAME(CUST_NAME);
            return dt; 
        }

        public DataTable APO_LIST_BY_CODE(long APOI_CODE)
        {
            DataTable dt = new DataTable();
            dt = APO_DATATABLE.APO_LISTby_APO_CODE(APO_CODE); 

            if(dt.Rows.Count > 0 )
            {
                APO_ID   = Convert.ToInt64(dt.Rows[0]["APO_ID"]);
                APO_CODE = Convert.ToInt64(dt.Rows[0]["APO_CODE"]); 
                APO_DATE = dt.Rows[0]["APO_DATE"].ToString();
                APO_TIME = dt.Rows[0]["APO_TIME"].ToString();
                APO_NOTE = dt.Rows[0]["APO_NOTE"].ToString();
                APO_NAME = dt.Rows[0]["APO_NAME"].ToString();
                CLI_ID   = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
                CUST_ID  = Convert.ToInt64(dt.Rows[0]["CUST_ID"]);
                DOC_ID   = Convert.ToInt64(dt.Rows[0]["DOC_ID"]); 
            }

            return dt; 

        }

    }

}
