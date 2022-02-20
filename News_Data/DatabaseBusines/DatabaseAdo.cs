using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Data.DatabaseBusines
{
    public class DatabaseAdo
    {
        public SqlConnection dbConnect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=den1.mssql7.gear.host; database=news2; uid=news2; password=Kf0tJ62-QBw!;";
            return conn;
        }

        public DataTable GetAppInfo(string appGuidId)
        {
            SqlConnection conn = dbConnect();


            string SqlString = "select * from Settings where AppGuid = @AppGuid";
            SqlCommand cmd = new SqlCommand(SqlString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("AppGuid", appGuidId);

            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }
    }
}
