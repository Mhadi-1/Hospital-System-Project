using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data;

namespace CLINIC_USER_2024.classes
{
    internal class clsCOMPANY
    {
        public static long COM_ID;
        public static long COM_CODE;
        public static string COM_NAME = "";
        public static string COM_ADDERSS = "";
        public static string COM_MOBILE = "";
        public static string COM_STATE = "";
        public static long CLI_ID;
        public static COMPANY_TBLTableAdapter COMPANY_DT = new COMPANY_TBLTableAdapter();

        public DataTable COMAPANY_LIST()
        {
            DataTable dt = new DataTable();
            dt = COMPANY_DT.GetData();
            if(dt.Rows.Count > 0 )
            {
            classes.clsCOMPANY.COM_ID = Convert.ToInt64(dt.Rows[0]["COM_ID"]);
            classes.clsCOMPANY.COM_CODE = Convert.ToInt64(dt.Rows[0]["COM_CODE"]);
            classes.clsCOMPANY.COM_NAME = dt.Rows[0]["COM_NAME"].ToString();
            classes.clsCOMPANY.COM_ADDERSS = dt.Rows[0]["COM_ADDRESS"].ToString();
            classes.clsCOMPANY.COM_MOBILE = dt.Rows[0]["COM_MOBILE"].ToString();
            classes.clsCOMPANY.COM_STATE = dt.Rows[0]["COM_STATE"].ToString();
            classes.clsCOMPANY.CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);

            }

            return dt;
        }

        public DataTable GETCOMPANY_BY_NAME(string str_compName)
        {
            DataTable dt = new DataTable();
            dt = COMPANY_DT.GetCOMPANY_BY_NAME(str_compName);

            if(dt.Rows.Count > 0 )
            {
               classes.clsCOMPANY.COM_ID = Convert.ToInt64(dt.Rows[0]["COM_ID"]);
               classes.clsCOMPANY.COM_CODE = Convert.ToInt64(dt.Rows[0]["COM_CODE"]);
               classes.clsCOMPANY.COM_NAME = dt.Rows[0]["COM_NAME"].ToString();
               classes.clsCOMPANY.COM_ADDERSS = dt.Rows[0]["COM_ADDRESS"].ToString();
               classes.clsCOMPANY.COM_MOBILE = dt.Rows[0]["COM_MOBILE"].ToString();
               classes.clsCOMPANY.COM_STATE = dt.Rows[0]["COM_STATE"].ToString();
               classes.clsCOMPANY.COM_ID = Convert.ToInt64(dt.Rows[0]["COM_ID"]);
            }
            return dt;
        }
        public void GETCOMAPNYBYCODE(decimal COM_CODE)
        {
            DataTable dt = new DataTable();
            dt = COMPANY_DT.GetCOMPANYBY_CODE(COM_CODE);
            if(dt.Rows.Count > 0 )
            classes.clsCOMPANY.CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            classes.clsCOMPANY.COM_CODE = Convert.ToInt64(dt.Rows[0]["COM_CODE"]);
            classes.clsCOMPANY.COM_NAME = dt.Rows[0]["COM_NAME"].ToString();
            classes.clsCOMPANY.COM_ADDERSS = dt.Rows[0]["COM_ADDRESS"].ToString();
            classes.clsCOMPANY.COM_MOBILE = dt.Rows[0]["COM_MOBILE"].ToString();
            classes.clsCOMPANY.COM_STATE = dt.Rows[0]["COM_STATE"].ToString();
            classes.clsCOMPANY.COM_ID = Convert.ToInt64(dt.Rows[0]["COM_ID"]);
        }

    }
}
