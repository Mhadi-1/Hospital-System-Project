using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_USER_2024.DataSet1TableAdapters;

namespace CLINIC_USER_2024.classes
{
    internal class clsUsers
    {
        public static long USER_ID;
        public static long USER_CODE;
        public static string USER_NAME = "";
        public static string USER_PASSWORD = "";
        public static string USER_TYPE = "";
        public static long CLI_ID;
        public static USERS_TBLTableAdapter USER_DT = new USERS_TBLTableAdapter();

        public DataTable User_List()
        {
            DataTable Data_Table = new DataTable();
            Data_Table =  USER_DT.GetData();
            return Data_Table;
        }

        public static DataTable Select_User(string User_Name)
        {
            DataTable Data_Table = new DataTable();

            clsUsers.USER_ID = Convert.ToInt16(Data_Table.Rows[0][0]);
            clsUsers.USER_CODE = Convert.ToInt16(Data_Table.Rows[0][1]);
            clsUsers.USER_NAME = Data_Table.Rows[0][2].ToString();
            clsUsers.USER_PASSWORD = Data_Table.Rows[0][3].ToString();
            clsUsers.USER_TYPE = Data_Table.Rows[0][4].ToString();
            clsUsers.CLI_ID = Convert.ToInt16(Data_Table.Rows[0][5]);
            return Data_Table;
        }
        public static DataTable USER_LOGIN(string LOG_USER_NAME ,string LOG_USER_PASSWORD ,string LOG_USER_TYPE)
        {

            DataTable Data_Table = new DataTable();

            Data_Table = USER_DT.GetDataBy(LOG_USER_NAME, LOG_USER_PASSWORD, LOG_USER_TYPE);
            if(Data_Table.Rows.Count > 0)
            {

            clsUsers.USER_ID = Convert.ToInt16(Data_Table.Rows[0][0]);
            clsUsers.USER_CODE = Convert.ToInt16(Data_Table.Rows[0][1]);
            clsUsers.USER_NAME = Data_Table.Rows[0][2].ToString();
            clsUsers.USER_PASSWORD = Data_Table.Rows[0][3].ToString();
            clsUsers.USER_TYPE = Data_Table.Rows[0][4].ToString();
            clsUsers.CLI_ID = Convert.ToInt16(Data_Table.Rows[0][5]);

            if (clsUsers.USER_TYPE == "DOCTOR")
            {
                classes.clsDOCTORS.DOCTOR_DATA(clsUsers.USER_ID);
            }

            }

            else
            {

            }


            return Data_Table;
        }
         public static  bool CHICK_LOGIN(string LOG_USER_NAME ,  string USER_PASSWORD , string USER_TYPE)
         {
            DataTable dt = new DataTable();
            dt = USER_LOGIN(LOG_USER_NAME,USER_PASSWORD, USER_TYPE); 
            if (dt.Rows.Count > 0 )
            {
                return true; 
            }
            return false; 

         }
    }
}
