using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data;
using CLINIC_USER_2024.list_form;

namespace CLINIC_USER_2024.classes
{
    internal class clsCUST
    {
        public static long CUST_ID;
        public static long CUST_CODE;
        public static string CUST_F_NMAE;
        public static string CUST_S_NAME;
        public static string CUST_T_NAME;
        public static string CUST_L_NAME;
        public static string CUST_AGE;
        public static string CUST_BD;
        public static string CUST_MOBILE_1;
        public static string CUST_MOBILE_2;
        public static string CUST_ADDERSS;
        public static string CUST_CARD_STATE;
        public static long CARD_ID;
        public static long CLI_ID;

        public static CUST_TBLTableAdapter CUST_ST = new CUST_TBLTableAdapter(); 

        public DataTable CUST_LIST()
        {
            DataTable dt =  new DataTable();
            dt = CUST_ST.CUST_LIST();
            return dt; 
        }

    }
}
