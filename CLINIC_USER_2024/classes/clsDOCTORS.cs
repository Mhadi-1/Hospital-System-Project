using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_USER_2024.DataSet1TableAdapters;

namespace CLINIC_USER_2024.classes
{
    internal class clsDOCTORS
    {
        public static long DOC_ID;
        public static long DOC_CODE;
        public static string DOC_NAME = "";
        public static string DOC_MAJOR = "";
        public static string DOC_EXP = "";
        public static string DOC_BD = "";
        public static string DOC_MOBILE = "";
        public static string DOC_ADDRESS = "";
        public static long CLI_ID;
        public static long USER_ID;

        public static DOCTORS_TBTableAdapter DOCTOR_DT = new DOCTORS_TBTableAdapter();
        public DataTable DOCTORS_LIST()
        {
            DataTable Data_Table = new DataTable();
            Data_Table = DOCTOR_DT.GetData();
            return Data_Table;
        }

        public DataTable DOCLIST_BY_DOC_NAME(string S_DOC_NAME)
        {
            DataTable Data_Table = new DataTable();
            Data_Table = DOCTOR_DT.DOCLIST_BY_DOC_NAME(S_DOC_NAME);

            clsDOCTORS.DOC_ID = Convert.ToInt16(Data_Table.Rows[0][0]);
            clsDOCTORS.DOC_CODE = Convert.ToInt16(Data_Table.Rows[0][1]);
            clsDOCTORS.DOC_NAME = (Data_Table.Rows[0]["DOC_NAME"].ToString());
            clsDOCTORS.DOC_MAJOR = (Data_Table.Rows[0]["DOC_MAJOR"].ToString());
            clsDOCTORS.DOC_EXP = (Data_Table.Rows[0]["DOC_EXP"].ToString());
            //clsDOCTORS.DOC_BD = (Data_Table.Rows[0]["DOC_BD"].ToString());
            clsDOCTORS.DOC_MOBILE = (Data_Table.Rows[0]["DOC_MOBILE"].ToString());
            clsDOCTORS.DOC_ADDRESS = Data_Table.Rows[0]["DOC_ADDRESS"].ToString();
            clsDOCTORS.CLI_ID = Convert.ToInt16(Data_Table.Rows[0]["CLI_ID"]);
            return Data_Table;
        }
        public static DataTable DOCTOR_DATA(long USER_ID)
        {
            DataTable Data_Table = new DataTable();
            Data_Table = DOCTOR_DT.GET_DOCTOR_ID(USER_ID);

            if(Data_Table.Rows.Count >0)
            {
               clsDOCTORS.DOC_ID = Convert.ToInt16(Data_Table.Rows[0][0]);
               clsDOCTORS.DOC_CODE = Convert.ToInt16(Data_Table.Rows[0][1]);
               clsDOCTORS.DOC_NAME = (Data_Table.Rows[0]["DOC_NAME"].ToString());
               clsDOCTORS.DOC_MAJOR = (Data_Table.Rows[0]["DOC_MAJOR"].ToString());
               clsDOCTORS.DOC_EXP = (Data_Table.Rows[0]["DOC_EXP"].ToString());
               //clsDOCTORS.DOC_BD = (Data_Table.Rows[0]["DOC_BD"].ToString());
               clsDOCTORS.DOC_MOBILE = (Data_Table.Rows[0]["DOC_MOBILE"].ToString());
               clsDOCTORS.DOC_ADDRESS = (Data_Table.Rows[0]["DOC_ADDRESS"].ToString());
               clsDOCTORS.CLI_ID = Convert.ToInt16(Data_Table.Rows[0]["CLI_ID"]);
               clsDOCTORS.USER_ID = Convert.ToInt64(Data_Table.Rows[0]["USER_ID"]);
            }
            return Data_Table;

        }
    }
}
