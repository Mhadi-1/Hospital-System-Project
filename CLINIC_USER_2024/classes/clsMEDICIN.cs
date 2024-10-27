using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_USER_2024.DataSet1TableAdapters;
namespace CLINIC_USER_2024.classes
{
    internal class clsMEDICIN
    {
        public static long MED_ID;
        public static long MED_CODE;
        public static string MED_NAME;
        public static string MED_S_NAME;
        public static string MED_SOURES;
        public static decimal MED_PRICE;
        public static long CLI_ID;
        public static MEDCIN_TBLTableAdapter MEDCIN_TD = new MEDCIN_TBLTableAdapter(); 
        public DataTable MEDCIN_LIST()
        {
            DataTable dt = new DataTable();
            dt = MEDCIN_TD.GetData();
            return dt;
        }
    }
}
