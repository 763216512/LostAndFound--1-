
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using IDAL;
using Model;
using System.Data.SqlClient;
using System.Data;


namespace SQLDAL
{
    public class SQL_Area : IDAL_Published
    {


        public IList<Published> getPublishedInf(string lx)
        {

            string SQL_getTableInf = "";
            if (lx == "11")
            {
                SQL_getTableInf = "select M_Area.AreaID,M_Area.ParentID,M_Area.AreaName,ISNULL(M_Area.ChildNum,'0')   from M_Area where  ParentID='-1' or ParentID='1' or ParentID='2'  or ParentID='3' or ParentID='4'";
            }
            else
            {
                SQL_getTableInf = "";
            }
            SQL_getTableInf = "select M_Area.AreaID,M_Area.ParentID,M_Area.AreaName,ISNULL(M_Area.ChildNum,'0')   from M_Area where  ParentID='-1' or ParentID='1' or ParentID='2'  or ParentID='3' or ParentID='4'";

            IList<Published> PublishedInf = new List<Published>();
            using (SqlDataReader SqlData = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, SQL_getTableInf))
            {
                while (SqlData.Read())
                {



                    Published TableMsg = new Published(SqlData.GetInt32(0), SqlData.GetString(1), SqlData.GetString(2), SqlData.GetString(3));
                    PublishedInf.Add(TableMsg);
                }
            }
            return PublishedInf;
        }



    }

}


