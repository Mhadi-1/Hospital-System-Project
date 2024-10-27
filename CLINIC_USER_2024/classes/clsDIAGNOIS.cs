using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_USER_2024.DataSet1TableAdapters;

namespace CLINIC_USER_2024.classes
{
    internal class clsDIAGNOIS
    {
        public static long   DIG_ID;
        public static long   DIG_CODE;
        public static string DIG_NAME;
        public static string DIG_TYPE;
        public static string DIG_NOTE;
        public static long   CLI_ID;
        public static string DOC_NAME;
        public static DIAGNOIS_TBLTableAdapter DIAGNOIS_TB = new DIAGNOIS_TBLTableAdapter(); 

        public static DataTable DIAGNOIS_LIST()
        {
            DataTable dt = new DataTable();
            dt = DIAGNOIS_TB.GetData();
            return dt; 
        }
        public static DataTable FINDDIGANOC(string DIG_NAME)
        {
            DataTable dt = new DataTable();

            dt = DIAGNOIS_TB.GETDIGANOS_BYNAME(DIG_NAME);

            classes.clsDIAGNOIS.DIG_ID   = Convert.ToInt64(dt.Rows[0]["DIG_ID"]);
            classes.clsDIAGNOIS.DIG_CODE = Convert.ToInt64(dt.Rows[0]["DIG_CODE"]);
            classes.clsDIAGNOIS.DIG_NAME = dt.Rows[0]["DIG_NAME"].ToString();
            classes.clsDIAGNOIS.DIG_TYPE = dt.Rows[0]["DIG_TYPE"].ToString();
            classes.clsDIAGNOIS.DIG_NOTE = dt.Rows[0]["DIG_NOTE"].ToString();
            classes.clsDIAGNOIS.CLI_ID   = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            classes.clsDIAGNOIS.DOC_NAME = dt.Rows[0]["DOC_NAME"].ToString();

            return dt; 
        }
    }
}
