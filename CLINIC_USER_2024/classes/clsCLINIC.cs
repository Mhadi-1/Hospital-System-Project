using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_USER_2024.DataSet1TableAdapters;

namespace CLINIC_USER_2024.classes
{
    internal class clsCLINIC
    {
        public static long CLI_ID;
        public static long CLI_CODE;
        public static string CLI_NAME = "";
        public static string CLI_LOC = "";
        public static string CLI_NOTE;
        public static CLINIC_TBTableAdapter CLINIC_DT = new CLINIC_TBTableAdapter();

        public  DataTable CLINIC_LIST()
        {
            DataTable dt = new DataTable();
            dt = CLINIC_DT.GetData();
            return dt;
        }

        public  DataTable SELECTCLINAME(string st_CLININ_NAME)
        {
            DataTable dt = new DataTable();
            dt = CLINIC_DT.GETCLINICBY_NAME(st_CLININ_NAME);
            classes.clsCLINIC.CLI_ID     = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            classes.clsCLINIC.CLI_CODE   = Convert.ToInt64(dt.Rows[0]["CLI_CODE"]);
            classes.clsCLINIC.CLI_NAME   = dt.Rows[0]["CLI_NAME"].ToString();
            classes.clsCLINIC.CLI_LOC    = dt.Rows[0]["CLI_LOC"].ToString();
            classes.clsCLINIC.CLI_NOTE   = dt.Rows[0]["CLI_NOTE"].ToString();
            return dt;
        }
    }
}
