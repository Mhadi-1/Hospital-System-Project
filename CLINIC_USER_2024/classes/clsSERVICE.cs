using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_USER_2024.DataSet1TableAdapters; 

namespace CLINIC_USER_2024.classes
{
    internal class clsSERVICE
    {
        public static long SER_ID;
        public static long SER_CODE;
        public static string SER_NAME;
        public static string SER_TYPE;
        public static decimal SER_PRICE;
        public static string SER_NOTE;
        public static long CLI_ID;
        public static SERVICE_TBLTableAdapter SERVICE_DT = new SERVICE_TBLTableAdapter();


        public DataTable SERVICE_LIST()
        {
            DataTable dt = new DataTable();
            dt = SERVICE_DT.GetData();
            if(dt.Rows.Count > 0 )
            {
                classes.clsSERVICE.SER_ID = Convert.ToInt64(dt.Rows[0]["SER_ID"]);
                classes.clsSERVICE.SER_CODE = Convert.ToInt64(dt.Rows[0]["SER_CODE"]);
                classes.clsSERVICE.SER_NAME = dt.Rows[0]["SER_NAME"].ToString();
                classes.clsSERVICE.SER_TYPE = dt.Rows[0]["SER_TYPE"].ToString();
                classes.clsSERVICE.SER_PRICE = Convert.ToInt64(dt.Rows[0]["SER_PRICE"]);
                classes.clsSERVICE.SER_NOTE = dt.Rows[0]["SER_NOTE"].ToString();
                classes.clsSERVICE.CLI_ID   =Convert.ToInt64( dt.Rows[0]["CLI_ID"]);
            }

            return dt;
        }

        public DataTable FINDSER_BYNAME(string ServiceName)
        {
             DataTable dt = new DataTable();
            dt = SERVICE_DT.GetSERVICEBYNAME(ServiceName);

            if (dt.Rows.Count > 0)
            {

               classes.clsSERVICE.SER_ID = Convert.ToInt64(dt.Rows[0]["SER_ID"]);
               classes.clsSERVICE.SER_CODE = Convert.ToInt64(dt.Rows[0]["SER_CODE"]);
               classes.clsSERVICE.SER_NAME = dt.Rows[0]["SER_NAME"].ToString();
               classes.clsSERVICE.SER_TYPE = dt.Rows[0]["SER_TYPE"].ToString();
               classes.clsSERVICE.SER_PRICE = Convert.ToInt64(dt.Rows[0]["SER_PRICE"]);
               classes.clsSERVICE.SER_NOTE = dt.Rows[0]["SER_NOTE"].ToString();
               classes.clsSERVICE.CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            }
            return dt;

        }

    }    

}
