using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace COE182P_T_Practical_07
{
    class Stall
    {
        public static void AddStall(SqlConnection SQLconn, string StallTypeName, string StallDescription)
        {
            using (SqlCommand command = new SqlCommand("dbo.AddNewStall", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@NameStall", SqlDbType.VarChar, 100).Value = StallTypeName;
                command.Parameters.Add("@DescStall", SqlDbType.VarChar, 200).Value = StallDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateStall(SqlConnection SQLconn, int StallID, string StallTypeName, string StallDescription)
        {
            using (SqlCommand command = new SqlCommand("dbo.UpdateStall", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDStall", SqlDbType.Int).Value = StallID;
                command.Parameters.Add("@NameStall", SqlDbType.VarChar, 100).Value = StallTypeName;
                command.Parameters.Add("@DescStall", SqlDbType.VarChar, 200).Value = StallDescription;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }

        public static void DeleteStall(SqlConnection SQLconn, int StallID)
        {
            using (SqlCommand command = new SqlCommand("dbo.DeleteStall", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDStall", SqlDbType.Int).Value = StallID;
                SQLconn.Open();
                command.ExecuteNonQuery();
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }

        public static List<StallList> GetStallList(SqlConnection SQLconn)
        {
            List<StallList> SL = new List<StallList>();
            using (SqlCommand command = new SqlCommand("dbo.GetStallList", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SQLconn.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        StallList tempSL = new StallList();
                        tempSL.StallID = reader.GetInt32(0);
                        tempSL.StallName = reader.GetString(1);
                        tempSL.StallDescription = reader.GetString(2);
                        SL.Add(tempSL);
                    }
                }
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
            return SL;
        }
    }
    public class StallList
    {
        public int StallID { get; set; }
        public string StallName { get; set; }
        public string StallDescription { get; set; }
    }
}
